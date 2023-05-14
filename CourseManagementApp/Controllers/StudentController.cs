using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementApp.Models;

namespace CourseManagementApp.Controllers
{
    internal class StudentController
    {
        public void AddNewStudent() {
            Console.WriteLine();

            Console.Write("Enter Group ID: ");
            string groupID=Console.ReadLine();
            Console.Write("Enter student ID: ");
            string studentID=Console.ReadLine();
            Console.Write("Enter fullname of student: ");
            string fullname=Console.ReadLine();
            Console.Write("Enter the type (With warranity/Without): ");
            string type=Console.ReadLine();

            Student student = new Student(studentID, fullname, groupID, type);
            Group g1 = new Group(student);

        }
    }
}
