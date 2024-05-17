//6.Design a class called Circle with a read-only property/ Write-Only Property Radius. Initialize the radius during object creation and calculate the area of the circle using a method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class Circle
    {
        const double pi = 3.14;
        private double radius;

        public double Radius
        {
            set => radius = value;
        }

        public double Area()
        {
            double area = pi * radius * radius;
            return area;
        }
    }
    internal class question6
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Circle c1 = new Circle();
            Console.Write("Enter the radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            c1.Radius = r;
            Console.WriteLine($"The area of circle with radius of {r}unit is: {c1.Area()} sq.unit");
            Console.ReadKey();
        }
    }
}
