using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class ProjectionStudent
    {
        public string name { get; set; }

        public string gender { get; set; }

        public int age { get; set; }

        public int id {  get; set; }


        public List<string> subjects { get; set; }

        public static List<ProjectionStudent> GetAllStudents()
        {
            List<ProjectionStudent> lsStudent = new List<ProjectionStudent>() {
            new ProjectionStudent { id=101,name = "Teja", gender = "Male",age=20, subjects = new List<string> { "C#", "VB.Net" } },
            new ProjectionStudent { id=102,name = "Kavitha", gender = "Female", age=22, subjects = new List<string> { "C#", "VB.Net" } },
            new ProjectionStudent { id=103, name = "Sunil", gender = "Male", age=24,subjects = new List<string> { "SQL", "ASP.NET" } },
            new ProjectionStudent { id=104,name = "Jayanth", gender = "Male", age=26, subjects = new List<string> { "SQL", "ASP.NET" } },
            new ProjectionStudent { id=105,name = "Ramya", gender = "Female", age=28, subjects = new List<string> { "SQL", "ASP.NET" } }


        };

            return lsStudent;
        }




    }

}

