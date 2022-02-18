using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1;

namespace Task2.API
{
    [Route("api/textcalculator")]
    [ApiController]
    public class TextCalculator : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [Route("{text}")]
        [HttpGet]
        public IActionResult Result([FromRoute] string text)
        {
            Task1.TextCalculator t = new Task1.TextCalculator();
            string result = t.Add(text);

            return Ok(result);
        }
    }
}
