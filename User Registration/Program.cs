﻿using System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your name using 1st character should be Capital ");
            Console.Write("\n Enter Last Name : ");
            string name = Console.ReadLine();
            Patterns.LastName(name);
        }
    }
}
