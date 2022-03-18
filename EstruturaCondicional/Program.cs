using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            
            Console.WriteLine("Type a integer number: ");
            n1 = int.Parse(Console.ReadLine());
                        
            if (n1 % 2 == 0)
            {
                Console.WriteLine("Pair!");
            }
            else
            {
                Console.WriteLine("Odd!");
            }
                




        }
    }
}