﻿using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Patterns
    {
        public static void Password(string name)
        {
            string Password = "^[A-Z][A-Za-z0-9]{7}";
            Regex regex = new Regex(Password);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is Valid Password");
            }
            else
            {
                Console.WriteLine(name + " is invalid.");
            }
        }
    }
}