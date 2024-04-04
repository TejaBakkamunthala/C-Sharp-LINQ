using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    internal class ArrayProgram1
    {
       


        public void ArrayProgram11()
        {
            int[] arr = { 20, 40, 50, 12, 3, 4, 5, 16 };


            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.Write(arr[i]+"  ");
            //}

            Console.WriteLine();
            var brr=from i in arr select i;
            foreach(int i in brr)
            {
                Console.Write(i+ " ");
            }

            Console.WriteLine();

            var brr1 = from i in arr where i > 10 orderby i select i;
            foreach(int i1 in brr1)
            {
                Console.Write(i1+" " );
            }


            Console.WriteLine();

            var brr2 = from i in arr where i > 10 orderby i descending select i;
            foreach(int i2 in brr2)
            {
                Console.Write(i2+" ");
            }

        }
    }
}
