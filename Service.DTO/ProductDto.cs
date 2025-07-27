using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    internal class ProductDto
    {
        public string? GenderType { get; set; }
        public string? CategoryName { get; set; }
        public string? SubCategory { get; set; }
        public string? ProductType { get; set; }
        public string? Colour { get; set; }

        public string? Usage { get; set; }
        public string? ProductTitle { get; set; }

        public string? ImageUrl { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }              // Price in ₹
        public int Stock { get; set; }                  // Inventory
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public decimal? DiscountPrice { get; set; }
        public bool IsFeatured { get; set; } = false;
        public Category? Category { get; set; }
    }
}
