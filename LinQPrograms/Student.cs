using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    internal class Student
    {

        int id{ get; set; }
        string name{ get; set; }

        int age { get; set; }


        int standard {  get; set; }


        public static List<Student> GetAllStudents()
        {

            List<Student> students = new List<Student>()
            {
                new Student { id = 1,name="Teja",age=22,standard=8 },
                new Student{ id = 2, name="Jayanth",age=23,standard=8},
                new Student{id=3,name="Lokesh",age=23,standard=8},
                new Student{id=4,name="Chaiatanya" ,age=24,standard=9},
                new Student {id=5,name="Raja Shekhar", age=25,standard=9},
                new Student{id=6,name="Sunil",age=23,standard=10 },
                new Student{id=7,name="Somesh",age=24,standard=10},
                new Student{id=8,name="Tharun",age=25,standard=9}


            };
            return students;

        }


    }
}
