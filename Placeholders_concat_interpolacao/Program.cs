using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 32;
            double balance = 10.35784;
            string name = "Luiz";

            Console.WriteLine("{0} tem {1} anos e seu saldo é de {2:F2} reais.", name, age, balance); //técnica placeholder
            Console.WriteLine($"{name} tem {age} anos e seu saldo é de {balance:F2} reais"); //INTERPOLAÇÃO
            Console.WriteLine(name + " tem " + age + " anos e seu saldo é de " + balance.ToString("F2", CultureInfo.InvariantCulture) + " reais "); //concatenação

        }
    }
}