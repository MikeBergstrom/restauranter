using System;
using System.ComponentModel.DataAnnotations;
 
namespace restaurant.Models
{
    public class Review : BaseEntity
    {
        public int ReviewId {get; set;}

        [Required]
        [Display(Name="Your Name")]
        public string Author {get; set;}
        [Required]
        [Display(Name="Restaurant Name")]
        public string RestName {get; set;}
        [Required]
        [Display(Name="Review")]
        [MinLength(10)]
        public string Content {get; set;}
        [Required]
        [Range(0,5)]
        [Display(Name="Stars")]
        public int Rating {get; set;}
        [Required]
        [Display(Name="Visit Date")]
        public DateTime Date {get; set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get; set;}

    }
}