using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    public class CartDto
    {
        public Product? Product { get; set; }

        public ApplicationUser? User { get; set; }

        public int Quantity { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
