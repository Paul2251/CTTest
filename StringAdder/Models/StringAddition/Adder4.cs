using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder4 : Adder3
    {
        public override List<string> SplitUpListIntoNumberStrings(string listOfNumbers, string divider = ",")
        {
            if (Regex.IsMatch(listOfNumbers, @"^//.\n"))
            {
                string newDivider = Regex.Match(listOfNumbers, @"^//.\n").ToString();
                divider = Regex.Replace(Regex.Replace(newDivider, "^//", ""), "\n", "");
                listOfNumbers = Regex.Replace(listOfNumbers, @"^//.\n", "");
            }
            return base.SplitUpListIntoNumberStrings(listOfNumbers, divider);
        }

       
    }
}


//To change a delimiter, the beginning of the string will contain a separate line that looks like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the delimiter is ‘;’.
