using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp.Models
{
    internal class Student
    {
        public string StudentId { get; set; } 
        public string FullName { get; set; }
        public string GroupID { get; set; }
        public string Type { get; set; }

        public Student(string studentID, string fullname, string groupId, string type ) { 
            
            this.StudentId = studentID;
            this.FullName = fullname;
            this.GroupID = groupId;
            this.Type = type;

        }
    }
}
