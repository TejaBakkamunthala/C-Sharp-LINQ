using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class RemoveSpecialCharacters
    {
        //REGEX
        public void SpecialCharacter1(){

            string input = "AA@%^&CC\"";

            string input2 = Regex.Replace(input, @"[\W]", "");
            Console.WriteLine(input2);




            Console.WriteLine(input);

        }
    }
}
