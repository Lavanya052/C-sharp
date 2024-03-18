using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    //College or office name,address,mobile,id,email

    public class OfficialDetail(String? Name, AddressProf? Address, int stuId, String? Email,String? mobileNo)
        {
            public string? Name { get; set; } = Name;
            public int Id { get; set; } = stuId;
            public string? Email { get; set; } = Email;
            public AddressProf? Address { get; set; } = Address;
            public String? MobileNo { get; set; } = mobileNo;

    }
   

}
