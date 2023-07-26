using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Batch: ");
            string batch = Console.ReadLine();

            Console.WriteLine("Hi " + name + " you are " + batch + " batch student" );

            //Question 02
            Console.WriteLine("Enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());

            double area = 3.14 * radius * radius;

            Console.WriteLine("The area of the circle is " + area);

            //Question 03
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The sum of the two numbers is " + sum);

            //Question 04
            Console.WriteLine("Enter the salary of the employee:");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the tax rate:");
            double taxRate = double.Parse(Console.ReadLine());

            double tax = salary * (taxRate/100);

            double salaryAfterTax = salary - tax;

            Console.WriteLine("The salary after tax is " + salaryAfterTax);


            Console.ReadKey();

        }
    }
}
