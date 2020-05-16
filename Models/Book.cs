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

    }
}