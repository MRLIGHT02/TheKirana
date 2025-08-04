using Microsoft.AspNetCore.Identity;
using Service.DTO;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Services
{
    public class RegisterUser : IRegister
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterUser(UserManager<ApplicationUser> applicationUser)
        {
            _userManager = applicationUser;
        }


       public async Task<ApplicationUser?> Register(UserDto userDto)
        {
            var user = new ApplicationUser
            {
                UserName = userDto.UserName,
                Email = userDto.Email
            };

            // Properly hashes password + saves to DB
             var result= await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                return user;
            }
            return null;

        }
    }
}
