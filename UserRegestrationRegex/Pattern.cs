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
        string mobileregex = "^[1-9]{2,2}[ ][0-9]{10}$";
        string passwordemailregex = "(?=.*[0-9])(?=.*[A-Z]).{8,}$";
        public bool Check(string input)
        {
            return Regex.IsMatch(input, regex);
        }
        public bool EmailCheck(string input)
        {
            return Regex.IsMatch(input, emailregex);
        }
        public bool MobileCheck(string input)
        {
            return Regex.IsMatch(input, mobileregex);
        }
        public bool PasswordEmailCheck(string input)
        {
            return Regex.IsMatch(input, passwordemailregex);
        }
    }
}
