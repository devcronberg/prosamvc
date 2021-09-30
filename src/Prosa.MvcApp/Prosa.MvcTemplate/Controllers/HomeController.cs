//// Demo log
//logger.LogInformation("Test af app log");

//// Demo brug af repository            
//List<Person> personer = personRepository.HentPersoner();
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prosa.MvcTemplate.Models;
using Prosa.MvcTemplate.Models.ViewModels.Home;
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
        public IActionResult Index()    
        {
            IndexViewModel model = new IndexViewModel();
            model.Nu = TidsHelper.HentTid();
            model.SettingAVærdi = settings.SettingA;
            //PersonRepositoryFilMock rep = new PersonRepositoryFilMock(System.IO.Path.Combine(environment.ContentRootPath, "data"));
            //PersonRepositoryProd rep = new PersonRepositoryProd(System.IO.Path.Combine(environment.ContentRootPath, "data"));
            model.Personer = personRepository.HentPersoner();

            return View(model);
        }

        [HttpGet("~/data")]
        public IActionResult Data()
        {
            var personer = personRepository.HentPersoner();
            return Json(personer);
        }

        [HttpGet("~/js")]
        public IActionResult Js()
        {
            var personer = personRepository.HentPersoner();
            return View(personer);
        }

        [HttpGet("~/Index2")]
        public IActionResult Index2()    
        {
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
