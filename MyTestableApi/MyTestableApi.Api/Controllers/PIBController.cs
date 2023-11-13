using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MyTestableApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PIBController : ControllerBase
    {
        [HttpGet("GetPIBData/{country}")]
        public IActionResult GetPIBData(string country)
        {
            var data = new Dictionary<int, double>
            {
                { 2020, 1000000.0 },
                { 2021, 1200000.0 },
                { 2022, 1500000.0 }
            };

            return Ok(data);
        }

        [HttpPost("CollecterPIBData/{country}/{year}")]
        public IActionResult CollecterPIBData(string country, int year)
        {

            var message = $"Données du PIB pour {country} en {year} collectées avec succès.";
            return Ok(message);
        }
    }
}
