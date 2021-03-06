using System;
using System.ComponentModel.DataAnnotations;
namespace CTP.Models
{
    public class Book
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
        [Display(Name="Front Cover Image File")]
        public string frontcover {get; set;}
        //png file name
        [MaxLength(100)]
        [Display(Name="Back Cover Image File")]
        public string backcover {get; set;}

    }
}