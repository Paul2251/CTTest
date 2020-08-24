using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringAdder.Interfaces.StringAddition;

namespace StringAdder.Models.StringAddition
{
    public class Adder : IAdder
    {

        public Boolean CheckIsValidListOfNumbers(string listOfNumbers)
        {
            try
            {
                var dblResult = AddTogetherStringList(listOfNumbers);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual double AddTogetherStringList(string listOfNumbers, string divider = ",")
        {
            double dblResult = 0;
            string[] arrNumbers = listOfNumbers.Split(divider);
            arrNumbers.ToList().ForEach(x => dblResult += Convert.ToDouble(x));
            return dblResult;
        }
    }
}


//Allow the Add method to handle an unknown amount of numbers.
