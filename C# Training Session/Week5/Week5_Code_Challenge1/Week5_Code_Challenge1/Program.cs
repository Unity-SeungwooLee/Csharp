/*Create an array replicator

Create an array with the length of 5
Use a for loop to ask user for 5 values to store in the array.
Make a second array of 5.
Use a Loop to iterate through the first array and copy the values into the second array.
Use a another loop to write the values of both arrays to the console, both arrays should have the same values.
*/


int[] myNumbers = new int[5];
int[] myNumbers2 = new int[5];

for (int i = 0; i < myNumbers.Length; i++)
{
    myNumbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Numbers:");

for (int i = 0; i < myNumbers.Length; i++)
{
    Console.Write(myNumbers[i] + " ");
}


for (int i = 0; i < myNumbers.Length; i++)
{
    myNumbers2[i] = myNumbers[i];
}

Console.WriteLine("\n------------------------------");

for (int i = 0; i < myNumbers2.Length; i++)
{
    Console.Write(myNumbers2[i] + " ");
}



/* Chat GPT Answered
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];

        // ask user for input and store in first array
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write("Enter a number: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        // copy values from first array to second array
        for (int i = 0; i < array1.Length; i++)
        {
            array2[i] = array1[i];
        }

        // print values of both arrays horizontally
        Console.Write("Array 1: ");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write(array1[i] + " ");
        }

        Console.Write("\nArray 2: ");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i] + " ");
        }
    }
}
*/