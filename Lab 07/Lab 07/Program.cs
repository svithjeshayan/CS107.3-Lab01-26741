using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];
            int[] vectorSum = new int[size];
            int[] vectorProduct = new int[size];
            int scalarSum = 0;
            int scalarProduct = 0;

            // Input values to the first array
            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < size; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Input values to the second array
            Console.WriteLine("Enter values for the second array:");
            for (int i = 0; i < size; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Calculate scalar sum, vector sum, vector product, and scalar product
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[i];
                vectorSum[i] = array1[i] + array2[i];
                vectorProduct[i] = array1[i] * array2[i];
                scalarProduct += array1[i] * array2[i];
            }

            // Display the results
            Console.WriteLine($"Scalar Sum: {scalarSum}");
            Console.WriteLine("Vector Sum:");
            DisplayArray(vectorSum);
            Console.WriteLine("Vector Product:");
            DisplayArray(vectorProduct);
            Console.WriteLine($"Scalar Product: {scalarProduct}");
        }

        // Helper method to display an array
        static void DisplayArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
