using System.Globalization;
using Estoque;

Produto p = new Produto();


Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Dados do Produto: " + p);

Console.WriteLine();
Console.Write("Digite a quantidade de produtos adicionados ao estoque: ");
int add = int.Parse(Console.ReadLine());    
p.AdicionarProdutos(add);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite a quantidade de produtos removidos do estoque: ");
int rmv = int.Parse(Console.ReadLine());
p.RemoverProdutos(rmv);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);


