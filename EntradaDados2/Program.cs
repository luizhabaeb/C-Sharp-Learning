using System;
using System.Globalization; //Para ler . ou , nos números

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler um número inteiro
            int n1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("You've typed the number: " + n1);

            //Ler um caractere
            char carac = char.Parse(Console.ReadLine());
            Console.WriteLine("You've typed the character: " + carac);

            //Ler um número flutuante ou inteiro
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("You've typed another number: " + n2.ToString("F2", CultureInfo.InvariantCulture));

            string[] vetor = Console.ReadLine().Split(' ');
            string name = vetor[0];
            char genre = char.Parse(vetor[1]);
            int age = int.Parse(vetor[2]);   
            double height = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(genre);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}