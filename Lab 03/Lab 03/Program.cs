using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            //Question 2
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine().ToLower();

            int vowelCount = 0;
            foreach (char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Number of vowels: {vowelCount}");

            //Question 3
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine($"Sum of the digits: {sum}");

            //Question 4
            Console.WriteLine("Enter a positive integer:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of odd numbers from 1 to {n}: {sum}");

        }
    }
}
