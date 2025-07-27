using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    internal class OrderDto
    {
        public Address? ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = "Pending"; // Other options: Processing, Shipped, Delivered, Cancelled

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
