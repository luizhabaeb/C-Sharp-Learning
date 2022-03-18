using Arrays_2;
using System.Globalization;


Console.WriteLine("Digite a quantidade de produtos adquiridos: ");
int qnt = int.Parse(Console.ReadLine());

Produto[] array = new Produto[qnt];

for (int i = 0; i < qnt; i++)
{
    Console.WriteLine("Digite o produto e o preço: ");
    string nome = Console.ReadLine();
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    array[i] = new Produto { NomeProd = nome, Preco = preco };
}

double soma = 0;

for (int i = 0; i < qnt; i++)
{
    soma += array[i].Preco;
}

double media = soma / qnt;
Console.WriteLine("Média dos preços: " + media.ToString("F2"));