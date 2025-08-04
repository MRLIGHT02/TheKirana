using Microsoft.EntityFrameworkCore;
using Service.DTO;
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
    public class AddressService 
    {
        private readonly AppDbContext _context;
        public AddressService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAddressAsync(string userId, AddressDto address)
        {

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                throw new Exception("User not found");

            
            await _context.SaveChangesAsync();
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
