//9.Write a C#  program to copy the elements of one array into another array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    internal class question9
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int[] numbers = new int[]
            {
                1,2,3,4,5
            };
            int[] newnumbers = new int[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                newnumbers[i] = numbers[i];
            }
            Console.WriteLine("After copying the numbers in newnumbers are as follow: ");
            foreach(int i in newnumbers)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
