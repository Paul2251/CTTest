using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StringAdder.Interfaces.StringAddition;

namespace StringAdder.Models.StringAddition
{
    public class StringAdditionView : IStringAdditionView
    {
        public string ListOfNumbersToAdd { get; set; }
        public double Total { get; set; }
        public string Message { get; set; }
        public Boolean Invalid { get; set; }
        public Boolean Postback
        {
            get
            {
                return !String.IsNullOrEmpty(ListOfNumbersToAdd);
            }
            set
            {

            }
        }

    }
}
