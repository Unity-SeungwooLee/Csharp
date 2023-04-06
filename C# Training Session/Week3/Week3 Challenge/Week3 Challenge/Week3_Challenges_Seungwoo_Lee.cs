// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please write down start number");
string a = Console.ReadLine();
int c = int.Parse(a);

Console.WriteLine("Please write down end number");
string b = Console.ReadLine();
int d = int.Parse(b);

Random random = new Random();
int e = random.Next(c, d);

Console.WriteLine(e);

//-----------------------------------------------------------------------
Console.WriteLine("----------------------------------------");
Console.WriteLine();
Console.WriteLine("----------------------------------------");
//-----------------------------------------------------------------------

Console.WriteLine("Please write down your score.");
string f = Console.ReadLine();
int currentGrade = int.Parse(f);

if(currentGrade>90)
{
    Console.WriteLine("Great Job! It's almost Perfect");
}else if(currentGrade>80)
{
    Console.WriteLine("Try agian, good job");
}else if(currentGrade>70)
{
    Console.WriteLine("Study harder");
}
else
{
    Console.WriteLine("Failed");
}

//-----------------------------------------------------------------------
Console.WriteLine("----------------------------------------");
Console.WriteLine();
Console.WriteLine("----------------------------------------");
//-----------------------------------------------------------------------

Console.WriteLine("Let's do higher or lower guessing game!");
Console.WriteLine("Please type a number between 0 to 100");
int h = random.Next(0,101);

while (true)
{
    string j = Console.ReadLine();
    
    if (j == "quit")
    {
        Console.WriteLine("Game Over");
        break;
    }

    int k = int.Parse(j);

    if (k > h)
    {
        Console.WriteLine("The number is lower");
    }
    else if (k < h)
    {
        Console.WriteLine("The number is bigger");
    }
    else if (k == h)
    {
        Console.WriteLine("That's correct!");
        break;
    }

    Console.WriteLine("Please type another number again 0 to 100");
}