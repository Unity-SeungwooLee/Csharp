// See https://aka.ms/new-console-template for more information


void WriteText(string newText)
{
    newText = "Joe";
    Console.WriteLine(newText);
}
string name = "Larry";
WriteText(name);
Console.WriteLine(name);


string str = "My Word";

void ChangeWord(ref string newStr)
{
    newStr = "You changed my word!!";
}
ChangeWord(ref str);
Console.WriteLine(str);

string str1 = "";
Random random = new Random();
random.Next(10,10);

int Next()
{
    return 0;
}

int Next(int x)
{

}

/*
string str1;
void OutChangeWord(out string str1)
{
    str1 = "My word has been exported";
}
OutChangeWord(out str1);
Console.WriteLine(str1);
*/

/*
string str1 = ""; ;
bool CheckForLarry(string str1)
{
    if (str1 == "Larry")
    {
        return true;
    }
    else
    {
        return false;
    }
}

CheckForLarry(str1);
Console.WriteLine(str1);
*/

/*
string str1;
int OutChangeWord(out string str1)
{
    str1 = "My word has been exported";
    return 0;
}
OutChangeWord(out str1);
Console.WriteLine(str1);
*/
/*
string str2;
bool Raycast()
{
    return true;
}
*/

Random rng = new Random();
    rng.Next(10);


int day = 2;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("None");
        break;
}
/*
string name = "Larry";
switch (name)
{
    case "Larry":
        break;
    case "John":
        break;
    default:
        break;
}
*/