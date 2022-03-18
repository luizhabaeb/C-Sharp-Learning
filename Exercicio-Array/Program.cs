using Exercicio_Array;

Students[] array = new Students[10];

Console.WriteLine("How many rooms will be rented? ");
int qnt = int.Parse(Console.ReadLine());

for (int i = 1; i <= qnt; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Rent #{i}:");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room number: ");
    int room = int.Parse(Console.ReadLine());
    array[room] = new Students(name, email);
}

Console.WriteLine();
Console.WriteLine("Busy rooms: ");
for (int i = 0; i < 10; i++)
{
    if (array[i] != null)
    {
        Console.WriteLine(i + ": " + array[i]);
    }
}