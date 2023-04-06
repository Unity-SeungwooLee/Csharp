// See https://aka.ms/new-console-template for more information

Console.WriteLine("--------------------------------");
Console.WriteLine("Here is the list, please write down the number what cost do you want");
Console.WriteLine("The following prodects are available:\n\n1-Tape\n\n2-Candles\n\n3-Bottled Water\n\n4-Apples\n\nWhich product number do you want the price of?\n\n(If you don't want to know, just type \"quit\")");

while (true)
{
    string a = Console.ReadLine();

    if (a == "quit")
    {
        Console.WriteLine("Thank you");
        break;
    }

    int b = int.Parse(a);

    switch (b)
    {
        case 1:
            Console.WriteLine("Tapes cost 1 dollar");
            break;

        case 2:
            Console.WriteLine("Candles cost 2 dollars");
            break;

        case 3:
            Console.WriteLine("Bottled Water costs 4 dollars");
            break;

        case 4:
            Console.WriteLine("Apples cost 6 dollars");
            break;
        
        default:
            Console.WriteLine("Please type correct number");
            break;
    }
}