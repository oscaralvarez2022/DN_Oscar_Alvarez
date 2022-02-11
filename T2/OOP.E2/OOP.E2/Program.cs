using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte;
     
namespace OOP.E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Solution E2" +
                "");
            Console.WriteLine("Bucle de 10");

            for (var x=1;x<=10;x++) 
            {
                Console.WriteLine("\n" + x+". Escribe automovil, camion o tren para escuchar su sonido:");
                string option = Console.ReadLine().ToLower();
                vehículo vehículo = null;

                switch (option)
                {
                    case "automovil":
                        vehículo = new automóvil();
                        break;

                    case "camion":
                        vehículo = new camión();

                        break;

                    case "tren":
                        vehículo = new tren();
                        break;

                    default:
                        Console.WriteLine("Incorrect option...");
                        System.Threading.Thread.Sleep(500);
                        break;
                }

                if (vehículo != null)
                {
                    vehículo.hacerSonido();
                }


            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
