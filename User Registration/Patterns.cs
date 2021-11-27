using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Patterns
    {
        public static void MobileNumber(string name)
        {
            string MobileNumber = "(0|91)?[ ][6-9][0-9]{9}";
            Regex regex = new Regex(MobileNumber);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is Valid Number");
            }
            else
            {
                Console.WriteLine(name + " is invalid");
            }
        }
    }
}