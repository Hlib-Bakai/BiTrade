using BittrexSharp;
using BittrexSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiTrade
{

    class BittrexPlatform : IPlatform
    {
        private Bittrex bittrex;

        public BittrexPlatform()
        {
            Restart();
        }

        public void Restart()
        {
            string apiKey = AppSetings.Default.BittrexApiKey;
            if (apiKey.Length > 0)
            {
                bittrex = new Bittrex(apiKey, 
                                        Security.ToInsecureString(Security.DecryptString(AppSetings.Default.BittrexApiSecret)));
            }
            else
            {
                bittrex = new Bittrex("", "");
            }
        }

        public async Task<ApiStatus> CheckKeySecret()
        {
            var task = bittrex.GetBalance("BTC");
            var res = await Task.WhenAny(task, Task.Delay(10000));
            if (res == task)
            {
                // Task completed within time.
                if (task.Result.Message.CompareTo("APIKEY_INVALID") == 0 ||
                    task.Result.Message.CompareTo("INVALID_SIGNATURE") == 0)
                {
                    return ApiStatus.FALSE;
                } else
                {
                    return ApiStatus.TRUE;
                }
            }
            else
            {
                // Task timed out
                return ApiStatus.CONNECTION_TIMEOUT;
            }
        }

        public async Task<decimal> GetBalanceBtc()
        {
            var all = await bittrex.GetBalances();
            decimal total = 0;
            decimal price = 0;

            foreach (var balance in all.Result.Where(x => x.Balance > 0))
            {
                decimal estBtcValue = 0;

                if (balance.Currency == "BTC")
                {
                    estBtcValue = balance.Balance;
                    total += estBtcValue;
                }
                else if (balance.Currency == "USDT")
                {
                    var market = await bittrex.GetMarketSummary("USDT-BTC");
                    price = market.Result.Last;
                    estBtcValue = balance.Balance / price;
                    total += estBtcValue;
                }
                else
                {
                    try
                    {
                        var market = await bittrex.GetMarketSummary("BTC-" + balance.Currency);
                        price = market.Result.Last;
                        estBtcValue = price * balance.Balance;
                        total += estBtcValue;
                    }
                    catch
                    {
                        // LOG
                    }
                }
            }

            return total;
        }

        public async Task<decimal> GetBalanceUsd()
        {
            var btc = await GetBalanceBtc();
            var price = await GetPriceBtc();
            return btc * price;
        }

        public async Task<decimal> GetPriceBtc()
        {
            var market = await bittrex.GetMarketSummary("USDT-BTC");
            return market.Result.Last;
        }

        public async Task<decimal> GetPriceCurrencyUsd(string currency)
        {
            var market = await bittrex.GetMarketSummary("USDT-" + currency);
            if (market.Success)
                return market.Result.Last;
            else
            {
                var inBtc = await bittrex.GetMarketSummary("BTC-" + currency);
                var price = await GetPriceBtc();
                return inBtc.Result.Last * price;
            }                
        }

        public async Task<decimal> GetBalance(string currency)
        {
            throw new NotImplementedException();
        }

        public async Task<MarketSummary> GetMarketSummary(string marketName)
        {
            var market = await bittrex.GetMarketSummary(marketName);
            if (market.Success)
                return market.Result;
            else
            {
                return null;
            }
        }
    }
}
