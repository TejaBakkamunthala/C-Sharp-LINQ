using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class GroupingOperator
    {

        
      


        public void GroupingOperator1()
        {
            int[] arr = { 10, 30, 50, 70, 20, 40, 60 };

            Console.WriteLine("GROUPING OPERATOR 1");
            var result1 = arr.ToList();
            Console.WriteLine(result1);
            Console.WriteLine("TO LIST");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            var result11 = (from num in arr select num).ToList();
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }


        public void GroupingOperator2()
        {

            Console.WriteLine("GROUPING OPERATOR2");
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(60);
            list.Add(80);
            list.Add("hii");

            Console.WriteLine("OFTYPE");

            var result2 = list.OfType<int>();
            foreach (var item in result2)
            {
                Console.WriteLine(item + " ");
            }

            //Console.WriteLine("CAST");
            //var result1 = list.Cast<int>();

            //foreach(var item in result1)
            //{
            //    Console.WriteLine(item+" ");
            //}


            Console.WriteLine("TO ARRAY");
            var result = list.ToArray();

            foreach (var item in result)
                Console.WriteLine(item + " ");
        }


        public class students {

            public int id { get; set; }
            public string name { get; set; }

            public int standard { get; set; }
            public int age { get; set; }



            public static List<students> GetAllStudents() {
                List<students> lstudents = new List<students>()
            {
                new students { id = 1,name="Teja",standard=10,age=14},
                new students { id = 2,name="Sunil",standard=10,age=14},
                new students { id = 3,name="Tharun",standard=11,age=15},
                new students { id = 4,name="Bhaskhar",standard=11,age=15},
                new students { id = 5,name="Jayanth",standard=12,age=16},
                new students { id = 6,name="Pavan",standard=12, age=16},
                new students { id = 7,name="Somesh",standard=11,age=17},
                new students { id = 8,name="Lokesh",standard=11,age=17},
                 new students { id = 9,name="Chaitanya",standard=12,age=18},
                new students { id = 10,name="RajaShekhar",standard=12,age=18},
                new students { id = 11,name="Somesh",standard=11,age=17},
                new students { id = 12,name="Jaya",standard=10,age=22}


            };
                return lstudents;


            

            
            }



            }

    }



}
