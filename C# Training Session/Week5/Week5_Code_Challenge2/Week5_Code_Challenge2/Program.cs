/* Week5 Code Challenge2
Create a name storage system using Lists and Loops.

Program asks user what name they want to store.
User enters the name and it's stored in a variable.
Add that variable to a list of names.
Loop this until the user enters "quit"
Once this happens, use a loop to iterate through all the elements of the List and write each name to the console.
*/

Console.WriteLine("Please write names what you want to store.");


List<string> names = new List<string>();

string a;


do
{
    a = Console.ReadLine();

    if (a != "quit")
    {
        names.Add(a);
    }
}
while (a != "quit");

Console.WriteLine("\nAll names entered:");

foreach (string name in names)
{
    Console.WriteLine(name);
}


/*Chat GPT Answered
using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    List<string> names = new List<string>();
    string input;

    do 
    {
      Console.Write("Enter a name (or 'quit' to exit): ");
      input = Console.ReadLine();

      if (input != "quit") 
      {
        names.Add(input);
      }
    } 
    
    while (input != "quit");

    Console.WriteLine("\nAll names entered:");

    foreach (string name in names) 
    {
      Console.WriteLine(name);
    }
  }
}
*/