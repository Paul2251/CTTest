using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StringAdder.Interfaces.StringAddition;

namespace StringAdder.Controllers
{
    public class HomeController : Controller
    {
        private IAdder _adder;
        private IStringAdditionView _stringAdditionView;

        public HomeController(IAdder adder, IStringAdditionView stringAdditionView)
        {
            _adder = adder;
            _stringAdditionView = stringAdditionView;
        }

        public IActionResult AddStrings()
        {
            _stringAdditionView.ListOfNumbersToAdd = strValue("txtNumbers");
            if (_stringAdditionView.Postback)
            {
                _stringAdditionView.Invalid = !_adder.CheckIsValidListOfNumbers(_stringAdditionView.ListOfNumbersToAdd);
                _stringAdditionView.Message = (_stringAdditionView.Invalid) ? "There was a problem with your list: " + _adder.LastErrorMessage : "";
                _stringAdditionView.Total = (_stringAdditionView.Invalid) ? 0 : _adder.AddTogetherStringList(_stringAdditionView.ListOfNumbersToAdd);
            }
            return View("AddStrings",_stringAdditionView);
        }

        private string strValue(string strKey, string strDefault = "")
        {
            if (Request != null && Request.HasFormContentType && Request.Form != null && Request.Form?.Count() > 0)
            {
                foreach (var f in Request.Form)
                {
                    if (f.Key == strKey) { return f.Value; }
                }
            }
            return strDefault;
        }

    }
}
