using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 04

            Myclass myClass = new Myclass();
            myClass.CallSayHello();

            /*Explaination: Beacause in private method can only access by the same class other class can't access the private sector but 
             * using piblic method we can access the particular function*/

            //Question 05
            Helper helper = new Helper();

            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integer values:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int min = helper.FindMinimum(numbers);
            int max = helper.FindMaximum(numbers);
            double avg = helper.FindAverage(numbers);

            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Average value: {avg:F2}");

            int[] reversedArray = helper.ReverseArray(numbers);
            Console.WriteLine("Reversed order of values:");
            foreach (int num in reversedArray)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();

        }
    }
}
