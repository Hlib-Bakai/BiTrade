using BittrexSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiTrade
{
    interface IPlatform
    {
        Task<decimal> GetBalanceBtc();
        Task<decimal> GetBalanceUsd();
        Task<decimal> GetPriceBtc();
        Task<decimal> GetPriceCurrencyUsd(string currency);
        Task<decimal> GetBalance(string currency);
        Task<MarketSummary> GetMarketSummary(string marketName);
        Task<ApiStatus> CheckKeySecret();
    }
}
