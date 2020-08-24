using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder3 : Adder2
    {
        public override double AddTogetherStringList(string listOfNumbers, string divider = ",")
        {
            return base.AddTogetherStringList(listOfNumbers, divider);
        }


    }
}


//Support different single character delimiters(case-insensitive).
