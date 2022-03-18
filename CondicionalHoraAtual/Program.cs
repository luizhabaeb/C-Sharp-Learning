using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it?");
            int hour = int.Parse(Console.ReadLine());

            if (hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }
            
        }
    }
}