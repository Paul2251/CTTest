using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder7 : Adder6
    {

        public override List<string> SplitUpListIntoNumberStrings(string listOfNumbers, string divider = ",")
        {
            if (Regex.IsMatch(listOfNumbers, @"^//(.)+\n"))
            {
                string newDivider = Regex.Match(listOfNumbers, @"^//(.)+\n").ToString();
                newDivider = Regex.Replace(Regex.Replace(newDivider, "^//", ""), "\n", "");
                listOfNumbers = Regex.Replace(listOfNumbers, @"^//(.)+\n", "");
                //build or regex
                divider = "[" + newDivider + "]";
            }
            return base.SplitUpListIntoNumberStrings(listOfNumbers, divider);
        }


    }
}

//Allow multiple delimiters like this: “//[delim1][delim2]\n” for example “//*%\n1*2%3” should return 6.
