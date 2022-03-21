//Ternary Conditional Expression

//It's a opcional structure to If-Else, when you need to decide a VALUE based on a condition.
using System.Globalization;
//SINTAX:
// *** ( condition ) ? value_if_true : value_if_false ***

//Example:

// (2 > 4) ? 50 : 80;  =  80  //the result will be 80 because the condition is false.
// (10 != 3) ? "Luiz" : "Alex" => "Luiz"  //the condition between parentesis is TRUE.

Console.WriteLine("Type any prince of anything: ");
double price = double.Parse(Console.ReadLine());
double discount = (price < 25.50) ? price * 0.1 : price * 0.2;

double finalprice = (price - discount);
Console.WriteLine($"You gotta pay {finalprice.ToString("F2")} dollars.");















//Console.WriteLine("Type any price of anything: ");
//double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//double discount;

//if (price < 25.50)
//{
//    discount = price * 0.1;
//}
//else
//{
//    discount = price * 0.2;
//}



