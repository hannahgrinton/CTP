using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CTP.Models;

//this is the controller for the administration end of the app
namespace CTP.Controllers {

    public class AdminController : Controller {
        private BookManager bookManager;
        public AdminController(BookManager myManager) {
            bookManager = myManager;
        }
        public IActionResult Index() {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            }
            return View(bookManager);
        }
        public IActionResult Logout() {
            //logs user out and reqirects to login page
            HttpContext.Session.SetString("auth", "false");
            return RedirectToAction("Index", "Login");
        }
    }
}