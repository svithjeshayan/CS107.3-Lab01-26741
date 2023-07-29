using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
