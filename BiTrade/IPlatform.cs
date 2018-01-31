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
    }
}
