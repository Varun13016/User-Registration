using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Patterns
    {
        public static void LastName(string name)
        {
            string LastName = "^[A-Za-z]\\w{1,10}$$";
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid. Please Enter Last name start with capital letter and maximum 10 charactors");
            }
        }
    }
}