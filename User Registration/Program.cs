using System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your Mobile Number ex : +91 1234567891 .");
            Console.Write("\n Enter Mobile Number : ");
            string name = Console.ReadLine();
            Patterns.MobileNumber(name);
        }
    }
}
