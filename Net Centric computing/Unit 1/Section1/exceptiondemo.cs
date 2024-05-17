using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    internal class exceptiondemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the 1st number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd number: ");
                int y = int.Parse(Console.ReadLine());
                if (y % 2 == 1)
                {
                    throw new Exception("Divisor cann't be an odd number");
                }
                int z = x / y;
                Console.WriteLine("The result is: " + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                //Console.WriteLine(ex2.Message);
                Console.WriteLine("Input should be only a integer or floating value");
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            Console.WriteLine("End of the Program");
            Console.ReadKey();
        }
    }
}
