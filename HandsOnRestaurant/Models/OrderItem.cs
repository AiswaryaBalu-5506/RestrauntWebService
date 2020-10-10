using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnRestaurant.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
    }

}
