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
        }
    }
}
