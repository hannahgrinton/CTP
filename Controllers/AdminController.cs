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

        //---------------------------------------------------------- ebooks
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
        
        [Route("/EditEbook/{id}")]
        public IActionResult EditEbook(int id) {
            Ebook ebook = new Ebook();
            ebook = bookManager.getEbook(id);
            return View(ebook);
        }
        
        [HttpPost]
        public IActionResult EditEbookSubmit(Ebook ebook, IFormFile newImgFile, IFormFile newEpub, IFormFile newMobi) {
            if (!ModelState.IsValid) return RedirectToAction("EditEbook", ebook.id);
            ImageManager imageManager = new ImageManager(environment, "images/covers/ebooks");
            FileManager epubManager = new FileManager(environment, "ebooks/epub");
            FileManager mobiManager = new FileManager(environment, "ebooks/mobi");
            if((newImgFile != null) && (newImgFile.FileName != "") && (ebook.imgFile != newImgFile.FileName)) {
                Console.WriteLine("\n\n\n***Image was not null so we're changing it.");
                bool delete = imageManager.deleteImage(ebook.imgFile);
                if (delete) {
                    int result = imageManager.uploadImage(newImgFile);
                    if (result == 5) {
                        ViewData["feedback"] = "Success";
                        Console.WriteLine("\n\n\n***Successfully uploaded image to server!***");
                        ebook.imgFile = imageManager.fileName;
                    } else {
                        Console.WriteLine("\n\n\n***Error!***");
                        return RedirectToAction("EditEbook", ebook.id);
                    }
                } else {
                    Console.WriteLine("\n\n\n***There has been an error deleting old image file!***");
                    return RedirectToAction("EditEbook", ebook.id);
                }
            } else {
                Console.WriteLine("\n\n\n***Image was null so we're moving on.");
                
            }
            if((newEpub != null) && (newEpub.FileName != "") && (ebook.epub != newEpub.FileName)) {
                bool epubBool = epubManager.deleteFile(ebook.epub);
                if (epubBool) {
                    int epubResult = epubManager.uploadFile(newEpub);
                    ebook.epub = epubManager.fileName;
                }
            } else {
                Console.WriteLine("\n\n\n***ePub was null so we're moving on.");
            }
            if((newMobi != null) && (newMobi.FileName != "") && (ebook.mobi != newMobi.FileName)) {
                bool mobiBool = mobiManager.deleteFile(ebook.mobi);
                int mobiResult = mobiManager.uploadFile(newMobi);
                ebook.mobi = mobiManager.fileName;
            } else {
                Console.WriteLine("\n\n\n***Mobi was null so we're moving on.");
            }
            bookManager.Update(ebook);
            bookManager.SaveChanges();
            return RedirectToAction("Ebooks");
        }
        
        //---------------------------------------------------------- ministry
        public IActionResult AddMinistry() {
            ViewBag.Current = "";
            Ministry ministry = new Ministry();
            return View(ministry);
        }

        [HttpPost]
        public IActionResult AddMinistrySubmit(Ministry ministry, IFormFile frontcover, IFormFile backcover) {
            if (!ModelState.IsValid) return RedirectToAction("AddMinistry");
            ImageManager imageManager = new ImageManager(environment, "images/covers/ministry");
            int result = imageManager.uploadImage(frontcover);
            switch (result) {
                case 1:
                    Console.WriteLine("\n\n\n*** Wrong File Type! ***");
                    ViewData["feedback"] = "Wrong File Type";
                    return RedirectToAction("AddMinistry");
                case 2:
                    Console.WriteLine("\n\n\n*** File Too Large! ***");
                    ViewData["feedback"] = "File Too Large";
                    return RedirectToAction("AddMinistry");
                case 3:
                    Console.WriteLine("\n\n\n*** File Name Too Long! ***");
                    ViewData["feedback"] = "File Name Too Long";
                    return RedirectToAction("AddMinistry");
                case 4:
                    Console.WriteLine("\n\n\n*** Error Saving File! ***");
                    ViewData["feedback"] = "Error Saving File";
                    return RedirectToAction("AddMinistry");
                case 5:
                    ViewData["feedback"] = "Success";
                    ministry.frontcover = imageManager.fileName;
                    int result2 = imageManager.uploadImage(backcover);
                    if (result2 == 5) {
                        ministry.backcover = imageManager.fileName;
                        bookManager.Add(ministry);
                        bookManager.SaveChanges();
                        return RedirectToAction("Ministry");
                    } else {
                        Console.WriteLine("\n\n\n***There has been an error adding the back cover!***");
                        return RedirectToAction("AddMinistry");
                    }

                default:
                    Console.WriteLine("\n\n\n*** No File Selected! ***");
                    ViewData["feedback"] = "No File Selected";
                    return RedirectToAction("AddMinistry");
            } 

        }
        
        [Route("/DeleteMinistry/{id}")]
        public IActionResult DeleteMinistry(int id) {
            Ministry ministry = new Ministry();
            ministry = bookManager.getMinistry(id);
            return View(ministry);
        }

        [HttpPost]
        public IActionResult DeleteMinistrySubmit(Ministry ministry) {
            ministry = bookManager.getMinistry(ministry.id);
            ImageManager imageManager = new ImageManager(environment, "images/covers/ministry");
            bool result = imageManager.deleteImage(ministry.frontcover);
            if (result) {
                bool result2 = imageManager.deleteImage(ministry.backcover);
                if (result2) {
                    bookManager.Remove(ministry);
                    bookManager.SaveChanges();
                } else {
                    Console.WriteLine("\n\n\n***There has been an error deleting the back cover file! Error Code: " + result2 + "***\n\n\n");
                }
            } else {
                Console.WriteLine("\n\n\n***There has been an error deleting the front cover file!***\n\n\n");
            }
            return RedirectToAction("Ministry");
        }
        
        [Route("/EditMinistry/{id}")]
        public IActionResult EditMinistry(int id) {
            Ministry ministry = new Ministry();
            ministry = bookManager.getMinistry(id);
            return View(ministry);
        }
        
        [HttpPost]
        public IActionResult EditMinistrySubmit(Ministry ministry, IFormFile newfrontcover, IFormFile newbackcover) {
            if (!ModelState.IsValid) return RedirectToAction("EditMinistry", ministry.id);
            ImageManager imageManager = new ImageManager(environment, "images/covers/ministry");
            if((newfrontcover != null) && (newfrontcover.FileName != "") && (ministry.frontcover != newfrontcover.FileName)) {
                Console.WriteLine("\n\n\n***Front Image was not null so we're changing it.");
                bool delete = imageManager.deleteImage(ministry.frontcover);
                if (delete) {
                    int result = imageManager.uploadImage(newfrontcover);
                    if (result == 5) {
                        ViewData["feedback"] = "Success";
                        Console.WriteLine("\n\n\n***Successfully uploaded image to server!***");
                        ministry.frontcover = imageManager.fileName;
                    } else {
                        Console.WriteLine("\n\n\n***Error!***");
                        return RedirectToAction("EditMinistry", ministry.id);
                    }
                } else {
                    Console.WriteLine("\n\n\n***There has been an error deleting old image file!***");
                    return RedirectToAction("EditMinistry", ministry.id);
                }
            } else {
                Console.WriteLine("\n\n\n***Front Cover Image was null so we're moving on.");
                Console.WriteLine("\n\n\nCurrent Front Cover: " + ministry.frontcover);
            }
            if((newbackcover != null) && (newbackcover.FileName != "") && (ministry.backcover != newbackcover.FileName)) {
                Console.WriteLine("\n\n\n***Back Image was not null so we're changing it.");
                bool bool2 = imageManager.deleteImage(ministry.backcover);
                if (bool2) {
                    int result2 = imageManager.uploadImage(newbackcover);
                    ministry.backcover = imageManager.fileName;
                }
            } else {
                Console.WriteLine("\n\n\n***Backcover was null so we're moving on.");
                Console.WriteLine("\n\n\nCurrent Back Cover: " + ministry.backcover);
            }
            
            bookManager.Update(ministry);
            bookManager.SaveChanges();
            return RedirectToAction("Ministry");
        }
        public IActionResult Logout() {
            //logs user out and reqirects to login page
            HttpContext.Session.SetString("auth", "false");
            return RedirectToAction("Index", "Login");
        }
    }
}