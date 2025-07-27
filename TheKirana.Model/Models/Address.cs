using System.Text.RegularExpressions;

namespace TheKirana.Model.Models
{

    public class Address
    {

        #region Properties

        private string? _phoneNumber;
        public int AddressId { get; set; }
        public string? FirstName { get; set; }
        = null;
        public string? LastName { get; set; }
        = null;
        public string? AddressLine1 { get; set; }
        = null;
        public string? AddressLine2 { get; set; } = null;

        public string PhoneNumber
        {

            get => _phoneNumber;
            set
            {
                if (IsValidPhoneNumber(value))
                {

                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone number format. Please enter a valid Indian phone number.");
                }

            }
        }

        public string? City { get; set; } = null;
        public string? State { get; set; } = null;
        public string? Country { get; set; } = null;

        public int? PinCode { get; set; }


        public bool IsDefault { get; set; } = false;
        #endregion

        #region Method
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex("^(?:(?:\\+|0{0,2})91(\\s*[\\-]\\s*)?|[0]?)?[789]\\d{9}$");

            return regex.IsMatch(phoneNumber);

        }
        #endregion

    }
}
