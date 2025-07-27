namespace TheKirana.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string? CategoryOfName { get; set; }
        public string? CategoryDescription { get; set; }
        public string? ImageUrl { get; set; } = string.Empty;

        public List<Product>? Products { get; set; } = new List<Product>();

    }
}
