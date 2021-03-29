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
        
        public HomeController(BookManager myManager)
        {
            bookManager = myManager;
        }

        public IActionResult Index()
        {
            ViewBag.Current = "";
            return View(bookManager);
        }

        public IActionResult About()
        {
            ViewBag.Current = "About";
            return View();
        }

        public IActionResult Ebooks() {
            ViewBag.Current = "Ebooks";
            return View(bookManager);
        }

        public IActionResult Ministry() {
            ViewBag.Current = "Ministry";
            return View(bookManager);
        }

        public IActionResult Booklets() {
            ViewBag.Current = "Booklets";
            return View(bookManager);
        }

        public IActionResult Expositions() {
            ViewBag.Current = "Expositions";
            return View(bookManager);
        }

        public IActionResult Spanish() {
            ViewBag.Current = "Spanish";
            return View(bookManager);
        }
        
        [Route("/ViewMinistry/{id}")]
        public IActionResult ViewMinistry(int id) {
            Ministry ministry = new Ministry();
            ministry = bookManager.getMinistry(id);
            return View(ministry);
        }

        [Route("/ViewExposition/{id}")]
        public IActionResult ViewExposition(int id) {
            Exposition exposition = new Exposition();
            exposition = bookManager.getExposition(id);
            return View(exposition);
        }

        [Route("/ViewBooklet/{id}")]
        public IActionResult ViewBooklet(int id) {
            Booklet booklet = new Booklet();
            booklet = bookManager.getBooklet(id);
            return View(booklet);
        }

        [Route("/ViewEbook/{id}")]
        public IActionResult ViewEbook(int id) {
            Ebook ebook = new Ebook();
            ebook = bookManager.getEbook(id);
            return View(ebook);
        }

        public IActionResult Languages() {
            ViewBag.Current = "Languages";
            return View(bookManager);
        }

        public IActionResult Search(string term) {
            Console.WriteLine("\n\n\nSearch Term: " + term);
            ViewBag.SearchTerm = term;
            bookManager.searchMinistry(term);
            bookManager.searchExpositions(term);
            bookManager.searchEbooks(term);
            bookManager.searchBooklets(term);
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
