using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day22_UserRegistration
{
    public class UC3_ValidEmail
    {
        public static void FirstName()
        {
            string[] arr = { "Navi", "Chitti", "njg", "navitha", "986654" };
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                //IsMatch(String, String, RegexOptions)

                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }
        public static void Lastname()
        {
            string[] arr = { "navi", "chitti", "njg", "navitha", "986654" };
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                //IsMatch(String, String, RegexOptions)
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }
        public static void Email()
        {
            string[] arr = { "navithareddy112@gmail.com", "navithareddy", "b@nr.in", "navitha112@gmail" };
            string pattern = @"^[a-z0-9_\-\.]+[@][a-z]+[\.][a-z]";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", input);
                }
            }
        }
    }
}
