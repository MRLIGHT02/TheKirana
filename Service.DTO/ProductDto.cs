using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    /// <summary>
    /// Represents a data transfer object for a product, containing details such as category, pricing, and stock
    /// information.
    /// </summary>
    /// <remarks>This class is used to encapsulate product information for transfer between different layers
    /// of an application. It includes properties for categorization, pricing, and other relevant product
    /// details.</remarks>
    public class ProductDto
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
