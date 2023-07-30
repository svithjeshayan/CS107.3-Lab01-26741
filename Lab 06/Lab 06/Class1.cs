using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Class1
    {
        public int[] CreateAndInputArray(int size)
        {
            int[] array = new int[size * 2];

            Console.WriteLine("Enter the values for the array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1}. ");
                array[i * 2] = int.Parse(Console.ReadLine());
                array[i * 2 + 1] = 0;
            }

            return array;
        }
    }
}
