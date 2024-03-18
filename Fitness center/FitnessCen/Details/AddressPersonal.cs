using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class AddressPers(string? doorNo, string? streetName, string? city, string? pincode)
    {
        public string? DoorNo { get; set; } = doorNo;
        public string? StreetName { get; set; } = streetName;
        public string? City { get; set; } = city;
        public string? Pincode { get; set; } = pincode;
    }
}
