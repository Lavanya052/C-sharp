using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class AddressProf(string? area, string? District, string? State, string? pincode)
    {
        public string? Area { get; set; } = area;
        public string? District { get; set; } = District;
        public string? State { get; set; } = State;
        public string? Pincode { get; set; } = pincode;
    }
}
