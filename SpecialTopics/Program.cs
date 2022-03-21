//SPECIAL TOPICS IN
//C#

// ** 1. Type Inference **

//if we have this variable:
int a = 10;

//we can do it like that:

var y = 10; //The variable type will be inferred accord to variable inicialization
var z = "Luiz Fernando";

Console.WriteLine(a);
Console.WriteLine(y);
Console.WriteLine(z);


//---------------------------------------//
// ** 2. Alternative sintax: SWITCH-CASE **

//Opcional structure to a lot of Linkeds IF-ELSE > WHEN THE CONDITION INVOLVES TESTING THE VALUE OF A VARIABLE
//Read a integer X
Console.WriteLine("If a week has 7 days, enter some number: ");
int x = int.Parse(Console.ReadLine());
string day;    //if x = 1 then Sunday, x = 2 then Monday, x = 3 then Thursday

if (x == 1)
{
    day = "Sunday";
}
else if (x == 2)
{
    day = "Monday";
}
else if (x == 3)
{
    day = "Tuesday";
}
else if (x == 4)
{
    day = "Wednesday";
}
else if (x == 5)
{
    day = "Thursday";
}
else if (x == 6)
{
    day = "Friday";
}
else if (x == 7)
{
    day = "Saturday";
}
else
{
    day = "Invalid Value";
}

Console.WriteLine($"Today is {day}");



