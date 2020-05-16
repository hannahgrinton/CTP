using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text;
using System.IO;
using CTP.Models;

namespace CTP.Controllers
{
    public class HomeController : Controller
    {
        private BookManager bookManager;
        private IWebHostEnvironment environment;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BookManager myManager, IWebHostEnvironment env)
        {
            _logger = logger;
            bookManager = myManager;
            environment = env;
        }

        public IActionResult Index()
        {
            return View(bookManager);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
