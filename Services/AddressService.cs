using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Services
{
    public class AddressService : IAddressService
    {
        public Task AddAddressAsync(string userId, Address address)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAddressAsync(int addressId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetUserAddressesAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
