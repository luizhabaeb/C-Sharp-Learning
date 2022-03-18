using System;
using System.Globalization;    //para usar o CultureInfo.InvariantCulture

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'M';
            int idade = 25;
            double saldo = 10.35484;
            string nome = "Maria";

            Console.WriteLine("Seu gênero é: {0}", genero);
            Console.WriteLine("Você tem {0} anos", idade);
            Console.WriteLine("Seu saldo é {0} reais", saldo.ToString("F2")); //F2 delimita o numero de casas decimais (2 casa decimais)... F3 > 3 casas, assim por diante 
            Console.WriteLine("Seu saldo é {0} reais", saldo.ToString("F3", CultureInfo.InvariantCulture)); //Imprimir com o . - Esse invariantculture desconsidera qualquer formatação tipica de um pais
            Console.WriteLine("E, por fim, seu nome é {0}", nome);
        }

    }

}