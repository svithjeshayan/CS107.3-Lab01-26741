using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Enter Number 1 ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 1 ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine("The sum of the two numbers is: {0}", sum);

            //Qustion 2
            Console.WriteLine("Enter Number 1 ");
            float number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 1 ");
            float number2 = Convert.ToInt32(Console.ReadLine());

            float sum = number1 + number2;
            float difference = number1 - number2;
            float product = number1 * number2;
            float quotient = number1 / number2;

            Console.WriteLine("The sum of the two numbers is: "+sum);
            Console.WriteLine("The difference of the two numbers is: "+difference);
            Console.WriteLine("The product of the two numbers is: "+product);
            Console.WriteLine("The quotient of the two numbers is: "+quotient);

            //Question 3
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = 3.14 * radius * radius;
            double circumference = 2 * 3.14 * radius;

            Console.WriteLine($"Area of the circle: {area}");
            Console.WriteLine($"Circumference of the circle: {circumference}");

            //Question 4
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            //Question 5
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter number {i}:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }

            }

                Console.ReadKey();
        }
    }
}
