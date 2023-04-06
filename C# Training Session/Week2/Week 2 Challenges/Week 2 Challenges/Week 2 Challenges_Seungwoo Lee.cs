// See https://aka.ms/new-console-template for more information

//Week 2 Challenge1//
Console.WriteLine("Please input the number with decimal");

string a = Console.ReadLine();

float b = (float.Parse(a));

Console.WriteLine("After Math.Round()");
Console.WriteLine(Math.Round(b));



//Week 2 Challenge2//
Console.WriteLine("Please input the number triangle base");
string c = Console.ReadLine();

Console.WriteLine("Please input the number triangle height");
string d = Console.ReadLine();

double e = 0.5 * double.Parse(c) * double.Parse(d);
Console.WriteLine(e);
