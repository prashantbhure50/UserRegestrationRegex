using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegestrationRegex
{
    class Pattern
    {

        string regex = "^[A-Z][a-zA-Z]{2,}$";
        string emailregex = "^[a-zA-Z]{3}[.]([a-zA-z]{3})[@][a-zA-Z]{2}[.][a-zA-Z]{2}[.]([a-zA-Z]{2})";
        public bool Check(string input)
        {
            return Regex.IsMatch(input, regex);
        }
        public bool EmailCheck(string input)
        {
            return Regex.IsMatch(input, emailregex);
        }
    }
}
