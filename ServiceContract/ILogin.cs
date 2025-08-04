using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace ServiceContract
{
    public interface ILogin
    {
        public Task<ApplicationUser?> LoginUser(UserDto userDto);
    }
}
