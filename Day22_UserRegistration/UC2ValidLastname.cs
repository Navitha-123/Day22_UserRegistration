using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day22_UserRegistration
{
    public class UC2ValidLastname
    {
        public static void FirstName()
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
    }
}
