using ServiceContract;
using System;
using System.Collections.Generic;
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

        public Task<AppDbContext?> AddToCartAsync(string userId, int productId, int quantity)
        {
            var existingItem = await _context.CartItem.FindAsync(productId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                _context.CartItems.Update(existingItem);
            }
            else
            {
                var cartItem = new CartItem
                {
                    UserId = userId,
                    ProductId = productId,
                    Quantity = quantity
                };

                await _context.CartItems.AddAsync(cartItem);
            }

            await _context.SaveChangesAsync();
        }

        public Task ClearCartAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItem>> GetCartItemsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromCartAsync(string userId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
