using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    internal class LambdaExpressions
    {
        public delegate string GreetingDelegate(string str);
        static void Main(string[] args)
        {
            GreetingDelegate obj1 = (name) =>
            {
                return "Hello " + name + " a very good morning";
            };
            string result = obj1.Invoke("Raju");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
