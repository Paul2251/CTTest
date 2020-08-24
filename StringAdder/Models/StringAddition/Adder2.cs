using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder2 : Adder
    {
        public override double AddTogetherStringList(string listOfNumbers, string divider = ",")
        {
            if (Regex.IsMatch(listOfNumbers,divider + @"\n")) { throw new Exception("The following input is NOT ok: ',newline'"); }
            if (Regex.IsMatch(listOfNumbers, @"\n" + divider)) { throw new Exception("The following input is NOT ok: 'newline,'"); }
            double dblResult = 0;
            listOfNumbers = Regex.Replace(listOfNumbers, @"\n", divider);
            string pattern = divider;
            string[] arrNumbers = Regex.Split(listOfNumbers, pattern,
                                          RegexOptions.IgnoreCase,
                                          TimeSpan.FromMilliseconds(1500));
            arrNumbers.ToList().ForEach(x => dblResult += Convert.ToDouble(x));
            return dblResult;
        }

       
    }
}

//Allow the Add method to handle new lines between numbers(as well as commas).
//a.The following input is ok: “1\n2,3” (will equal 6).
//b.The following input is NOT ok: “1,\n”.

//Support different single character delimiters(case-insensitive).
//To change a delimiter, the beginning of the string will contain a separate line that looks like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the delimiter is ‘;’.
//Calling Add with a negative number will throw an exception “Negatives not allowed” - and the negative that was passed in. If there are multiple negatives, show all of them in the exception message.
//Numbers greater than 1000 should be ignored, so adding 2 + 1001 + 13 = 15.
//Allow multiple delimiters like this: “//[delim1][delim2]\n” for example “//*%\n1*2%3” should return 6.
