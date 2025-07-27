
using Microsoft.EntityFrameworkCore;
using ServiceContract;
using TheKirana.Data.Data;
using TheKirana.Model.Models;

namespace Services
{

    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Product> AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public Task DeleteAsync(int id)
        {
            _context.Products.Remove(new Product { ProductId = id });
            return _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            if (_context == null || _context.Products == null)
            {
                return Enumerable.Empty<Product>();
            }

            var products = await _context.Products.ToListAsync();
            return products;
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            return _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
