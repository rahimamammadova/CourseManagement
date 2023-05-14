using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementApp.Models;

namespace CourseManagementApp.Controllers
{
    internal class GroupController
    {
        public List<Group> Groups { get; set; }

        public GroupController() { 
            Groups=new List<Group>();
        }

        public void CreateGroup(){
            try
            {
                Console.Write("Please enter group ID: ");
                string groupNo = Console.ReadLine();
                CheckNewGroupId(groupNo);
                Console.Write("Please enter group category: ");
                string groupCategory = Console.ReadLine();
                Console.Write("Group is online or offline Choose(ON or OFF): ");
                string groupOnOff = Console.ReadLine();

                bool isOnline = false;
                if (groupOnOff.ToLower() == "on")
                {
                    isOnline = true;
                }

                Group group = new Group(groupNo, groupCategory, isOnline);
                Groups.Add(group);
            }
            catch (Exception ex) { 
                Console.WriteLine("Something went wrong. Please try again. ");
                CreateGroup();
            }
        }

        public void ShowGroupInfo()
        {
            foreach (Group groups in Groups) {
                Console.WriteLine();
                Console.WriteLine($"Group number: {groups.GroupId}");
                Console.WriteLine($"Group category: {groups.Category}");
                Console.WriteLine($"Number of students: {groups.GroupLimit}");
                Console.WriteLine();
            }
        }

        public void CheckNewGroupId(string groupId) {
            foreach (Group group in Groups.Where(y=>y.GroupId==groupId).ToList()) {

                Console.WriteLine($"{groupId} ID already exists");
                Console.Write($"Enter new group ID for {groupId}: ");
                string newGroupID=Console.ReadLine();
                group.GroupId = newGroupID;

            }
        }

        public void EditGroup()
        {
            Console.WriteLine();
            Console.Write("Enter group name that you would like to edit: ");
            string existingGroup = Console.ReadLine();
            foreach (Group groups in Groups)
            {
                if (groups.GroupId == existingGroup)
                {
                    Console.Write("Enter new group ID: ");
                    string newGroupID = Console.ReadLine();
                    groups.GroupId = newGroupID;
                    
                }
            }
        }

        public void ShowAllStudentsInGroups() {

            Console.WriteLine();
            Console.WriteLine("Enter group name: ");

        }
    }
}
