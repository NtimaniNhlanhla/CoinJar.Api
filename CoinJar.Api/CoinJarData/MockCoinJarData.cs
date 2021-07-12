using CoinJar.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.Api.CoinJarData
{
    public class MockCoinJarData : ICoinJar
    {
        private List<Coin> coins = new List<Coin>();
       
        public void AddCoin(Coin coin)
        {
            if(coin.Volume <= 42)
            {
                coins.Add(coin);
            }
            
        }

        public decimal GetTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var coin in coins)
            {
                totalAmount += coin.Amount;
            }
            return totalAmount;
        }

        public void Reset()
        {
            foreach (var coin in coins)
            {
                coin.Amount = 0;
            }
        }
    }
}
