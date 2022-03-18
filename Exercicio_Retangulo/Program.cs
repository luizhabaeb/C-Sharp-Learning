using Exercicio_Retangulo;
using System.Globalization;

Retangulo m;
m = new Retangulo();

Console.WriteLine("Digite a largura e a altura do retângulo: ");
m.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
m.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("ÁREA: " + m.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO: " + m.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL: " + m.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

