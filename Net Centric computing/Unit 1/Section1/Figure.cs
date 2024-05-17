using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    public abstract class Figure
    {
        public double width, height, radius;
        public const float PI = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return this.height * this.width;
        }
    }
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return PI * this.radius * this.radius;
        }
    }
    class TestFigures
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Circle c = new Circle(5);

            Console.WriteLine($"The are of ractangle is: {r.GetArea()}");
            Console.WriteLine($"The are of circle is: {c.GetArea()}");
        }
    }

}
