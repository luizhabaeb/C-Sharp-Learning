using Exercicios_Fixacao_Classes_Prop_Constr;
using System.Globalization;

Banco conta;

Console.Write("Entre com o número da conta: ");
int numconta = int.Parse(Console.ReadLine());
Console.Write("Titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char resposta = char.Parse(Console.ReadLine());

if (resposta == 's' || resposta == 'S')
{
    Console.Write("Entre com o valor do depósito inicial: ");
    double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new Banco(numconta, titular, depInicial);
}
else
{
    conta = new Banco(numconta, titular);
}

Console.WriteLine();
Console.WriteLine("Dados do Usuário: ");
Console.WriteLine(conta);
Console.WriteLine();

Console.WriteLine();
Console.Write("Entre com um valor para depósito: ");
double add = double.Parse(Console.ReadLine());
conta.AdicionarDinheiro(add);
Console.WriteLine();
Console.WriteLine("Dados Atualizados: ");
Console.WriteLine(conta.ToString());

Console.WriteLine();
Console.Write("Entre com um valor para saque: ");
double rmv = double.Parse(Console.ReadLine());
conta.Saque(rmv);
Console.WriteLine();
Console.WriteLine("Dados Atualizados: ");
Console.WriteLine(conta.ToString());