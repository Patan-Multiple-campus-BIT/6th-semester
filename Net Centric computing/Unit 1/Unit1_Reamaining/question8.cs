//8.Q: Create a base class "Vehicle" with a method "Drive" and a derived class "Car" that hides the "Drive" method. Write a program to demonstrate method hiding in action.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Reamaining
{
    class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving from the Vehicle class");
        }
    }
    class Car : Vehicle
    {
        public new void Drive()
        {
            Console.WriteLine("Driving from the Car class");
        }
    }
    internal class question8
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Vehicle veh = new Vehicle();
            Car car = new Car();
            Console.WriteLine("Calling drive method of vehicle class");
            veh.Drive();
            Console.WriteLine();
            Console.WriteLine("Calling drive method of car class");
            car.Drive();
            Console.ReadKey();
        }
    }
}
