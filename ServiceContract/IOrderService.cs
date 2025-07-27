using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace ServiceContract
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrdersByUserAsync(string userId);
        Task<Order> PlaceOrderAsync(string userId);
        Task<Order?> GetOrderByIdAsync(int orderId);
    }
}
