using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", "V8");
            Car car2 = new Car("Audi", "V6");
            
            Car car3 = new Car();
            car3.CarName = "Honda";
            car3.InstallEngine("V8");
            car3.Vroom();

            Car car4 = new Car("Toyota", "V6", 4);

            /*car1.Vroom();
            Random rng =new Random();
            rng = new Random();
            */

            //car1.CarName = "Mercedes";
            //car2.CarName = "Audi";

            //car1.Vroom();
            //car1.IntallEngine("V8");

            //car2.Vroom();
            //car2.IntallEngine("V6");

            Player player1 = new Player();
            Player player2 = new Player();
        }

    }

    public class Car
    {
        public string CarName;
        public int doorCount;
        public string engineType;

        public Car()
        {
            Console.WriteLine("No parameters were given, this is blank car");
        }
        public Car(string name, string _engineType)
        {
            CarName = name;
            InstallEngine(_engineType);
            Vroom();
        }

        public Car(string name, string _engineType, int doorCount)
        {
            Console.WriteLine("Executed 4 door code");
            Console.ReadKey();
        }

        public void Vroom()
        {
            Console.WriteLine($"The {CarName} engines have started! VROOOOOOOM!");
            Console.ReadKey();
        }

        public void InstallEngine(string _engineType)
        {
            engineType = _engineType;
            Console.WriteLine(engineType + " Was installed in the " + CarName);
            Console.ReadKey();
        }
    }

    public class Player
    {
        public int id;
        public Player() //This is a constructor
        {
            Random rnd = new Random();
            id = rnd.Next();
            Console.WriteLine(id);
            Console.ReadKey();
        }
    }
}