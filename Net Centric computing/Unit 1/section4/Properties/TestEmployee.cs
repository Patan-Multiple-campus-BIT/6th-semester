using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section4.Properties
{
    internal class TestEmployee
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Employee Emp = new Employee(1001, "Scott", "Manager", 20000.00, "Sales", "Mumbai");
            Console.WriteLine($"Eno. {Emp[0]}");
            Console.WriteLine($"Ename: {Emp[1]}");
            Console.WriteLine($"Job: {Emp[2]}");
            Console.WriteLine($"Salary: {Emp[3]}");
            Console.WriteLine($"Dname: {Emp[4]}");
            Console.WriteLine($"Location: {Emp[5]}");

            Emp[0] = 10002;
            Emp[1] = "Keshab Aryal";
            Console.WriteLine($"{Emp[0]}");
            Console.WriteLine($"{Emp[1]}");
            Console.ReadKey();
        }
    }
}
