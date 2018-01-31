using BittrexSharp;
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
            bittrex = new Bittrex();
        }

        public async Task<decimal> GetBalanceBtc()
        {
            return new decimal(0.13245);
        }

        public async Task<decimal> GetBalanceUsd()
        {
            return new decimal(164.80);
        }

        public async Task<decimal> GetPriceBtc()
        {
            var market = await bittrex.GetMarketSummary("USDT-BTC");
            return market.Result.Last;
        }
    }
}
