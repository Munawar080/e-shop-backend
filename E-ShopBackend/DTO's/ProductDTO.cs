using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using E_ShopBackend.Models;

namespace E_ShopBackend.DTO_s
{
    public class ProductDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        //public int categoriesId { get; set; }

        public CategoriesDTO categories { get; set; }
    }
}