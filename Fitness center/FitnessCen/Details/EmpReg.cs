using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class EmpReg
    {
        int age, empId;
        string? name, sex, doorNo, streetName, city, pincode, area, district, state, pincodePro, offiName, email, mobileNo;
        DateTime dob;
        AddressPers? address;
        AddressProf? info;
        OfficialDetail? offidetail;
        static List<Detail> Employes = new List<Detail>();
        public void EmpDetailAdd()
        {
            Console.WriteLine("Enter the name: "); name = Console.ReadLine();

            Console.WriteLine("Enter the age: "); age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the sex: "); sex = Console.ReadLine();

            Console.WriteLine("Enter the DOB(MM/DD/YYYY)"); dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter address details:");
            Console.WriteLine("----------------------");

            Console.Write("Door No: "); doorNo = Console.ReadLine();

            Console.Write("Street Name: "); streetName = Console.ReadLine();

            Console.Write("City: "); city = Console.ReadLine();

            Console.Write("Pincode: "); pincode = Console.ReadLine();


            Console.Write("College Name: "); offiName = Console.ReadLine();

            Console.Write("StudentID: "); empId = Convert.ToInt32(Console.ReadLine());

            Console.Write("MobileNo : "); mobileNo = Console.ReadLine();

            Console.Write("EmailID: "); email = Console.ReadLine();

            Console.WriteLine("Enter College address details:");
            Console.WriteLine("------------------------------");

            Console.Write("Area: "); area = Console.ReadLine();

            Console.Write("District: "); district = Console.ReadLine();

            Console.Write("State: "); state = Console.ReadLine();

            Console.Write("Pincode: "); pincodePro = Console.ReadLine();



            info = new AddressProf(area, district, state, pincodePro);
            address = new AddressPers(doorNo, streetName, city, pincode);
            offidetail = new OfficialDetail(offiName, info, empId, email,mobileNo);
            Detail newEmployee = new Detail(name, age, sex, dob, address, offidetail);
            Employes.Add(newEmployee);
        }
        public void EmpDetailView()
        {
            bool flag = false;
            Console.WriteLine("Enter name"); name = Console.ReadLine();
            Console.WriteLine("Enter the DOB of the student (MM/DD/YYYY)"); dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("College Name: "); offiName = Console.ReadLine();
            foreach (Detail employee in Employes)
            {
                if (employee.Name == name && employee.DOB == dob && employee.OfficialDetail.Name == offiName)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Name: " + employee.Name);
                    Console.WriteLine("Age: " + employee.Age);
                    Console.WriteLine("Sex: " + employee.Sex);
                    Console.WriteLine("DOB: " + employee.DOB.Date);
                    Console.WriteLine("Address: " + employee.Address.DoorNo, employee.Address.StreetName, employee.Address.City, employee.Address.Pincode);
                    Console.WriteLine("College Name: " + offiName);
                    Console.WriteLine("College Address: " + employee.OfficialDetail.Address.Area, employee.OfficialDetail.Address.District,
                        employee.OfficialDetail.Address.State,employee.OfficialDetail.Address.Pincode);
                    Console.WriteLine("Student ID: " + employee.OfficialDetail.Id);
                    Console.WriteLine("Email: " + employee.OfficialDetail.Email);
                    Console.WriteLine("\n");
                    flag = true;
                    break;
                }

            }
            if (!flag) { Console.WriteLine(name + "not fountd"); }

        }
    }
}
