using System.Globalization;

Console.WriteLine("Digite o número de pessoas: ");
int numpessoas = int.Parse(Console.ReadLine());

double[] array = new double[numpessoas];   //Para instanciar as caixinhas do Vetor> = new double[quantidade]

for (int i = 0; i < numpessoas; i++)  //enquanto i for menor do que numpessoas - vai executar 0, 1, 2 e no 3 ele para - criando 3 caixas
{
    Console.WriteLine("Digite a altura: ");
    array[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
}

double soma = 0.0;
for (int i = 0; i < numpessoas; i++)
{
    soma += array[i];
}

double media = soma / numpessoas;
Console.WriteLine($"A média de altura dessas pessoas é: {media.ToString("F2")}");