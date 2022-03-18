using System;  // referência para o namespace System

namespace PrimeiroExe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; //guarda se um procedimento está completo ou não
            char genero = 'F'; //guarda um caractere unicode
            char unicode = '\u0041'; //letra A unicode
            float x1 = 4.5f;
            double x2 = 4.5;
            byte x = 126;
            string palavra = "Entendendo tipos de dados.";
            object obj1 = 4.5f; //pode receber qualquer coisa
            object obj2 = "Luiz Fernando";

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(palavra);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(unicode);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(x);
        }
    }
}