
using System.ComponentModel.DataAnnotations;
using TheKirana.Model.Models;
namespace Service.DTO
{
    /// <summary>
    /// Represents a data transfer object for user information, extending the <see cref="ApplicationUser"/> class.
    /// </summary>
    /// <remarks>This class is used to encapsulate user-related data for transfer between different layers of
    /// the application. It includes personal details such as first name, last name, gender, and date of birth, as well
    /// as contact information like email and username. The class also supports multiple addresses and a profile picture
    /// URL.</remarks>
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
