// Fazer um programa para ler um número inteiro N e uma matriz de ordem N, contendo números inteiros.
// Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz




Console.WriteLine("Input how much rows/columns must have on the Matrix: ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];


for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]); //A matriz na posição i,j irá receber o vetor VALUES na posição J
    }
}

Console.WriteLine("Main Diagonal: ");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
    Console.WriteLine();
}

int count = 0;

for (int i = 0; i < n; i++)                   //Estrutura básica para percorrer uma matriz inteira
{
    for (int j = 0;j < n; j++)                //Estrutura básica para percorrer uma matriz inteira
    {
        if (mat[i,j] < 0)                     //se o elemento na matriz for negativo... count ++
        {
            count++;
        }
    }             
}
Console.WriteLine("Negative values: " + count);
