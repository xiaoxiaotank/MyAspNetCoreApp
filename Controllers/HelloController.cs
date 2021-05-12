using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return $"{DateTime.Now:o}: Hello !";
        }

        [HttpGet("{name}")]
        public string Get(string name)
        {
            return $"{DateTime.Now:o}: Hello {name} !";
        }
    }
}
