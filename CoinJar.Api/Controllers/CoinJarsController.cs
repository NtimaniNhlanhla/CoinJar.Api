using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinJar.Api.CoinJarData;
using CoinJar.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoinJar.Api.Controllers
{
  
    [ApiController]
    public class CoinJarsController : ControllerBase
    {
        private readonly ICoinJar _coinJar;
        private const decimal _volume = 42;

        public CoinJarsController(ICoinJar coinJar)
        {
                _coinJar= coinJar;
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCoin(Coin coin)
        {
            _coinJar.AddCoin(coin);
            return Ok();
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetTotalAmount()
        {
          decimal totalAmount =  _coinJar.GetTotalAmount();
            return Ok(totalAmount);
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public IActionResult Reset()
        {
            _coinJar.Reset();
            return Ok();
        }

    }
}
