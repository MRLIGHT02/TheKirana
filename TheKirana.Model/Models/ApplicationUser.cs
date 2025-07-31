
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheKirana.Model.Models
{
    public class ApplicationUser : IdentityUser
    {

        //
        [Key]
        public Guid UserId { get; set; } = Guid.NewGuid();
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }


        public ICollection<Address>? Addresses { get; set; }

        // Additional Properties

        public string? ProfilePictureUrl { get; set; } = string.Empty;

        [Required]
        public override string? UserName { get; set; } = string.Empty;
        [Required]
        public override string? Email { get; set; } = string.Empty;
        [Required]
        [PasswordPropertyText]
        public string PasswordHash { get; set; } = string.Empty;

    }
}
