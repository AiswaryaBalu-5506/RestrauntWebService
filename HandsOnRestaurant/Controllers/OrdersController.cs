using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HandsOnRestaurant.Models;
using Microsoft.AspNetCore.Authorization;

namespace HandsOnRestaurant.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public IActionResult GetOrders()
        {
            var result = _context.Orders.Include(orders => orders.OrderItems).ThenInclude(a => a.Product).ThenInclude(b => b.productCategory).ToList();
            return Ok(result);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(_context.Orders.Include(orders => orders.OrderItems).ThenInclude(a => a.Product).ToList());
        }


        // POST: api/Orders
        [HttpPost]
        public IActionResult PostOrder(Order order)
        {
            decimal amount = 0;
            foreach (var orderItem in order.OrderItems)
            {
                var price = _context.Products.Find(orderItem.ProductID).Price;
                var quantity = orderItem.Quantity;
                amount += price * quantity;
            }
            order.Amount = amount;
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return Ok();
            }   
             catch (Exception ex)
             {
                return NotFound(ex);
             }
        }
    }
}

