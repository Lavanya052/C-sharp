using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    public class AdminReg
    {
        int age, PId;
        string? name, sex, doorNo, streetName, city, pincode, area, district, state, pincodePro, PName, email, mobileNo;
        DateTime dob;
        AddressPers? address;
        AddressProf? info;
        OfficialDetail? offidetail;
        static List<Detail> Admin = new List<Detail>();
        public void AdminDetailAdd()
        {
            Console.WriteLine("Enter the name: "); name = Console.ReadLine();

            Console.WriteLine("Enter the age: "); age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the sex: "); sex = Console.ReadLine();

            Console.WriteLine("Enter the DOB (MM/DD/YYYY)"); dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter address details:");
            Console.WriteLine("----------------------");

            Console.Write("Door No: "); doorNo = Console.ReadLine();

            Console.Write("Street Name: "); streetName = Console.ReadLine();

            Console.Write("City: "); city = Console.ReadLine();

            Console.Write("Pincode: "); pincode = Console.ReadLine();

            Console.WriteLine("Proffion college/office");
            Console.Write("Name: "); PName = Console.ReadLine();

            Console.Write("ID: "); PId = Convert.ToInt32(Console.ReadLine());

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
            offidetail = new OfficialDetail(PName, info, PId, email, mobileNo);
            Detail newPerson = new Detail(name, age, sex, dob, address, offidetail);
            Admin.Add(newPerson);

        }
        public void AdminDetailView()
        {
            bool flag = false;
            Console.WriteLine("Enter name"); name = Console.ReadLine();
            Console.WriteLine("Enter the DOB of the student (MM/DD/YYYY)"); dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("College Name: "); PName = Console.ReadLine();
            foreach (Detail admin in Admin)
            {
                if (admin.Name == name && admin.DOB == dob && admin.OfficialDetail.Name == PName)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Name: " + admin.Name);
                    Console.WriteLine("Age: " + admin.Age);
                    Console.WriteLine("Sex: " + admin.Sex);
                    Console.WriteLine("DOB: " + admin.DOB.Date);
                    Console.WriteLine("Address: " + admin.Address.DoorNo, admin.Address.StreetName, admin.Address.City, admin.Address.Pincode);
                    Console.WriteLine("Proffion college/office");
                    Console.WriteLine("Name: " + admin.OfficialDetail.Name);
                    Console.WriteLine("College Address: " + admin.OfficialDetail.Address.Area, admin.OfficialDetail.Address.District,
                        admin.OfficialDetail.Address.State, admin.OfficialDetail.Address.Pincode);
                    Console.WriteLine("Student ID: " + admin.OfficialDetail.Id);
                    Console.WriteLine("Email: " + admin.OfficialDetail.Email);
                    Console.WriteLine("\n");
                    flag = true;
                    break;
                }

            }
            if (!flag) { Console.WriteLine(name + " not fountd"); }

        }

        public void AdminEditDetail()
        {
            bool flag = false;
            Console.WriteLine("Enter name"); name = Console.ReadLine();
            Console.WriteLine("Enter the DOB of the student (MM/DD/YYYY)"); dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("College Name: "); PName = Console.ReadLine();
            foreach (Detail admin in Admin)
            {
                if (admin.Name == name && admin.DOB == dob && admin.OfficialDetail.Name == PName)
                {
                    Console.WriteLine("Enter the name: "); name = Console.ReadLine();

                    Console.WriteLine("Enter the age: "); age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the sex: "); sex = Console.ReadLine();

                    Console.WriteLine("Enter the DOB (MM/DD/YYYY)"); dob = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Enter address details:");
                    Console.WriteLine("----------------------");

                    Console.Write("Door No: "); doorNo = Console.ReadLine();

                    Console.Write("Street Name: "); streetName = Console.ReadLine();

                    Console.Write("City: "); city = Console.ReadLine();

                    Console.Write("Pincode: "); pincode = Console.ReadLine();

                    Console.WriteLine("Proffion college/office");
                    Console.Write("Name: "); PName = Console.ReadLine();

                    Console.Write("ID: "); PId = Convert.ToInt32(Console.ReadLine());

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
                    offidetail = new OfficialDetail(PName, info, PId, email, mobileNo);
                    Detail newPerson = new Detail(name, age, sex, dob, address, offidetail);
                    Admin.Add(newPerson);
                    Console.WriteLine("Student details updated successfully.");
                    flag = true;
                    break;
                }

            }
            if (!flag) { Console.WriteLine(name + " not fountd"); }

        }
        public void AdminDeleteDetail()
        {
            bool flag = false;
            Console.WriteLine("Enter name"); name = Console.ReadLine();
            Console.WriteLine("Enter the DOB of the student (MM/DD/YYYY)"); dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("College Name: "); PName = Console.ReadLine();
            Detail studentToDelete = Admin.Find(s => s.Name == name && s.DOB == dob && s.OfficialDetail.Name == PName);
            if (studentToDelete != null)
            {
                Admin.Remove(studentToDelete);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine(name + " not fountd");
            }
        }
    }
    }
