using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using ServiceContract;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Model.Models;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _users;

        public UserService(UserManager<ApplicationUser> users)
        {
            _users = users;
        }

        public async Task<ApplicationUser?> ChangeUserPassWord(Guid userid, string currentPassword, string newPassword)
        {
            var user = await _users.FindByIdAsync(userid.ToString());

            if (user == null)
            {
                return null;
            }


            var result = await _users.ChangePasswordAsync(user, currentPassword, newPassword);
            return result;

        }





        public async Task<ApplicationUser?> GetUserByIdAsync(Guid userId)
        {
            return await _users.Users.FirstOrDefaultAsync(u => u.UserId == userId);
        }




        public Task UpdateUserProfileAsync(Guid id, UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
