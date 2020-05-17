using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
using CTP.Models;

namespace CTP.Controllers
{
    public class HomeController : Controller
    {
        private BookManager bookManager;
        // private IWebHostEnvironment environment;
        public HomeController(BookManager myManager)
        {
            bookManager = myManager;
            // environment = env;
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
