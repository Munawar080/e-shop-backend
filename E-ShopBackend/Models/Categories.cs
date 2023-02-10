using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace E_ShopBackend.Models
{
    public class Categories
    {

        [Key]
        public int Id{ get; set; }

        [Required]
        [StringLength(255)]
        public string Name{ get; set; }
    }
}