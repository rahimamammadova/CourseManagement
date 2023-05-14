using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp.Controllers
{
    internal class MenuController
    {
        public static void ShowMainMenu()
        {
            char status = 'y';
            GroupController groupcontroller= new GroupController();
            StudentController studentcontroller= new StudentController();
            do
            {
                int operation;
                Console.WriteLine("1.Create new group");
                Console.WriteLine("2.Show all Group list");
                Console.WriteLine("3.Edit Group");
                Console.WriteLine("4.Show student list in groups");
                Console.WriteLine("5.Show all student list");
                Console.WriteLine("6.Add new student");
                Console.WriteLine("7.Delete existing student");

                Console.Write("Please choose an operation: ");
                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        groupcontroller.CreateGroup();
                        break;
                    case 2:
                        groupcontroller.ShowGroupInfo();
                        break;
                    case 3:
                        groupcontroller.EditGroup();
                        break;
                    case 4:
                        groupcontroller.ShowAllStudentsInGroups();
                        break;
                    case 5: break;
                    case 6:
                        studentcontroller.AddNewStudent();
                        break;
                    case 7: break;
                    default:
                        Console.Write("Something went wrong");
                        break;
                }

                Console.Write("To procede press 'y': ");
                status = char.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (status == 'y');

        }
    }
}
