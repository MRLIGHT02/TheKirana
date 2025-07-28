using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DTO
using TheKirana.Model.Models;

namespace ServiceContract
{
    public interface IUserService
    {
        Task<ApplicationUser?> GetUserByIdAsync(Guid userId);
        Task UpdateUserProfileAsync(Guid id, UserDto user);

        Task<ApplicationUser?> ChangeUserPassWord(ApplicationUser user);

    }
}
