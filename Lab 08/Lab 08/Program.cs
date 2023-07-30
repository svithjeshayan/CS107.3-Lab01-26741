using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            // Call methods from the Animal and Dog classes
            animal.DisplayAnimalInfo();
            dog.DisplayDogInfo();

            Console.ReadKey();
        }
    }
}
