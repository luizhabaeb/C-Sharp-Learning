

double? x = null;
double? y = 10.0;

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault()); //Pega o valor que tem ou o valor padrão

Console.WriteLine();

Console.WriteLine(x.HasValue); //Vai dizer, em V ou F, se dentro da variável existe ou não o valor
Console.WriteLine(y.HasValue); //Vai dizer, em V ou F, se dentro da variável existe ou não o valor

Console.WriteLine();

if (x.HasValue)
{
    Console.WriteLine(x.Value);  //Pega o valor - Caso seja null, lança uma exceção (da um erro)
}
else
{
    Console.WriteLine("X is null.");
}


if (y.HasValue)
{
    Console.WriteLine(y.Value);  //Pega o valor - Caso seja null, lança uma exceção (da um erro)
}
else
{
    Console.WriteLine($"Y is {y}");
}
