using Microsoft.AspNetCore.Identity;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Models;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _users;

        public UserService(UserManager<ApplicationUser> users)
        {
            _users = users;
        }

        public async Task<ApplicationUser?> ChangeUserPassWord(ApplicationUser user, string newPassword)
        {
            var existingUser = _users.FindByIdAsync(user.UserId.ToString());

            if (existingUser == null)
            {
                return null;
            }

            var removeResult = await _users.RemovePasswordAsync(existingUser.Result!);
            if (!removeResult.Succeeded)
            {
                return null;
            }
            var result = await _users.AddPasswordAsync(existingUser.Result.PasswordHash, newPassword);


        }

        public Task<ApplicationUser?> GetUserByIdAsync(string userId)
        {
            return _users.FindByIdAsync(userId);
        }

        public Task UpdateUserProfileAsync(ApplicationUser user)
        {
            var existingUser = _users.FindByIdAsync(user.UserId.ToString());
            if (existingUser == null)
            {
                return Task.FromResult<ApplicationUser?>(null);
            }
            existingUser.Result!.FirstName = user.FirstName;
            existingUser.Result.LastName = user.LastName;
            existingUser.Result.Email = user.Email;
            existingUser.Result.UserName = user.UserName;
            existingUser.Result.Addresses = user.Addresses;
            existingUser.Result.ProfilePictureUrl = user.ProfilePictureUrl;
            existingUser.Result.Gender = user.Gender;
            existingUser.Result.DateOfBirth = user.DateOfBirth;
            // Ensure password is hashed before saving


            // Update other properties as needed
            return _users.UpdateAsync(existingUser.Result);
        }
    }
}
