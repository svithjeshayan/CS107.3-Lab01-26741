using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            Class1 helper = new Class1();
            int[] array = helper.CreateAndInputArray(size);

            Console.WriteLine("Values inside the array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
