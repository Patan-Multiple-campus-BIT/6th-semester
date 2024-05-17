using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary=0.0;
            bool iserror = true;
            while (iserror)
            {
                Console.WriteLine("Enter the salary of the employee: ");
                try
                {
                    salary = Convert.ToDouble(Console.ReadLine());
                    iserror = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("salary must be a numeric value");
                }

            }

            Console.WriteLine($"The salary is: {salary}");
            Console.ReadKey();
            return;
        }
    }
}
