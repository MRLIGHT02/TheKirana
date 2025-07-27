using System.ComponentModel.DataAnnotations;

namespace TheKirana.Model.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = null!;  // e.g., UPI, Card, COD

        [Required]
        public string PaymentStatus { get; set; } = "Pending";  // Pending, Completed, Failed, Refunded

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public string? TransactionId { get; set; }
    }
}
