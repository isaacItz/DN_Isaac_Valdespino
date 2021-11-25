using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaEncapsulacion1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("que tipo de vehiculo quieres?");
                string vehicleType = Console.ReadLine().ToLower();
                Vehicle vehicle = null;

                switch (vehicleType)
                {
                    case "carro":
                        vehicle = new Car();
                        break;

                    case "camion":
                        vehicle = new Truck();
                        break;

                    case "tren":
                        vehicle = new Train();
                        break;

                    default:
                        Console.WriteLine("Vehiculo no identificado");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                if (vehicle != null)
                {
                    vehicle.MakeASound();
                }
                if (vehicleType.Equals("salir"))
                {
                    break;
                }
            }
        }
    }
}
