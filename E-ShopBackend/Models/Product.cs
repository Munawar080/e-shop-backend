using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace E_ShopBackend.Models
{
    public class Product
    {
        [Key]
        public int Id{ get; set; }
        
        [Required]
        public Categories category { get; set; }

        [Required]
        public string ImageUrl { get; set; }
        
        [Required]
        public decimal Price{ get; set; }

        [Required]
        [StringLength(255)]
        public string Title{ get; set; }   
    }
}