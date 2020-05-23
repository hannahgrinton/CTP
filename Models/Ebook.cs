using System;
using System.ComponentModel.DataAnnotations;
namespace CTP.Models
{
    public class Ebook
    {   
        [Key]
        public int id {get; set;}
        //title of article
        [Required]
        [MaxLength(200)]
        [Display(Name="Title")]
        public string title {get; set;}
        //code of article
        [Required]
        [MaxLength(10)]
        [Display(Name="Version")]
        public string version {get; set;}
        //author of article
        [Required]
        [MaxLength(200)]
        [Display(Name="Author")]
        public string author {get; set;}
        //png file name
        [MaxLength(100)]
        [Display(Name="Image File")]
        public string imgFile {get; set;}
        //docx file name
        [MaxLength(250)]
        [Display(Name="Amazon Link")]
        public string amazon {get; set;}
        //epub file name
        [MaxLength(350)]
        [Display(Name="EPUB File")]
        public string epub {get; set;}
        //mobi file name
        [MaxLength(200)]
        [Display(Name="MOBI File")]
        public string mobi {get; set;}
    }
}