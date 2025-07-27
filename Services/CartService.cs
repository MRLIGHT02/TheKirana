using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Services
{
    public class CartService : ICartService
    {
        public Task AddToCartAsync(string userId, int productId, int quantity)
        {
            throw new NotImplementedException();
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
