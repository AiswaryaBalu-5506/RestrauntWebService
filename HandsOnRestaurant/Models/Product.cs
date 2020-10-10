using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnRestaurant.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [MaxLength(30)]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int ProductCategoryID { get; set; }
        public ProductCategory productCategory { get; set; }

    }
}
