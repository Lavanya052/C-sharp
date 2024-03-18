using System;
using System.Collections.Generic;

namespace Details
{
    public class StuReg
    {
        int age, stuId;
        string? name, sex, doorNo, streetName, city, pincode,area,district,state,pincodePro,collName,email,mobileNo;
        DateTime dob;
        AddressPers? address;
        AddressProf? info;
        OfficialDetail? offidetail;
        static List<Detail> students = new List<Detail>();
        public void StuDetailAdd()
        {
            Console.WriteLine("Enter the name: ");    name = Console.ReadLine();

            Console.WriteLine("Enter the age: ");      age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the sex: ");      sex = Console.ReadLine();

            Console.WriteLine("Enter the DOB (MM/DD/YYYY)");     dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter address details:");
            Console.WriteLine("----------------------");

            Console.Write("Door No: ");     doorNo = Console.ReadLine();

            Console.Write("Street Name: ");        streetName = Console.ReadLine();

            Console.Write("City: ");        city = Console.ReadLine();

            Console.Write("Pincode: ");     pincode = Console.ReadLine();
            

            Console.Write("College Name: ");        collName= Console.ReadLine();

            Console.Write("StudentID: "); stuId = Convert.ToInt32(Console.ReadLine());

           Console.Write("MobileNo : "); mobileNo = Console.ReadLine();

            Console.Write("EmailID: "); email = Console.ReadLine();

            Console.WriteLine("Enter College address details:");
            Console.WriteLine("------------------------------");

            Console.Write("Area: ");        area = Console.ReadLine();

            Console.Write("District: ");        district = Console.ReadLine();

            Console.Write("State: ");           state = Console.ReadLine();

            Console.Write("Pincode: ");         pincodePro = Console.ReadLine();

            

            info = new AddressProf(area,district,state,pincodePro);
            address = new AddressPers(doorNo, streetName, city, pincode);
            offidetail = new OfficialDetail(collName, info, stuId, email,mobileNo);
            Detail newStudent = new Detail(name, age, sex, dob, address,offidetail);
            students.Add(newStudent);

        }
        public void StuDetailView()
        {
            bool flag = false;
            Console.WriteLine("Enter name");     name = Console.ReadLine();
            Console.WriteLine("Enter the DOB of the student (MM/DD/YYYY)");     dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("College Name: ");    collName = Console.ReadLine();
            foreach (Detail student in students)
            {
                if (student.Name == name && student.DOB == dob && student.OfficialDetail.Name == collName)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Age: " + student.Age);
                    Console.WriteLine("Sex: " + student.Sex);
                    Console.WriteLine("DOB: " + student.DOB.Date);
                    Console.WriteLine("Address: " + student.Address.DoorNo,student.Address.StreetName,student.Address.City,student.Address.Pincode);
                    Console.WriteLine("College Name: " + collName);
                    Console.WriteLine("College Address: " + student.OfficialDetail.Address.Area, student.OfficialDetail.Address.District,
                        student.OfficialDetail.Address.State, student.OfficialDetail.Address.Pincode);
                    Console.WriteLine("Student ID: " + student.OfficialDetail.Id);
                    Console.WriteLine("Email: " + student.OfficialDetail.Email);
                    Console.WriteLine("\n");
                    flag = true;
                    break;
                }

            }
            if (!flag) { Console.WriteLine(name + "not fountd"); }

        }
    }
}

