using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Class1
    {
        public double KilometerToMeter(double km)
        {
            Console.WriteLine("Enter the distance in kilometers (km):");
            double km = Convert.ToDouble(Console.ReadLine());

            double meter = km * 1000;
            //Console.WriteLine($"The equivalent distance in meters (m) is: {meter} m");
            return meter;

        }

    }
}
