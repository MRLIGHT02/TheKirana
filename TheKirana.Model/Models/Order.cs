using System.ComponentModel.DataAnnotations;

namespace TheKirana.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        public int? ShippingAddressId { get; set; }
        public Address? ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = "Pending"; // Other options: Processing, Shipped, Delivered, Cancelled

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
