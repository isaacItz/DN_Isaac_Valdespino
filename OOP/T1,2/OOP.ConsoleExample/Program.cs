using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Que animal desea");
                string tipoAnimal = Console.ReadLine().ToLower();
                Animal animal = null;

                switch (tipoAnimal)
                {
                    case "vaca":
                        animal = new Cow();
                        break;
                    case "leon":
                        animal = new Lion();
                        break;
                    case "puerco":
                        animal = new Pig();
                        break;
                    case "elefante":
                        animal = new Elephant();
                        break;
                    case "gato":
                        animal = new Cat();
                        break;
                    case "perro":
                        animal = new Dog();
                        break;
                    default:
                        Console.WriteLine("animal no encontrado");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                if (animal != null)
                {
                    animal.AnimalSound();
                }
                else
                {
                    break;
                }

            }
        }
    }
}
