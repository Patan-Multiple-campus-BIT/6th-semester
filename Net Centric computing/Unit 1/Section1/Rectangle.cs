using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    public delegate void RectDelegate(double width, double height);
    class Rectangles
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of the rectangle: "+ width * height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of the rectangle: "+ 2*(width+height));
        }
        static void Main(string[] args)
        {
            Rectangles rect = new Rectangles();

            RectDelegate obj = new RectDelegate(rect.GetArea);
            obj += rect.GetPerimeter;
            obj.Invoke(12.34, 56.78);


            obj.Invoke(100, 200);
            Console.ReadKey();
        }
    }
}
