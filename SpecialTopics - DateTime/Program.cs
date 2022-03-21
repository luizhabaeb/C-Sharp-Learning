using System.Globalization;
//// Forma simples:
///
//DateTime d1 = DateTime.Now;                        //NOW > Devolve pra gente o instante atual do sistema
//Console.WriteLine(d1);
//Console.WriteLine(d1.Ticks);


DateTime d1 = new DateTime(2022, 11, 25);    //Instanciei um Date Time 25/11/2022 as 00h - Construtor
Console.WriteLine(d1);

DateTime d2 = new DateTime(2022, 11, 25, 15, 45, 01);  // Constructor
Console.WriteLine(d2);

DateTime d3 = DateTime.Now; //Builder
Console.WriteLine(d3);

DateTime d4 = DateTime.Today;  //Builder
Console.WriteLine(d4);

DateTime d5 = DateTime.UtcNow;  //Builder
Console.WriteLine(d5);

DateTime d6 = DateTime.Parse("2022-03-21");
Console.WriteLine(d6);

DateTime d7 = DateTime.Parse("2022/03/21 13:30:15");
Console.WriteLine(d7);

DateTime d8 = DateTime.Parse("15/08/2000 13:15");
Console.WriteLine(d8);

DateTime d9 = DateTime.ParseExact("1995-07-16", "yyyy-MM-dd", CultureInfo.InvariantCulture);
Console.WriteLine(d9);

DateTime d10 = DateTime.ParseExact("01/10/1997 08:30:15", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
Console.WriteLine(d10);