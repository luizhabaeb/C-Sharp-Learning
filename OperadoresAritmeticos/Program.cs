using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = (b * b) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);  //se eu quiser a outra raiz da equação, basta trocar o -b "-" Math.Sqrt etc...

            Console.WriteLine(delta);
            Console.WriteLine(x1);




        }
    }
}