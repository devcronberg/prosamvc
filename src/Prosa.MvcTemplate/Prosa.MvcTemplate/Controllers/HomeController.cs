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
            logger.LogInformation("Test af app log");
            return View();
        }

        public HomeController(Settings settings, IWebHostEnvironment environment, ILogger<HomeController> logger, IPersonRepository personRepository)
        {
            this.settings = settings;
            this.environment = environment;
            this.logger = logger;
            this.personRepository = personRepository;
            var t = personRepository.HentPersoner();
        }
    }
}
