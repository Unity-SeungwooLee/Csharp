// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Challengs1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Please wirte down a number A");
            string c = Console.ReadLine();
            int a = int.Parse(c);

            Console.WriteLine("Please wirte down a number B");
            string d = Console.ReadLine();
            int b = int.Parse(d);

            int z = Plus(a, b);
            Console.WriteLine($"The result is {z}");
        }
        static int Plus(int c, int d)
        {
            return c + d;
        }
    }
}