using Seg_Exerc_Classe;
using System.Globalization;

Employees p1, p2;

p1 = new Employees();
p2 = new Employees();


Console.WriteLine("First employee's data: ");
Console.Write("Name: ");
p1.Employee = Console.ReadLine();
Console.Write("Salary: ");
p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Second employee's data: ");
Console.Write("Name: ");
p2.Employee = Console.ReadLine();
Console.Write("Salary: ");
p2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double average = (p1.Salary + p2.Salary) / 2.00;
Console.WriteLine("Average wage: " + average.ToString("F2", CultureInfo.InvariantCulture));

