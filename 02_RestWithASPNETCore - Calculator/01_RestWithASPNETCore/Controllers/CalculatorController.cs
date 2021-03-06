using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_RestWithASPNETCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{sencodNumber}")]
        public IActionResult Get(string firstNumber, string sencodNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(sencodNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(sencodNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number);
            return isNumber;
            
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }


    }
}
