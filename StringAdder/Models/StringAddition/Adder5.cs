using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder5 : Adder4
    {
        protected string errorList = "";

        public override List<double> ConvertNumberStringsToDouble(List<string> lstNumbers)
        {
            errorList = "";
            List<double> lstDouble = new List<double>();
            foreach (string num in lstNumbers)
            {
                doubleConverter(Convert.ToDouble(num), lstDouble);
            }
            if (!String.IsNullOrEmpty(errorList)) { throw new Exception("Negatives not allowed: " + errorList); }
            return lstDouble;
        }

        protected virtual void doubleConverter(double dblConvert, List<double> lstDouble)
        {
            if (dblConvert < 0)
            {
                errorList += "," + dblConvert;
            }
            else
            {
                lstDouble.Add(dblConvert);
            }
        }


    }
}

//Calling Add with a negative number will throw an exception “Negatives not allowed” - and the negative that was passed in. If there are multiple negatives, show all of them in the exception message.
