﻿using Exerc_Salario;
using System.Globalization;

Funcionario f;

f = new Funcionario();

Console.Write("Nome: ");
f.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("Funcionário: " + f);
Console.WriteLine();

Console.Write("Digite a porcentagem de aumento do salário: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcentagem);

Console.WriteLine("Dados atualizados: " + f);



