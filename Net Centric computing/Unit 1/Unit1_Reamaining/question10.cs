//10.Q: Create an abstract class "Shape" with an abstract method "CalculateArea".Implement derived classes like "Circle" and "Rectangle" that provide their own implementations of the "CalculateArea" method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Reamaining
{
    abstract class Shape
    {
        public const double PI = 3.14f;
        public double radius;
        public double height;
        public double width;
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return PI * radius * radius;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(double length,double breadth)
        {
            this.height = length;
            this.width = breadth;
        }
        public override double CalculateArea()
        {
            return height * width;
        }
    }
    internal class question10
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Circle cle = new Circle(10.2);
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine($"The area of a cirlce with radius of {cle.radius}unit is: {cle.CalculateArea()}sq.units");
            Console.WriteLine($"The area of a rectangle with width of {rect.width}unit and height of {rect.height}unit is: {rect.CalculateArea()}sq.units");
            Console.ReadKey();
        }
    }
}
