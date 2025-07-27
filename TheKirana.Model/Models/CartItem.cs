using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheKirana.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public Product? Product { get; set; }

        public ApplicationUser? User { get; set; }

        public int Quantity { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.Now;

    }
}
