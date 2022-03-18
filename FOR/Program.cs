using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you'll type?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Value: #{0}: ", i);
                int value = int.Parse(Console.ReadLine());
                soma = soma + value;
            }
            Console.WriteLine("Soma = " + soma);

        }
    }
}