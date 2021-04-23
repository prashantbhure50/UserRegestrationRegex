using System;

namespace UserRegestrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Welcome to User Registration Problem");
            bool firstName = pattern.Check("Prashant");
            Console.WriteLine("FirstName " + firstName);
            bool lastName = pattern.Check("Prashant");
            Console.WriteLine("LastName " + lastName);
            bool email = pattern.EmailCheck("abc.xyz@bl.co.in");
            Console.WriteLine("Email " + email);
            bool mobile = pattern.MobileCheck("91 9876543210");
            Console.WriteLine("Mobile " + mobile);
        }
    }
}
