using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many bedrooms do you have in your house?");
            int bed = int.Parse(Console.ReadLine());

            Console.WriteLine("Type a price of any product: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Type your last name, age and height on the same line: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(idade);       
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));  
            
        }
    }
}