using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnRestaurant.Models
{
    public class Order
    {
        //[Required]
        //public string ApplicationUserID { get; set; }
        public int OrderID { get; set; }        
        [Required]
        public DateTime OrderDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public decimal Amount { get; set; }
    }
}
