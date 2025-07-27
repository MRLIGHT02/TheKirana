using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
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
