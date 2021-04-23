using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegestrationRegex
{
    class Pattern
    {

        string regex = "^[A-Z][a-zA-Z]{2,}$";
        public bool Check(string input)
        {
            return Regex.IsMatch(input, regex);
        }
    }
}
