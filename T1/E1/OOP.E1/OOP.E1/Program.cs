using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Solution E1");

            while (true)
            {
                Console.WriteLine("Write car, airplane or train to play, it sound:");
                string option = Console.ReadLine().ToLower();
                Transport transporte = null;

                switch (option)
                {
                    case "car":
                        transporte = new Car();
                        break;

                    case "airplane":
                        transporte = new Airplane();

                        break;

                    case "train":
                        transporte = new Train();
                        break;

                    default:
                        Console.WriteLine("Incorrect option...");
                        System.Threading.Thread.Sleep(500);
                        break;
                }

                if (transporte != null)
                {
                    transporte.MakeSound();
                }

                
            }

            Console.ReadKey();

        }
    }
}
