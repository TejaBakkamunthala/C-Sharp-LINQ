using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    internal class Aggregate1
    {

        public void Aggregate11()
        {
            int[] arr = { 20, 30, 40, 60, 44, 1, 2, 56 };

            int min=arr.Min(); ;
            Console.WriteLine("Min "+min);
            int max=arr.Max();
            Console.WriteLine("Max "+max);
            int sum=arr.Sum();
            Console.WriteLine("Sum "+sum);
            int count = arr.Count();
            Console.WriteLine("Count "+count);
            double avgg = arr.Average();
            Console.WriteLine("Averagee "+avgg);

            int agg = arr.Aggregate ((a, b) => (a + b));
            Console.WriteLine("Aggregate "+agg);


            int agg1= arr.Aggregate(10,(a, b) => (a * b));
            Console.WriteLine("Aggregate " + agg1);

            string[] countries = { "INDIA", "UK", "USA", "CHINA" };

            String agg2=countries.Aggregate((a,b)=>(a+" , "+b));
            Console.WriteLine("agg2 "+agg2 );


        //    List<int> maxx = from aa in arr.Max().




        }
    }
}
