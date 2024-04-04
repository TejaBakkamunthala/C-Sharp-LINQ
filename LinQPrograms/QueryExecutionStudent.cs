using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class QueryExecutionStudent
    {

     
        public int id { get; set; }
        public string name { get; set; }
        public int totalMarks { get; set; }

        public string designation { get; set; }


        public static List<QueryExecutionStudent> getAllStduents()
        {

            List<QueryExecutionStudent> lsStudent = new List<QueryExecutionStudent>()
            {
            new QueryExecutionStudent { id = 101,name= "Teja",totalMarks=88, designation="SE"},

            new QueryExecutionStudent { id=102,name= "Sunil",totalMarks=99, designation="SSE"},

            new QueryExecutionStudent { id=103,name= "Jayanth",totalMarks=77, designation="SE"},

               new QueryExecutionStudent { id=104,name= "Lokesh",totalMarks=65, designation="SSE"},

               new QueryExecutionStudent { id=105,name= "Somesh",totalMarks=55, designation="SE"}

        };
            lsStudent.Add(new QueryExecutionStudent { id = 107, name = "Chaitanya", totalMarks = 85 ,designation="SE"});
            return lsStudent;

        }
    }
}
