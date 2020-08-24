using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder3 : Adder
    {
        public override double AddTogetherStringList(string listOfNumbers, string divider = ",")
        {
            if (Regex.IsMatch(listOfNumbers,divider + @"\n", RegexOptions.IgnoreCase)) { throw new Exception("The following input is NOT ok: ',newline'"); }
            if (Regex.IsMatch(listOfNumbers, @"\n" + divider, RegexOptions.IgnoreCase)) { throw new Exception("The following input is NOT ok: 'newline,'"); }
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


//Support different single character delimiters(case-insensitive).
