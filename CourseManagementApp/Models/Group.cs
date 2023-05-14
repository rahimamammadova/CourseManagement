using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp.Models
{
    internal class Group
    {
        public string GroupId { get; set; }  
        public string Category { get; set; } 
        public bool IsOnline { get; set; }
        public int GroupLimit { get; set; }
        public List <Student> Students;

        public Group(Student student) { 
            Students= new List<Student>();
            Students.Add(student);
        }

        public Group(string groupID, string category, bool isOnline) {
            
            this.GroupId = groupID;
            this.Category = category;
            this.IsOnline = isOnline;
            if (IsOnline == true)
            {
                GroupLimit = 15;
            }
            else { GroupLimit = 10; }

            //Students = new List<Student>();
        }
        public string StringOnline() {
            if (IsOnline == true)
            {
                return "Online";
            }
            else {
                return "Offline";
            }
        }
    }
}
