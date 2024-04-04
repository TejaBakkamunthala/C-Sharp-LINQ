using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LinQPrograms
{
    internal class RestrictionOperator
    {

        public void RestrictionOperator1()

        {

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };


            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] % 2 == 0)
                {
                    Console.Write(list1[i]+" ");
                }
            }

            Console.WriteLine();


            List<int> evenNum = list1.Where(x => x % 2 == 0).ToList();// Lamda Expression 

            foreach (int eve in evenNum)
            {
                Console.Write(eve+" ");
            }
            Console.WriteLine();

            IEnumerable<int> evenNums=from num in list1 where (num%2==0) select num;

            foreach(int x1 in evenNums)
            {
                Console.Write(x1+" ");
            }
            Console.WriteLine();


            var oddNums = list1.Where(x => x % 2 !=0).ToList();
            foreach (int x1 in oddNums)
            {
                Console.Write(x1+" ");
            }
            Console.WriteLine();

            var oddNums1 = from od in list1 where od % 2 != 0  select od;
            foreach (int x1 in oddNums1)
            {
                Console.WriteLine(x1+" ");
            }

            IEnumerable<int> evenNumss = list1.Select((num, index) => new { Number = num, Index = index }).Where(x=> x.Number%2==0).Select(x => x.Number);

           
            foreach(int i in evenNumss)
            {
                Console.WriteLine(i+" ");
            }



        }
    }
}
