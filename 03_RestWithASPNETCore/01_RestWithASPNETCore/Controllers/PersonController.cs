using _01_RestWithASPNETCore.Services;
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
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }
        
        [HttpGet()]
        public IActionResult Get(long id)
        {
            return Ok(_personService.FindById(id));
        }
       
    }
}
