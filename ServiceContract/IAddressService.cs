using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Models;

namespace ServiceContract
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetUserAddressesAsync(string userId);
        Task AddAddressAsync(string userId, Address address);
        Task DeleteAddressAsync(int addressId);
    }
}
