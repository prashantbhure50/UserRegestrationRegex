using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegestrationRegex
{
    class Pattern
    {

        private string firstRegex = "^[A-Z][a-zA-Z]{2,}$";
        private string lastRegex = "^[A-Z][a-zA-Z]{2,}$";
        private string emailRegex = "^[a-zA-Z]{3}[.]([a-zA-z]{3})[@][a-zA-Z]{2}[.][a-zA-Z]{2}[.]([a-zA-Z]{2})";
        private string mobileRegex = "^[1-9]{2,2}[ ][0-9]{10}$";
        private string passwordEmailRegex = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";
        public bool firstNameCheck(string input)
        {
            return Regex.IsMatch(input, firstRegex);
        }
        public bool lastNameCheck(string input)
        {
            return Regex.IsMatch(input, lastRegex); 
        }
        public bool EmailCheck(string input)
        {
            return Regex.IsMatch(input, emailRegex);
        }
        public bool MobileCheck(string input)
        {
            return Regex.IsMatch(input, mobileRegex);
        }
        public bool PasswordEmailCheck(string input)
        {
            return Regex.IsMatch(input, passwordEmailRegex);
        }
    }
}
