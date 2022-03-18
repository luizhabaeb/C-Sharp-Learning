using Exercicio_MembroEstatico_IOF;
using System.Globalization;

Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você comprará? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double resultado = ConversorDeMoeda.DolarReal(quantia, cotacao);




Console.Write("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));


