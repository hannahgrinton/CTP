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
        [Display(Name="Code")]
        public string code {get; set;}
        //author of article
        [Required]
        [MaxLength(200)]
        [Display(Name="Author")]
        public string author {get; set;}
        //price of article
        [Required]
        [MaxLength(10)]
        [Display(Name="Price")]
        public string price {get; set;}
        //png file name
        [MaxLength(100)]
        [Display(Name="Image File")]
        public string imgFile {get; set;}
        //docx file name
        [MaxLength(100)]
        [Display(Name="DOCX File")]
        public string docx {get; set;}
        //epub file name
        [MaxLength(100)]
        [Display(Name="EPUB File")]
        public string epub {get; set;}
        //mobi file name
        [MaxLength(100)]
        [Display(Name="MOBI File")]
        public string mobi {get; set;}
    }
}