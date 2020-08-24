using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringAdder.Interfaces.StringAddition;
using System.Text.RegularExpressions;

namespace StringAdder.Models.StringAddition
{
    public class Adder : IAdder
    {
        public string LastErrorMessage { get; set; }

        public Boolean CheckIsValidListOfNumbers(string listOfNumbers)
        {
            try
            {
                var dblResult = AddTogetherStringList(listOfNumbers);
                return true;
            }
            catch(Exception e)
            {
                LastErrorMessage = e.Message;
                return false;
            }
        }

        public virtual double AddTogetherStringList(string listOfNumbers, string divider = ",")
        {
            listOfNumbers = Regex.Replace(listOfNumbers, @"\r", "");
            List<string> lstNumberStrings = SplitUpListIntoNumberStrings(listOfNumbers, divider);
            List<double> lstDoubles = ConvertNumberStringsToDouble(lstNumberStrings);
            return SumUpListOfDoubles(lstDoubles);
        }

        public virtual List<string> SplitUpListIntoNumberStrings(string listOfNumbers, string divider = ",")
        {
            return Regex.Split(listOfNumbers, divider,
                                          RegexOptions.IgnoreCase,
                                          TimeSpan.FromMilliseconds(1500)).ToList();
        }

        public virtual List<double> ConvertNumberStringsToDouble(List<string> lstNumbers)
        {
            List<double> lstDouble = lstNumbers.Select(x => Convert.ToDouble(x)).ToList();
            return lstDouble;
        }

        protected double SumUpListOfDoubles(List<double> lstDouble)
        {
            double dblResult = 0;
            lstDouble.ForEach(x => dblResult += x);
            return dblResult;
        }

    }
}


//Allow the Add method to handle an unknown amount of numbers.
