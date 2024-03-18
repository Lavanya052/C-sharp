using System;
using System.Collections.Generic;
using Details;

class FormNew
{
    StuReg stu = new StuReg();
    EmpReg emp= new EmpReg();
    AdminReg admin = new AdminReg();
    public static void Main()
    {
        int choice;
        string? isAdmin,option, pos;
        FormNew formNew = new FormNew();
        Console.WriteLine("        XYZ FITNESS CENTER      ");   Console.WriteLine();
        Console.WriteLine(" Are you 1.student/2.working People/3.Admin");
        pos = Console.ReadLine();
        while (true)
        {
            
            Console.WriteLine("Choose one of the following options : ");
            Console.WriteLine("1. Insert details");
            Console.WriteLine("2. View details");
            if (pos == "3")
            {
                Console.WriteLine("3. Edit details");
                Console.WriteLine("4. Delete Details");
            }

            option = Console.ReadLine();
            choice= Convert.ToInt32(String.Concat(pos, option));
            
            switch (choice)
            {
                
                case 11: // 1student 1add
                    formNew.stu.StuDetailAdd();
                    break;
                case 12: //1student 2view
                    formNew.stu.StuDetailView();    
                    break;
                case 21:  //2 emp 1 add
                    formNew.emp.EmpDetailAdd();
                    break;
                case 22:  //2 emp 2 view
                    formNew.emp.EmpDetailView();
                    break;
                case 31:  //3 admin 1 add
                    formNew.admin.AdminDetailAdd();
                    break;
                case 32:  //3 admin 2 view
                    formNew.admin.AdminDetailView();
                    break;
                case 33:
                    formNew.admin.AdminEditDetail();
                    break;
                case 34:
                    formNew.admin.AdminDeleteDetail();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine("Do you want to continue? (y/n)");
            string? continueChoice = Console.ReadLine();
            if (continueChoice.ToLower() != "y")
            {
                Environment.Exit(0);
            }
        }
    }
}
