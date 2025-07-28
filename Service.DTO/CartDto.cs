using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    /// <summary>
    /// Represents a data transfer object for a shopping cart item, containing information about the product, user,
    /// quantity, and the date it was added.
    /// </summary>
    public class CartDto
    {
        public Product? Product { get; set; }

        public ApplicationUser? User { get; set; }

        public int Quantity { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
