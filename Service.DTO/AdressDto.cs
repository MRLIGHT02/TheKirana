using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class AdressDto
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
