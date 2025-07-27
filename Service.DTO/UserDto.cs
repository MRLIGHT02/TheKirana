
using System.ComponentModel.DataAnnotations;
using TheKirana.Model.Models;
namespace Service.DTO
{
    public class UserDto : ApplicationUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }


        public ICollection<Address>? Addresses { get; set; }

        // Additional Properties

        public string? ProfilePictureUrl { get; set; } = string.Empty;

        [Required]
        public string? UserName { get; set; } = string.Empty;
        [Required]
        public string? Email { get; set; } = string.Empty;
    }
}
