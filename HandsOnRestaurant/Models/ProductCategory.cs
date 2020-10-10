using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnRestaurant.Models
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        [MaxLength(30)]
        [Required]
        public string ProductCategoryName { get; set; }
    }
}
