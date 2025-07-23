using Microsoft.AspNetCore.Identity;

namespace TheKirana.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Address>? Addresses { get; set; }
    }
}
