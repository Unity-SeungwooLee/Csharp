using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write down dog1 name");
        string a = Console.ReadLine();

        Console.WriteLine("Please write down dog1 age");
        int b;
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input. Please enter a Number.");
        }

        Console.WriteLine("Please write down dog2 name");
        string c = Console.ReadLine();

        Console.WriteLine("Please write down dog2 age");
        int d;
        while (!int.TryParse(Console.ReadLine(), out d))
        {
            Console.WriteLine("Invalid input. Please enter a Number.");
        }

        Dog dog1 = new Dog(a, b);
        Dog dog2 = new Dog(c, d);
    }
}

public class Dog
{
    public string Dogname;
    public int Dogage;

    public Dog(string name, int age)
    {
        Dogname = name;
        Dogage = age;
        Bark();
        Sit();
        Speak();
    }

    public void Bark()
    {
        Console.WriteLine($"{Dogname} is barking \"Woof Woof\"");
        Console.ReadKey();
    }

    public void Sit()
    {
        Console.WriteLine($"{Dogname} sat in front of you");
        Console.ReadKey();
    }

    public void Speak()
    {
        Console.WriteLine($"I am {Dogage} years old");
        Console.ReadKey();
    }
}