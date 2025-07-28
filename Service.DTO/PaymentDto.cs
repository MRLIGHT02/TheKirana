using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    /// <summary>
    /// Represents a data transfer object for processing payments.
    /// </summary>
    /// <remarks>This class is used to encapsulate payment details such as the order, amount, payment method,
    /// and status. It is typically used in scenarios where payment information needs to be transferred between
    /// different layers of an application or between services.</remarks>
    public class PaymentDto
    {
        public Order Order { get; set; } = null!;

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = null!;  // e.g., UPI, Card, COD

        [Required]
        public string PaymentStatus { get; set; } = "Pending";
    }
}
