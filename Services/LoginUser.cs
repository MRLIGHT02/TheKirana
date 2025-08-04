using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
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
    public class LoginUser : ControllerBase, ILogin
    {
        private readonly ApplicationUser _user;
        public LoginUser(ApplicationUser userManager)
        {
            _user= userManager;
        }
       

     public Task<ApplicationUser?> ILogin.LoginUser(UserDto userDto)
        {
            if (_user.UserName != userDto.UserName)
            {
                BadRequest("Wrong UserName");
            }
            var LoginPasswordVerificationResult = new PasswordHasher<ApplicationUser>().VerifyHashedPassword(_user, _user.PasswordHash, userDto.Password);
           
            if (LoginPasswordVerificationResult == PasswordVerificationResult.Failed)
            {
                BadRequest("Wrong Password");
            }

            return _user;
        }
    }
}
