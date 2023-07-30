using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the operation you want to perform:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division \n");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            CalculateValues calculator = new CalculateValues();

            switch (choice)
            {
                case 1:
                    result = calculator.Addition(num1, num2);
                    break;
                case 2:
                    result = calculator.Subtraction(num1, num2);
                    break;
                case 3:
                    result = calculator.Multiplication(num1, num2);
                    break;
                case 4:
                    result = calculator.Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine("Your answer is: " + result);

            Console.ReadKey();
        }
    }
}
