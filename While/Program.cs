using System;
using System.Globalization;

namespace Coursè
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any number: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n1 >= 0)
            {
                double root = Math.Sqrt(n1);
                Console.WriteLine(root.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Type another number: ");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
           
            Console.WriteLine("Negative number.");

        }
    }
}