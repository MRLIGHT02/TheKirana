using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Models;

namespace Services
{
    internal class OrderService : IOrderService
    {
        public Task<Order?> GetOrderByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> PlaceOrderAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
