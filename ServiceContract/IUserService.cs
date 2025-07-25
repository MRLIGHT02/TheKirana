using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Models;

namespace ServiceContract
{
    public interface IUserService
    {
        Task<ApplicationUser?> GetUserByIdAsync(string userId);
        Task UpdateUserProfileAsync(ApplicationUser user);

        Task<ApplicationUser?> ChangeUserPassWord(ApplicationUser user);

    }
}
