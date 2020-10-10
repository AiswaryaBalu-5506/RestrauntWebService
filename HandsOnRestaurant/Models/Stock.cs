using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnRestaurant.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        [Required]
        public Product Product { get; set; }
        public int ProductID { get; set; }
        [Required]
        public int ProductQuantity { get; set; }
    }
}
