using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public  class Employees
    {

        public string name { get; set; }
        public String department { get; set; }
        public DateTime joiningDate { get; set; }


        public static List<Employees> GetAllEmployees()
        {

         //   DateTime date1 = DateTime.Now.AddMonths(-6);

             
            //Console.WriteLine(date1);

            List<Employees> employeesList = new List<Employees>()
            {
            new Employees { name = "Teja", department = "IT", joiningDate = new DateTime(2024,02,13) },
            new Employees { name = "Jayanth", department = "IT", joiningDate = new DateTime(2024,01,01)},
            new Employees { name = "Sai", department = "Testing", joiningDate = new DateTime(2023,11,11) },
            new Employees { name = "Lokesh", department = "Testing", joiningDate = new DateTime(2022,02,02) },
            new Employees { name = "Pavan", department = "IT", joiningDate = new DateTime(2023,02,03) }

        };
            return employeesList; 
        }
    }
}
