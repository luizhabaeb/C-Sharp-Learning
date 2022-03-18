using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escopo e Inicialização - O Console.WriteLine só lerá as variáveis que estão no mesmo escopo que ele.

            Console.WriteLine("Type the price: ");
            double price = double.Parse(Console.ReadLine());
            double off = 0.0;

            if (price > 100)
            {
                off = price * 0.1;
            }
            
            Console.WriteLine(off);


        }
    }
}