using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)   //EntryPoint - é nessa função que meu programa INICIA
        {
            //DESCOBRIR O MAIOR DE 3 NÚMEROS - UTILIZANDO CONDICIONAL
            //Console.WriteLine("Type trhee numbers: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine()); 

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("The bigger is: " + n1);
            //}
            //else if (n2 > n3)
            //{
            //    Console.WriteLine("The bigger is: " + n2);
            //}
            //else
            //{
            //    Console.WriteLine("The bigger is: " + n3);
            //}


            // UTILIZANDO UMA FUNÇÃO
            Console.WriteLine("Type trhee numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3); //Vou criar a função 'Maior' para fazer o cálculo pra mim
            Console.WriteLine("The biggest number is: " + resultado);

        }

        static int Maior(int a, int b, int c)
        {
            int M;
            if (a > b && a > c)
            {
                M = a;
            }
            else if (b > c)
            {
                M = b;
            }
            else
            {
                M = c;
            }
            return M;
        }

    }
}