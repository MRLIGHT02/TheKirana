using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace ServiceContract
{
    public interface IRegister
    {
        public Task<ApplicationUser?> Register(UserDto user);

        


    }
}
