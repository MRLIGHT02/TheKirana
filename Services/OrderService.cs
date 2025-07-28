using ServiceContract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Data.Data;
using TheKirana.Model.Models;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;

        public OrderService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Order?> GetOrderByIdAsync(int orderId)
        {
            return await _context.Order.FindAsync(orderId);

        }

        public async Task<IEnumerable<Order>> GetOrdersByUserAsync(string userId)
        {
            return await _context.Order.Where(od => od.UserId == userId).ToListAsync();


        }

        public async Task<Order> PlaceOrderAsync(string userId)
        {
            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.UtcNow,
                Status = "Pending",
                // Add other default values if needed
            };
            _context.Order.Add(order);
            await _context.SaveChangesAsync();

            return order;
        }
    }
}
