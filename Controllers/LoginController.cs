using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using CTP.Models;

//this is the controller for the login for the administration end of the app
namespace CTP.Controllers {

    public class LoginController : Controller {

        public IActionResult Index() {
            HttpContext.Session.SetString("auth", "false");
            return View();
        }

        public IActionResult Submit(string myUsername, string myPassword) {
            WebLogin webLogin = new WebLogin("Server=localhost;Database=dbCTP;Uid=root;Pwd=;SslMode=none;", HttpContext);
            webLogin.username = myUsername;
            webLogin.password = myPassword;
            //do I have access?
            if (webLogin.unlock()) {
                //access granted
                Console.WriteLine("\n\n\nSession Auth: " + HttpContext.Session.GetString("auth"));
                return RedirectToAction("Index", "Admin");
            } else {
                //access denied
                ViewData["feedback"] = "Incorrect login. Please try again...";
            }
            return View("Index");
        }
    }
}
