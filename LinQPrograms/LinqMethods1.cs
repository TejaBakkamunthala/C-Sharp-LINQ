using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class LinqMethods1
    {

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public string Department { get; set; }
            public static List<Employee> GetAllEmployees()
            {
                List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID= 101,Name = "Teja", Salary = 10000, Department = "IT"},
                new Employee{ID= 102,Name = "Sunil", Salary = 15000, Department = "Sales"},
                new Employee{ID= 103,Name = "Tharun", Salary = 25000, Department = "Sales"},
                new Employee{ID= 104,Name = "Bhanu", Salary = 20000, Department = "IT"},
                new Employee{ID= 105,Name = "Teja", Salary = 30000, Department = "IT"},
                new Employee{ID= 106,Name = "Lokesh", Salary = 25000, Department = "IT"},
                new Employee{ID= 107,Name = "Ajay", Salary = 35000, Department = "IT"},
                new Employee{ID= 108,Name = "Sandeep", Salary = 11000, Department = "Sales"},
                new Employee{ID= 109,Name = "Siarm", Salary = 20000, Department = "Sales"},
                new Employee{ID= 110,Name = "Sunil", Salary = 25000, Department = "Sales"}
            };
                return listEmployees;
            }
        }

    }
}
