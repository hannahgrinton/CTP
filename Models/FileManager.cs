using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace CTP.Models
{
    public class FileManager
    {
        // File info
        private string targetFolder;
        private string fullPath;
        public string fileDelete;
        // class constants for different errors while uploading
        public const int ERROR_NO_FILE = 0;
        public const int ERROR_TYPE = 1;
        public const int ERROR_SIZE = 2;
        public const int ERROR_NAME_LENGTH = 3;
        public const int ERROR_SAVE = 4;
        public const int SUCCESS = 5;
        //File upload filesize limit
        private const int UPLOADLIMIT = 8388608;//4194304;
        //filename string passed in
        public string fileName { get; set; } = "";
        IWebHostEnvironment environment; 
        private String[] targetExtensions = new String[]{".epub", ".mobi"};

        public FileManager(IWebHostEnvironment env, string myTargetFolder) {
            //file info
            environment = env;
            targetFolder = myTargetFolder;
            fullPath = env.WebRootPath + "/" + targetFolder + "/";
            if (!Directory.Exists(fullPath)) {
                Directory.CreateDirectory(fullPath);
            }
        }
        // ------------------------------------------------- public methods
        public int uploadFile(IFormFile file) {
            //ERROR CHECK : if no file is found
            if (file != null) {
                //check to see what type of file has been uploaded
                string contentType = file.ContentType;
                Console.WriteLine("\n\n\ncontent type: " + file.ContentType);
                if((contentType == "application/epub+zip") || (contentType == "application/octet-stream") || (contentType == "application/x-mobipocket-ebook")) {
                    //check the size 
                    long size= file.Length;
                    Console.WriteLine("\n\n\nfile size: " + size);
                    if (size < UPLOADLIMIT) {
                        //get the filename of uploaded file 
                        fileName = Path.GetFileName(file.FileName);
                        //ERROR CHECK length of file name
                        if (fileName.Length <= 200) {
                            //ready to save the file
                            if (System.IO.File.Exists(fullPath + fileName)) {
                                //if the file already exists, add the date to the name to protect it
                                DateTime dateTime = DateTime.Now;
                                fileName = Path.GetFileNameWithoutExtension(file.FileName) + dateTime.ToString("yyyy-MM-dd_HH-mm-ss") + Path.GetExtension(file.FileName);
                            }
                            using (FileStream stream = new FileStream(fullPath + fileName, FileMode.Create)) {
                                try {
                                    file.CopyTo(stream);
                                    return FileManager.SUCCESS;
                                } catch {
                                    return FileManager.ERROR_SAVE;
                                }
                            }
                        } else {
                            return FileManager.ERROR_NAME_LENGTH;
                        }
                    } else {
                        return FileManager.ERROR_SIZE;
                    }
                } else {
                    return FileManager.ERROR_TYPE;
                }
            } else {
                return FileManager.ERROR_NO_FILE;
            }
        }
        public bool deleteFile(String file) {
            //get the full path of the file to delete
            string filePath = environment.WebRootPath + "/" + targetFolder + "/" + file;
            if (File.Exists(filePath)) {
                //if it exists, delete it, and pass a true bool back to other method, to continue
                File.Delete(filePath);
                return true;
            } else {
                //ABORT MISSION!!!! MAYDAY MAYDAY
                Console.WriteLine("*********** File Does Not Exist ************");
                return false;
            }
            
        }
    }
}