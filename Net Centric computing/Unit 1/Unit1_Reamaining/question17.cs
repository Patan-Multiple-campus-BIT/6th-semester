//17.Q: Write a program that demonstrates exception handling in C# by handling a divide-by-zero exception using a try-catch block. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Reamaining
{
    internal class question17
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            int num1, num2, num3;
            try
            {
                Console.Write("Enter your first number: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter your second number: ");
                num2 = int.Parse(Console.ReadLine());

                num3 = num1 / num2;
                Console.WriteLine($"The result of {num1}/{num2} is: {num3}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("A number cann't be divided by zero");
            }
            Console.WriteLine("Program execution completed");
            Console.ReadKey();
        }
    }
}
