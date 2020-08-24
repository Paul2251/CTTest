using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringAdder.Interfaces.StringAddition
{
    public interface IStringAdditionView
    {
        string ListOfNumbersToAdd { get; set; }
        string Message { get; set; }
        Boolean Invalid { get; set; }
        Boolean Postback { get; set; }
        double Total { get; set; }

    }
}
