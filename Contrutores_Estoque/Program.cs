using System.Globalization;
using Estoque;


Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco);

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


