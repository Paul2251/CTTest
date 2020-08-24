using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringAdder.Interfaces.StringAddition
{
    public interface IAdder
    {
        Boolean CheckIsValidListOfNumbers(string listOfNumbers);

        double AddTogetherStringList(string listOfNumbers, string divider = ",");

    }
}
