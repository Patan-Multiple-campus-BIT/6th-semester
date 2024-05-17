//9.Q: Develop a C# program that showcases method overriding by creating a base class "Animal" with a method "MakeSound" and derived classes like "Cat" and "Dog" that override the "MakeSound" method. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Reamaining
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("All animals have their own unique sound");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says meow!!!");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says bhou bhou !!!");
        }
    }
    internal class question9
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Animal ani = new Animal();
            Cat ct = new Cat();
            Dog dg = new Dog();

            Console.WriteLine("Calling MakeSound method of Animal: ");
            ani.MakeSound();
            Console.WriteLine();
            Console.WriteLine("Calling MakeSound method of Cat: ");
            ct.MakeSound();
            Console.WriteLine();
            Console.WriteLine("Calling MakeSound method of Dog: ");
            dg.MakeSound();
            Console.ReadKey();
        }
    }
}
