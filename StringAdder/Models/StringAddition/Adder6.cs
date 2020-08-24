using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder6 : Adder5
    {

        protected override void doubleConverter(double dblConvert, List<double> lstDouble)
        {
            if (dblConvert < 0)
            {
                errorList += "," + dblConvert;
            }
            else if (dblConvert > 1000)
            {
                //ignore 
            }
            else
            {
                lstDouble.Add(dblConvert);
            }
        }


    }
}

//Numbers greater than 1000 should be ignored, so adding 2 + 1001 + 13 = 15.
