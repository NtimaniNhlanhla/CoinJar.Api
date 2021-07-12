using CoinJar.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.Api.CoinJarData
{
    public interface ICoinJar
    {
        void AddCoin(Coin coin);
        decimal GetTotalAmount();
        void Reset();
    }
}
