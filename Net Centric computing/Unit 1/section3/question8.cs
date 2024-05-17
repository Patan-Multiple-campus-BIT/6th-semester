//8.Write a C#  program to find the sum of all array elements. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    internal class question8
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int size, sum = 0;
            Console.Write("How many numbers do you want to store? ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the number for position {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            Console.Write($"The sum of all the elelments in array is: {sum}");
            Console.ReadLine();
        }
    }
}
