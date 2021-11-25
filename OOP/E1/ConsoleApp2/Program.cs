using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("que tipo de vehiculo quieres?");
                string vehicle = Console.ReadLine().ToLower();

                switch(vehicle)
                {
                    case "carro":
                        Car car = new Car();
                        car.MakeASound();
                        break;

                    case "camion":
                        new Truck().MakeASound();
                        break;

                    case "tren":
                        new Train().MakeASound();
                        break;

                    default:
                        Console.WriteLine("Vehiculo no identificado");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                if (vehicle.Equals("salir"))
                    break;
            }
        }
    }
}
