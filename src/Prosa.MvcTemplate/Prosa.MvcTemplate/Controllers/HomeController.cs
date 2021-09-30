using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prosa.MvcTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prosa.MvcTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly Settings settings;
        private readonly IWebHostEnvironment environment;
        private readonly ILogger<HomeController> logger;
        private readonly IPersonRepository personRepository;

        [HttpGet("~/")]
        public IActionResult Index()    // public async Task<IActionResult> Index()        
        {
            // Demo log
            logger.LogInformation("Test af app log");

            // Demo brug af repository            
            List<Person> personer = personRepository.HentPersoner();

            return View();
        }

        public HomeController(Settings settings, IWebHostEnvironment environment, ILogger<HomeController> logger, IPersonRepository personRepository)
        {
            this.settings = settings;
            this.environment = environment;
            this.logger = logger;
            this.personRepository = personRepository;
        }
    }
}
