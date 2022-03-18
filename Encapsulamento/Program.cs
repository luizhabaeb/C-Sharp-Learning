using System.Globalization;
using Estoque;

Produto p = new Produto("TV", 500.00, 10);

p.Nome = "TV Smart";

Console.WriteLine(p.Nome);
Console.WriteLine(p.Preco);
Console.WriteLine(p.Quantidade);

