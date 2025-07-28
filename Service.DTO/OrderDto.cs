using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    /// <summary>
    /// Represents a data transfer object for an order, including details such as shipping address, order date, total
    /// amount, status, and items.
    /// </summary>
    /// <remarks>This class is used to encapsulate order information for transfer between different layers of
    /// an application. The <see cref="Status"/> property can have values such as "Pending", "Processing", "Shipped",
    /// "Delivered", or "Cancelled".</remarks>
    public class OrderDto
    {
        public Address? ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = "Pending"; // Other options: Processing, Shipped, Delivered, Cancelled

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
