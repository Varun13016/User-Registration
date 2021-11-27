using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Patterns
    {
        public static void Email(string name)
        {
            string Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(Email);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid MailID");
            }
            else
            {
                Console.WriteLine(name + " is invalid.");
            }
        }
    }
}