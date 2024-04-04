using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class Program
    {
        static void Main(string[] args)

        {

            //ArrayProgram1 ap = new ArrayProgram1();
            //ap.ArrayProgram11();

            //  Aggregate1 ag1=new Aggregate1();
            //ag1.Aggregate11();

            //RestrictionOperator ro=new RestrictionOperator();
            //ro.RestrictionOperator1();





            /* var result = ProjectionStudent.GetAllStudents().Select(std => new{ std.name,std.gender});

             foreach(var student in result)
             {
                 Console.WriteLine(student.name+"  "+student.gender);
             }

             Console.WriteLine();
             var result1 = ProjectionStudent.GetAllStudents().SelectMany(std =>  std.subjects );

             foreach(var student in result1)
             {
                 Console.WriteLine(student+" ");
             }


             Console.WriteLine();
             var result3 = ProjectionStudent.GetAllStudents().SelectMany(std=> std.subjects).Distinct();
             foreach(var student in result3)
             {
                 Console.WriteLine(student+" ");
             }

             var result4 = ProjectionStudent.GetAllStudents().Select(std => new { std.name, std.gender }).OrderBy(s=>s.name+" "+s.gender);

             foreach(var student in result4)
             {
                 Console.WriteLine(student+" ");
             }

             var result5 = ProjectionStudent.GetAllStudents().OrderBy(st => st.name + "  " + st.gender);
             foreach(var student in result5)
             {
                 Console.WriteLine(student.name+"   "+student.gender);
             }

             var result6 = ProjectionStudent.GetAllStudents().Select(std => new { std.name, std.gender }).OrderByDescending(st => st.name + "  " + st.gender);
             foreach(var student in result6)
             {
                 Console.WriteLine(student+"  ");
             }

             var result7 = ProjectionStudent.GetAllStudents().OrderByDescending(st => st.name + "/t" + st.gender);
             foreach(var student in result7)
             {
                 Console.WriteLine(student.name+"  "+student.gender);
             }

             Console.WriteLine();
             Console.WriteLine("Studnet Details With Age Ascending Order ");
             var result8=ProjectionStudent.GetAllStudents().OrderBy(student=>student.age).ThenBy(student=>student.age);
             foreach(var student in result8)
             {
                 Console.WriteLine(student.name+"\t"+student.gender+"\t"+student.age);

             }
             Console.WriteLine();
             Console.WriteLine("Student Details With age Descending Order ");
             var result9=ProjectionStudent.GetAllStudents().OrderByDescending(student=>student.age).ThenByDescending(student=>student.age);
             foreach(var student in result9)
             {
                 Console.WriteLine(student.name+"\t"+student.gender+"\t"+student.age);
             }


             Console.WriteLine("LINQ");
             Console.WriteLine( "Get All Studentss");

             IEnumerable<ProjectionStudent> liq1 = from student in ProjectionStudent.GetAllStudents() select student;

                 foreach(var student in liq1)
             {
                 Console.WriteLine(student.name+"\t"+student.gender);
             }

             Console.WriteLine();

             Console.WriteLine("Get All Students By Ascending ");
             IEnumerable<ProjectionStudent> liq2 = from student in ProjectionStudent.GetAllStudents() orderby student.name +" "+student.gender  select student;

             foreach(var student in liq2)
             {
                 Console.WriteLine(student.name+"\t"+student.gender);
             }

             Console.WriteLine();
             Console.WriteLine("Get All Students BY Descending Order");
             IEnumerable<ProjectionStudent> liq3=from student in ProjectionStudent.GetAllStudents() orderby student.name +"  "+student.gender+"  "+student.age descending select student;

             foreach(var student in liq3)
             {
                 Console.WriteLine(student.name+"\t"+student.gender+"\t"+student.age+"\t"+student.subjects);
             }

             Console.WriteLine();
             Console.WriteLine("Get All Student Details With Subjects");
             IEnumerable<ProjectionStudent> liq4 = from student in ProjectionStudent.GetAllStudents() orderby student.name + "\t" + student.gender + "\t" + student.subjects select student;

             foreach(var student in liq4)
             {
                 Console.WriteLine(student.name+"\t"+student.gender+"\t"+student);
             }
             Console.WriteLine();



             Console.WriteLine("Get Students With Sujects ");
             IEnumerable<ProjectionStudent> liq5 = from student in ProjectionStudent.GetAllStudents() orderby student.age +" "+ student.subjects select student;

             foreach (var student in liq5)
             {
                 Console.WriteLine(student.age+" "+student + " ");
             }

             Console.WriteLine("Using ThenBy");

             IEnumerable<ProjectionStudent> liq6 = from student in ProjectionStudent.GetAllStudents() orderby student.id+"\t"+ student.name + " " + student.age descending select student;

             foreach(var student in liq6)
             {
                 Console.WriteLine(student.name+"\t"+student.id+"\t"+student.name+"\t"+student.age);
             }


             */



            //PartioningOperators po=new PartioningOperators();
            //po.PartioningOperators1();


            /*
            //Query Executionn
            var result1 = QueryExecutionStudent.getAllStduents();
            foreach(var student in result1)
            {
                Console.WriteLine(student.id+" "+student.name+" "+student.totalMarks);
            }

            Console.WriteLine("To List");
            var result2 = (from student in QueryExecutionStudent.getAllStduents() where student.totalMarks > 80 select student).ToList();
            foreach(var student in result2) {
                Console.WriteLine(student.id+"  "+student.name+"  "+student.totalMarks);
            }


            var result3=from student in QueryExecutionStudent.getAllStduents() where student.totalMarks>80 select student;
            foreach(var student in result3)
            {
                Console.WriteLine(student.name+" "+student.totalMarks);
            }

            //var resultLiq1 = from student in QueryExecutionStudent.getAllStduents().Max(stud);

            var result4 = QueryExecutionStudent.getAllStduents().OrderBy(student => student.id + " " + student.name + "  " + student.totalMarks);

            foreach(var student in result4)
            {
                Console.WriteLine(student+" ");
            }

            var result5 = QueryExecutionStudent.getAllStduents().OrderBy(student => student.id);

            Console.WriteLine("Lamda expression ");
            foreach (var student in result5)
            { 
            
                Console.WriteLine(student.id +" "+student.name+" "+student.totalMarks );
            }

            Console.WriteLine("Max");
            var result6=QueryExecutionStudent.getAllStduents().Max(student=>student.totalMarks);
            Console.WriteLine("Max "+result6);

            Console.WriteLine("Min");
            var result7 = QueryExecutionStudent.getAllStduents().Min(student => student.totalMarks);
            Console.WriteLine("Min "+result7);

        
            */

            //DICTIONARYY

            //var result7=QueryExecutionStudent.getAllStduents().ToDictionary(student=>student.id, student=>student.name);

            //foreach(KeyValuePair<int,string> result in result7)
            //{
            //    Console.WriteLine(result.Key+" "+result.Value);
            //}


            //Console.WriteLine();


            //var result8 = (from student in QueryExecutionStudent.getAllStduents() select student.id + " " + student.name) to

            //foreach(KeyValuePair<int,string> result in result8)
            //{
            //    Console.WriteLine(result.Key+" "+result.Value);
            //}


            //LOOKUP
            //var result9 = QueryExecutionStudent.getAllStduents().ToLookup(student => student.designation);

            //foreach( var result in result9)
            //{
            //    Console.WriteLine(result.Key);
            //    foreach(var item in result9[result.Key])
            //    {
            //        Console.WriteLine(item.id+"  "+item.name);
            //    }

            //}


            GroupingOperator go = new GroupingOperator();

            //go.GroupingOperator1();
            //  go.GroupingOperator2();

            //   GroupingOperator.students st=new GroupingOperator.students();
            //GroupingOperator.students.GetAllStudents();

            //Console.WriteLine("USING LAMBDA ");
            //var students = GroupingOperator.students.GetAllStudents();
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.id + " " + student.name + " " + student.standard + " " + student.age);
            //}

            //Console.WriteLine("USING LINQ");
            //var students2=from st in    GroupingOperator.students.GetAllStudents() select st;
            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student.id+" "+student.name+" "+student.standard+" "+student.age);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Group by");
            //var student3=from st in GroupingOperator.students.GetAllStudents() 
            //             group st by st.standard into eGroup 
            //             orderby eGroup.Key
            //             select eGroup;

            //foreach(var student in student3)
            //{
            //    Console.WriteLine("standard: {0}",student.Key);
            //    foreach(var stud in student)
            //    {
            //        Console.WriteLine(stud.id+" "+stud.name+" "+stud.standard+" "+stud.age);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();




            // Console.WriteLine("Group by using lamda ");
            //// var student4=GroupingOperator.students.GetAllStudents().GroupBy(st => st.standard).ToList();

            // var student4=GroupingOperator.students.GetAllStudenits().GroupBy(st=>st.standard).OrderBy(sta=>sta.Key).ToList();
            // foreach(var student in student4)
            // {
            //     Console.WriteLine("standard: {0}",student.Key);
            //     foreach (var stud in student)
            //     {
            //         Console.WriteLine(stud.id+" "+stud.name+" "+stud.standard+" "+stud.age);


            //     }
            //     Console.WriteLine();
            // }




            //var student5 = from st in GroupingOperator.students.GetAllStudents()
            //               group st by st.name into eGroup
            //               orderby eGroup.Key
            //               select eGroup;

            //foreach(var student in student5)
            //{
            //    //Console.WriteLine("standard {0}",student.Key);
            //    foreach(var stud in student) {
            //        Console.WriteLine(stud.id+" "+stud.name+" "+stud.standard+" "+stud.age);
            //    }
            //}

            //Console.WriteLine("SORT NAME BY USING LAMBDA");
            // var student6=GroupingOperator.students.GetAllStudents().GroupBy(na=>na.name).OrderBy(na=>na.Key).ToList();
            //foreach(var student in student6 )
            //{
            //    Console.WriteLine("standard: {0}",student.Key);
            //    foreach (var std in student)
            //    {
            //        Console.WriteLine(std.name+" "+std.id+" "+std.standard+" "+std.age);


            //    }
            //    Console.WriteLine();
            //}


            //var student7 = from st in GroupingOperator.students.GetAllStudents()
            //               group st by st.standard into eGroup
            //               orderby eGroup.Key
            //               select new { StandardKey = eGroup.Key, StudentObj = eGroup.OrderBy(s => s.name) };


            //foreach (var group in student7)
            //{
            //    Console.WriteLine ("Standard : {0} ",group.StandardKey);

            //    foreach(var student in group.StudentObj)
            //    {
            //        Console.WriteLine(student.id + " " + student.name + " " + student.standard + " " + student.age);
            //    }

            //}


            //Console.WriteLine();
            //Console.WriteLine("LINQ ");


            //var result=GroupingOperator.students.GetAllStudents().GroupBy(st=>st.standard).OrderBy(s=>s.Key).Select(na=> new {StandardKey =na.Key,StudentObj=na.OrderBy(n=>n.name) });


            //foreach (var group in result)
            //{
            //    Console.WriteLine("Standard : {0} ", group.StandardKey);

            //    foreach (var student in group.StudentObj)
            //    {
            //        Console.WriteLine(student.id + " " + student.name + " " + student.standard + " " + student.age);
            //    }

            //}

            //Console.WriteLine(Student.GetAllStudents());


            //var result1=Student.GetAllStudents();
            //foreach(var student in result1)
            //{
            //    Console.WriteLine(student +"  ");
            //}




            //GROUP BY MULTIPLE KEYS
            //var result=from std in GroupingOperator.students.GetAllStudents()
            //           group std by new {std.standard,std.age} into eGroup
            //           orderby eGroup.Key.standard,eGroup.Key.age
            //           select eGroup;


            //foreach(var student in result)
            //{
            //    Console.WriteLine(" standard {0}, age{1}" ,student.Key.standard,student.Key.age);
            //    foreach(var stud in student)
            //    {
            //        Console.WriteLine("{0} {1} {2} {3}" ,stud.id, stud.name,stud.standard,stud.age);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("using Lambda");
            //var result1 = GroupingOperator.students.GetAllStudents().GroupBy(st => new { st.standard, st.age }).
            //    OrderBy(st => st.Key.standard).ThenBy(st=>st.Key.age);


            //foreach(var student in result1)
            //{
            //    Console.WriteLine("standard {0} ,age{1} ",student.Key.standard,student.Key.age);
            //    foreach(var std  in student)
            //    {
            //        Console.WriteLine("{0} {1} {2} {3} ",std.id,std.name,std.standard,std.age);
            //    }
            //    Console.WriteLine();
            //}



            //Console.WriteLine("BY USING SORT BY NAME");

            //var result3 = from std in GroupingOperator.students.GetAllStudents()
            //              group std by new { std.standard, std.age } into eGroup
            //              orderby eGroup.Key.standard, eGroup.Key.age
            //              select new
            //              {
            //                  Standardkey = eGroup.Key.standard,
            //                  AgeKey = eGroup.Key.age,
            //                  StudentObj = eGroup.OrderBy(st => st.name)
            //              };

            //foreach (var student in result3)
            //{
            //    Console.WriteLine("standard{0}  age{1}", student.Standardkey, student.AgeKey);
            //    foreach (var std in student.StudentObj)
            //    {
            //        Console.WriteLine("{0}    {1}    {2}    {3}", std.id, std.name, std.standard, std.age);
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine(" SORT BY NAME BY USING LAMDA ");
            //var result4 = GroupingOperator.students.GetAllStudents().
            //    GroupBy(st => new { st.standard, st.age }).OrderBy(st => st.Key.standard).ThenBy(st => st.Key.age).
            //    Select(st => new { StandardKey = st.Key.standard, AgeKey = st.Key.age, studentObj = st.OrderBy(na=> na.name) });


            //foreach (var student in result4)
            //{
            //    Console.WriteLine("standard {0} name{1} ", student.StandardKey, student.AgeKey);
            //    foreach (var std in student.studentObj)
            //    {
            //        Console.WriteLine("{0} {1} {2} {3} ", std.id, std.name, std.standard, std.age);
            //    }
            //    Console.WriteLine();
            //}

        


            // var result=Products.getAllproducts().

            //var result1 = from pro in Products.getAllproducts() where pro.price > 20 select pro;
            //foreach (var pro in result1)
            //{
            //    Console.WriteLine(pro.name + "  " + pro.price + " " + pro.category);
            //}

            //var result2=Products.getAllproducts().Where(pro=>pro.price<40
            //).ToList();
            //foreach(var pro in result2)
            //{
            //    Console.WriteLine(pro.name+" "+pro.price+" "+pro.category);
            //}

            //var result3 = from pro in Products.getAllproducts() where pro.category == "biscuit" select pro;
            //foreach(var pro in result3)
            //{
            //    Console.WriteLine(pro.name+" "+pro.price+" "+pro.category);
            //}

            //var result4 = Products.getAllproducts().Where(pro => pro.category == "fruit").ToList();
            //foreach(var pro in result4)
            //{
            //    Console.WriteLine(pro.name + " " + pro.price + " " + pro.category);
            //}


            //var result=from  emp in Employees.GetAllEmployees() where emp.department=="IT" select emp;
            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp.name+"  "+emp.department+" "+emp.joiningDate);
            //}

            //var result1 = Employees.GetAllEmployees().Where(emp => emp.department == "IT").ToList();
            //foreach (var emp in result1)
            //{
            //    Console.WriteLine(emp.name+" "+emp.department+" "+emp.joiningDate);
            //}

            // var result2=from emp in Employees.GetAllEmployees() where emp.joiningDate=="01-02-2024" select emp;

            //DateTime res = DateTime.Now.AddMonths(-6);
            //Console.WriteLine("Result "+res);

            //var result3=Employees.GetAllEmployees().Where(emp=>emp.joiningDate>=res).ToList();

            //foreach(var emp in result3)
            //{
            //    Console.WriteLine(emp.name+" "+emp.department+" "+emp.joiningDate);
            //}



            int[] IntArr = { 1, 2, 3, 4, 5, 6,6, 7,7,8,9,9 };
            int[] IntArray = { 10, 30, 50, 40, 90, 20, 60, 70, 80, 100 };
            int[] IntArray2 = { 10, 30, 40, 55, 75, 99, 100 };

            //LINQ METHODS1

            //var result1 = LinqMethods1.Employee.GetAllEmployees();
            //foreach(var employe in result1)
            //{
            //    Console.WriteLine(employe.ID+" "+employe.Name+" "+employe.Salary+" "+employe.Department);
            //}

            //var result2 = from emp in LinqMethods1.Employee.GetAllEmployees() select emp;

            //foreach (var employe in result2)
            //{
            //    Console.WriteLine(employe.ID + " " + employe.Name + " " + employe.Salary + " " + employe.Department);
            //}

            //Console.WriteLine("Lamda Expression");
            //var result1 = IntArr ;

            //foreach( var arr in result1)
            //{
            //    Console.WriteLine(arr);
            //}

            //Console.WriteLine("LINQ Query");

            //var result2=from arr in IntArr select arr;
            //foreach( var arr in result2)
            //{
            //    Console.WriteLine(arr);
            //}

            //wHERE
            //var result1 = LinqMethods1.Employee.GetAllEmployees().Where(emp => emp.Salary > 20000 && emp.Department=="IT").ToList();
            //foreach (var emp in result1)
            //{
            //    Console.WriteLine(emp.ID+" "+emp.Name+" "+emp.Salary+" "+emp.Department);
            //}
            //Console.WriteLine("lINQ");

            //var result2 = from emp in LinqMethods1.Employee.GetAllEmployees() where emp.Salary > 20000 && emp.Department == "IT" select emp;
            //foreach(var emp in result2)
            //{
            //    Console.WriteLine(emp.ID+" "+emp.Name+" "+emp.Salary+" "+emp.Department);
            //}


            //DISTINCT

            //var result1=IntArr.Distinct().ToList()
            //foreach(var result in result1)
            //{
            //    Console.WriteLine(result +" ");
            //}


            //Console.WriteLine("lamda");

            //var result1=LinqMethods1.Employee.GetAllEmployees().Select(emp=>emp.Name).Distinct().ToList();

            //foreach(var empp in result1)
            //{
            //    Console.WriteLine(empp);
            //}

            //Console.WriteLine("LINQ");
            // var result2=(from emp in LinqMethods1.Employee.GetAllEmployees()  select emp.Name).Distinct().ToList();

            //foreach(var empp in result2)
            //{
            //    Console.WriteLine(empp);
            //}


            //  RemoveSpecialCharacters rsc=new RemoveSpecialCharacters();
            //rsc.SpecialCharacter1();


            //CONACT

            //var result1=IntArray.Concat(IntArray2);
            //foreach (var result in result1)
            //{
            //    Console.Write(result + " ");
            //}

            //INTERSECT
            //Console.WriteLine();
            //var result2=IntArray.Intersect(IntArray2);
            //foreach(var result in result2)
            //{
            //   Console.Write(result+" ");
            //}



            //Console.WriteLine("INTERSECT");

            //var result3=from em in IntArray.Intersect(IntArray2) select em;
            //foreach (var result in result3)
            //{
            //    Console.Write(result+" ");
            //}


            //var result4=from em in IntArray.Union(IntArray2) select em;
            //foreach(var result in result4)
            //{
            //    Console.Write(result+" ");
            //}




            //PRODUCTS
            //TOTAL SALESFOR EACH CATEGORY

            //var sales = from sal in ProdutCategory.products.GetAllProducts()
            //            group sal by sal.category into proGroup
            //            orderby proGroup.Key
            //            select proGroup;

            //foreach( var prod in sales )
            //{
            //    Console.WriteLine("Category: {0}",prod.Key);

            //    foreach( var pro in prod)
            //    {
            //        Console.WriteLine(pro.pName+" "+pro.price+" "+pro.category);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //var saless = from sal in ProdutCategory.products.GetAllProducts()
            //             group sal by sal.category into proGroup
            //             orderby proGroup.Key
            //             select proGroup;

            //foreach (var prod in saless)
            //{
            //    Console.WriteLine("Product : {0}");
            //    foreach (var pr in prod)
            //    {
            //        Console.WriteLine(pr.pName+" "+pr.price);

            //    }

            //}






            //ELEMENT OPERATOR

            int[] arr = { 12, 30, 40, 50, 100, 300 };

            int[] arr1 = { };

            var result = arr.First();

            Console.WriteLine(result);

            var result1 = arr.FirstOrDefault();
            Console.WriteLine(result1);

           
            var result3 = arr1.FirstOrDefault();
            Console.WriteLine(result3);

            int result4=arr.Last();
            Console.WriteLine(result4);

            int result5 = arr.LastOrDefault();
            Console.WriteLine(result5);

            int result6 = arr1.LastOrDefault();
            Console.WriteLine(result6);

            int result7 = arr.ElementAt(3);
            Console.WriteLine(result7);

           // int result8 = arr.ElementAt(100);
            //Console.WriteLine("ElementAtOrDefault " + result8);

            int result9 = arr1.ElementAtOrDefault(100);
            Console.WriteLine("ElementAtOrDefault "+result9);

            // int result10 = arr.Single();
            //  Console.WriteLine(result10);

            //int result11 = arr.SingleOrDefault();
            //Console.WriteLine(result11);

            Console.WriteLine("DefaultIfEmpty");
            var result2=arr.DefaultIfEmpty();
            foreach (var item in arr)
            {
            Console.WriteLine(item+" ");
            }



            Console.WriteLine("eVENN");
            

            int[] arrr = { 12, 30, 40, 50,51, 100, 300 };

            var evenNum=from num in arrr where num%2==0 select num;

            foreach(var item in evenNum)
            {
                Console.WriteLine(item+" ");
            }




        }
    }
}