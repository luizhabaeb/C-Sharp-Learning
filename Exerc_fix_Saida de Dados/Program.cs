using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computer";
            string product2 = "Desktop";

            byte age = 30;
            int code = 5290;
            char genre = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products: ");
            Console.WriteLine("{0} wich price is {1:F2}", product1, price1);
            Console.WriteLine("{0} wich price is {1:F2}", product2, price2);
            Console.WriteLine();
            Console.WriteLine("Register: {0} years old, code {1} and genre {2}", age, code, genre);
            Console.WriteLine();
            Console.WriteLine("Measure w/ eight decimal places: {0:F8}", measure);
            Console.WriteLine("Rounded (w/ trhee decimal places): {0:F3}", measure);
            Console.WriteLine("Decimal Separator - Invariant Culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));
           
        }
    }
}