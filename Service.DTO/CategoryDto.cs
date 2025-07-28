using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Service.DTO
{
    /// <summary>
    /// Represents a data transfer object for a category, including its name, description, image URL, and associated
    /// products.
    /// </summary>
    public class CategoryDto
    {
        public string? CategoryOfName { get; set; }
        public string? CategoryDescription { get; set; }
        public string? ImageUrl { get; set; } = string.Empty;

        public List<Product>? Products { get; set; } = new List<Product>();
    }
}
