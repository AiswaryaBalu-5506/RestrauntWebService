using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnRestaurant.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        [Required]
        public Order Order { get; set; }
        public decimal Amount { get; set; }
    }
}
