using ServiceContract;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Data.Data;
using TheKirana.Model.Models;

namespace Services
{
    public class CartService : ICartService
    {
        private readonly AppDbContext _context;
        public CartService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddToCartAsync(string userId, int productId, int quantity)
        {
            // Check if product already in cart for the user
            var existingItem = await _context.CartItem
                .FirstOrDefaultAsync(c => c.ProductId == productId && c.User!.Id == userId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                _context.CartItem.Update(existingItem);
            }
            else
            {
                // Find user by userId
                var user = await _context.Users.FindAsync(userId);
                if (user == null)
                {
                    throw new Exception("User not found");
                }

                var cartItem = new CartItem
                {
                    User = user,
                    ProductId = productId,
                    Quantity = quantity
                };

                await _context.CartItem.AddAsync(cartItem);
            }

            await _context.SaveChangesAsync();
        }

        public async Task ClearCartAsync(string userId)
        {
            var items = await _context.CartItem
      .Where(c => c.User!.Id == userId)
      .ToListAsync();

            if (items.Any())
            {
                _context.CartItem.RemoveRange(items);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CartItem>> GetCartItemsAsync(string userId)
        {
            var items = await _context.CartItem
       .Where(c => c.User!.Id == userId)
       .ToListAsync();

            if (items.Any())
            {
                _context.CartItem.RemoveRange(items);
                await _context.SaveChangesAsync();
            }

            return items;
        }

        public async Task RemoveFromCartAsync(string userId, int productId)
        {
            var item = await _context.CartItem.FirstOrDefaultAsync(c => c.User!.Id == userId && c.ProductId == productId);

            if (item != null)
            {
                _context.CartItem.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
