using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the distance in kilometers (km):");
            double km = Convert.ToDouble(Console.ReadLine());

            Class1 converter = new Class1();
            double result = converter.KilometerToMeter(km);

            Console.WriteLine($"The equivalent distance in meters (m) is: {result} m");*/

            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues calculator = new FindValues();
            double area = calculator.FindArea(radius);
            double circumference = calculator.FindCircumference(radius);

            Console.WriteLine($"Area of the circle: {area}");
            Console.WriteLine($"Circumference of the circle: {circumference}");


            Console.ReadKey();
        }
    }
}
