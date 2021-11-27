using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Patterns
    {
        public static void FirstName(string name)
        {
            string FirstName = "^[A-Z]\\w{1,10}$$";
            Regex regex = new Regex(FirstName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
            }
        }
    }
}