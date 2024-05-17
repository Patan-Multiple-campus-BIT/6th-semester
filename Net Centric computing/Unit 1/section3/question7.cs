//7.Write a C#  program to read n values in an array and display them in reverse order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    internal class question7
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
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the number for position {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your number in reverse order are: ");
            for(int i=size-1;i>=0; i--) 
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.ReadLine();
        }
    }
}
