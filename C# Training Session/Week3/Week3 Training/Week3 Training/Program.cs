// See https://aka.ms/new-console-template for more information
/*
Random rnd = new Random();
int a = rnd.Next();
int b = rnd.Next(100);
int c = rnd.Next(25, 51);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

double d = rnd.NextDouble();
Console.WriteLine(d * 100);


int id = 3;
if (id == 12)
{
    Console.WriteLine("This is the correct user");
}
else
{
    Console.WriteLine("This is the wrong user");
}


int ie = 3;

if (ie == 13)
{
    Console.WriteLine("This is Larry");
}
else if (ie == 14)
{
    Console.WriteLine("This is Johns");
} else
{
    Console.WriteLine("This is not user");
}

int iid = 12;
string name = "Larry";
if (iid == 12 && name == "Larry") ;
{
    Console.WriteLine("This is the right person");
}
*/
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 100; i > 0; i--)
{
    Console.WriteLine(i);
    if(i == 50)
    {
        break;
    }
}

Console.WriteLine("Were done with the loop");
