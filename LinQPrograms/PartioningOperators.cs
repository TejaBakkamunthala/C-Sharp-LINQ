using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    internal class PartioningOperators
    {
        public void PartioningOperators1()
        {
            String[] names = {  "Chaiatnya", "Sai", "Chaiatnya","Jaynath","Sunil","RajaShekhar", "Teja", };

            var result1= from name in names select name;

            foreach(var name in result1 )
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();

            var result2= from name in names orderby name select name;
            foreach(var name in result2)
            {
                Console.Write(name+" ");
            }

            Console.WriteLine();

            // IEnumerable<PartioningOperators> result3=from name in names orderby name descending select name

            var result3 = from name in names orderby name descending select name;
            foreach(var name in result3)    
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Take ");

            var result4 = names.Take(3);

           foreach(var name in result4)
            {
                Console.Write(name+" ");
            }

            Console.WriteLine();
            Console.WriteLine("Skip");
            var result5 = names.Skip(3);
            foreach(var name in result5)
            {
                Console.Write(name+" ");
            }

            Console.WriteLine();
            Console.WriteLine("Take While");

            var result6 = names.TakeWhile(name=>name.Length>3);
            foreach (var name in result6)
            {
                Console.Write(name+" ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Skip While");
            var result7 = names.SkipWhile(name => name.Length <=5);
            foreach (var name in result7) {
                Console.WriteLine(name +" ");
            }



            //var result4 = from name in names select name.Take(1);
            //Console.WriteLine(result4);

            //foreach (var name in result4)
            //{
            //    Console.Write(name + " ");
            //}



            //var result5=from name in names select name.Reverse();
            //foreach(var name in result4)
            //{
            //    Console.WriteLine(name+" ");
            //}



        }

    }
}
