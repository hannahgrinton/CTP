using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using CTP.Models;

//this is the controller for the administration end of the app
namespace CTP.Controllers {

    public class AdminController : Controller {
        private BookManager bookManager;
        private IWebHostEnvironment environment;
        public AdminController(BookManager myManager, IWebHostEnvironment env) {
            bookManager = myManager;
            environment = env;
        }
        public IActionResult Index() {
            // if (HttpContext.Session.GetString("auth") != "true") {
            //     return RedirectToAction("Index", "Login");
            // }
            ViewBag.Current = "";
            return View(bookManager);
        }
        public IActionResult Ebooks() {
            ViewBag.Current = "Ebooks";
            return View(bookManager);
        }
        public IActionResult Ministry() {
            ViewBag.Current = "Ministry";
            return View(bookManager);
        }
        public IActionResult Expositions() {
            ViewBag.Current = "Booklets";
            return View(bookManager);
        }
        public IActionResult Booklets() {
            ViewBag.Current = "Expositions";
            return View(bookManager);
        }
        public IActionResult AddEbook() {
            ViewBag.Current = "";
            Ebook ebook = new Ebook();
            return View(ebook);
        }
        [HttpPost]
        public IActionResult AddEbookSubmit(Ebook ebook, IFormFile imgFile, IFormFile epub, IFormFile mobi) {
            if (!ModelState.IsValid) return RedirectToAction("AddEbook");
            ImageManager imageManager = new ImageManager(environment, "images/covers/ebooks");
            FileManager epubManager = new FileManager(environment, "ebooks/epub");
            FileManager mobiManager = new FileManager(environment, "ebooks/mobi");
            int result = imageManager.uploadImage(imgFile);
            switch (result) {
                case 1:
                    Console.WriteLine("\n\n\n*** Wrong File Type! ***");
                    ViewData["feedback"] = "Wrong File Type";
                    return RedirectToAction("AddEbook");
                case 2:
                    Console.WriteLine("\n\n\n*** File Too Large! ***");
                    ViewData["feedback"] = "File Too Large";
                    return RedirectToAction("AddEbook");
                case 3:
                    Console.WriteLine("\n\n\n*** File Name Too Long! ***");
                    ViewData["feedback"] = "File Name Too Long";
                    return RedirectToAction("AddEbook");
                case 4:
                    Console.WriteLine("\n\n\n*** Error Saving File! ***");
                    ViewData["feedback"] = "Error Saving File";
                    return RedirectToAction("AddEbook");
                case 5:
                    ViewData["feedback"] = "Success";
                    ebook.imgFile = imageManager.fileName;
                    int epubResult = epubManager.uploadFile(epub);
                    if (epubResult == 5) {
                        ebook.epub = epubManager.fileName;
                        int mobiResult = mobiManager.uploadFile(mobi);
                        if (mobiResult == 5) {
                            ebook.mobi = mobiManager.fileName;
                            bookManager.Add(ebook);
                            bookManager.SaveChanges();
                            return RedirectToAction("Ebooks");
                        } else {
                            Console.WriteLine("\n\n\n***Error Adding MOBI! " + mobiResult + " ***");
                            return RedirectToAction("AddEbook");
                        }
                    } else {
                        Console.WriteLine("\n\n\n***Error Adding ePub! " + epubResult + " ***");
                        return RedirectToAction("AddEbook");
                    }

                default:
                    Console.WriteLine("\n\n\n*** No File Selected! ***");
                    ViewData["feedback"] = "No File Selected";
                    return RedirectToAction("AddEbook");
            } 
            

        }
        
        [Route("/DeleteEbook/{id}")]
        public IActionResult DeleteEbook(int id) {
            Ebook ebook = new Ebook();
            ebook = bookManager.getEbook(id);
            return View(ebook);
        }
        [HttpPost]
        public IActionResult DeleteEbookSubmit(Ebook ebook) {
            ebook = bookManager.getEbook(ebook.id);
            ImageManager imageManager = new ImageManager(environment, "images/covers/ebooks");
            FileManager epubManager = new FileManager(environment, "ebooks/epub");
            FileManager mobiManager = new FileManager(environment, "ebooks/mobi");
            bool result = imageManager.deleteImage(ebook.imgFile);
            if (result) {
                bool epubResult = epubManager.deleteFile(ebook.epub);
                if (epubResult) {
                    bool mobiResult = mobiManager.deleteFile(ebook.mobi);
                    if (mobiResult) {
                        bookManager.Remove(ebook);
                        bookManager.SaveChanges();
                    } else {
                        Console.WriteLine("\n\n\n***There has been an error deleting the mobi file!***\n\n\n");
                    }
                } else {
                    Console.WriteLine("\n\n\n***There has been an error deleting the epub file!***\n\n\n");
                }
            } else {
                Console.WriteLine("\n\n\n***There has been an error deleting the image file!***\n\n\n");
            }
            return RedirectToAction("Ebooks");
        }
        public IActionResult Logout() {
            //logs user out and reqirects to login page
            HttpContext.Session.SetString("auth", "false");
            return RedirectToAction("Index", "Login");
        }
    }
}