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
            ViewBag.Current = "";
            return View(bookManager);
        }

        public IActionResult Ebooks() {
            ViewBag.Current = "Ebooks";
            return View(bookManager);
        }

        public IActionResult Books() {
            ViewBag.Current = "Books";
            return View(bookManager);
        }

        public IActionResult Booklets() {
            ViewBag.Current = "Booklets";
            return View(bookManager);
        }

        public IActionResult Study() {
            ViewBag.Current = "Study";
            return View(bookManager);
        }

        public IActionResult Languages() {
            ViewBag.Current = "Languages";
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
