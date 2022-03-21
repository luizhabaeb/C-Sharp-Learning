
TimeSpan t1 = new TimeSpan(); //Construtor padrão
Console.WriteLine(t1);

TimeSpan t2 = new TimeSpan(900000000L); //Construtor
Console.WriteLine(t2);

TimeSpan t3 = new TimeSpan(20, 11, 21); //Construtor
Console.WriteLine(t3);

TimeSpan t4 = new TimeSpan(2, 1, 11, 21); //Construtor
Console.WriteLine(t4);

Console.WriteLine();
Console.WriteLine("-----------------------------------------");
Console.WriteLine();

TimeSpan t6 = TimeSpan.FromDays(1.5); //Método FROM  - Builder - Imprimir 1 dia e meio
Console.WriteLine(t6);

TimeSpan t7 = TimeSpan.FromHours(1.5); //1.5 horas 
Console.WriteLine(t7);

TimeSpan t8 = TimeSpan.FromMinutes(1.5);
Console.WriteLine(t8);

TimeSpan t9 = TimeSpan.FromSeconds(1.5);
Console.WriteLine(t9);

TimeSpan t10 = TimeSpan.FromTicks(900000000);
Console.WriteLine(t10);