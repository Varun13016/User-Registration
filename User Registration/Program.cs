using System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your Password ex : X@xxxxx123");
            Console.Write("\n Enter Password : ");
            string name = Console.ReadLine();
            Patterns.Password(name);
        }
    }
}
