using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Data.Data;
using TheKirana.Model.Models;
namespace ServiceContract
{
    public interface ICartService
    {
        Task AddToCartAsync(string userId, int productId, int quantity);
        Task<IEnumerable<CartItem>> GetCartItemsAsync(string userId);
        Task RemoveFromCartAsync(string userId, int productId);
        Task ClearCartAsync(string userId);
    }
}
