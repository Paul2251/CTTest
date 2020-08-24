﻿using System;
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

