namespace TheKirana.Models
{
    public class Product
    {
        public int ProductId { get; set; }
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

        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
