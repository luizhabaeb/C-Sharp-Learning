using Primeiro_exe_classe;
using System;

Pessoa p1, p2;
p1 = new Pessoa();
p2 = new Pessoa();


Console.WriteLine("Nome e Idade da primeira pessoa");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Nome e Idade da segunda pessoa");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if (p1.Idade > p2.Idade) 
{
    Console.WriteLine("A pessoa mais velha é o(a) {0} ", p1.Nome);
}
else
{
    Console.WriteLine("A pessoa mais velha é o(a) {0}", p2.Nome);
}
