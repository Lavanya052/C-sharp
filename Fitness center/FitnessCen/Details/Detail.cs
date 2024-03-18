using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
        public class Detail(String? name, int Age, String? sex, DateTime DOB, AddressPers? address,OfficialDetail? detail)
        {
            public string? Name { get; set; } = name;
            public int Age { get; set; } = Age;
            public string? Sex { get; set; } = sex;
            public AddressPers? Address { get; set; } = address;
            public DateTime DOB { get; set; } = DOB;

            public OfficialDetail? OfficialDetail { get; set;} = detail;
           


        }

}
