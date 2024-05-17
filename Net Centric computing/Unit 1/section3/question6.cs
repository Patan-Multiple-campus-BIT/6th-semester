//6.Write a C# program that stores elements in an array and prints them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    internal class question6
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int size;
            Console.Write("How many numbers do you want to store? ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Enter the number for position {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your numbers are as follow: ");
            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }

    }
}
