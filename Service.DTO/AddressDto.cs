using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    /// <summary>
    /// Represents a data transfer object for an address, including personal and location details.
    /// </summary>
    /// <remarks>This class is used to encapsulate address information, which may include optional fields such
    /// as the second address line and postal code. It is designed to be used in scenarios where address information
    /// needs to be transferred between different layers or systems.</remarks>
    public class AddressDto
    {
        public string? FirstName { get; set; }
        = null;
        public string? LastName { get; set; }
        = null;
        public string? AddressLine1 { get; set; }
        = null;
        public string? AddressLine2 { get; set; } = null;


        public string? City { get; set; } = null;
        public string? State { get; set; } = null;
        public string? Country { get; set; } = null;

        public int? PinCode { get; set; }

    }
}
