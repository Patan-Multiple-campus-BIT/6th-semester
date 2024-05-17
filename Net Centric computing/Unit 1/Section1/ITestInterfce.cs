using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    interface ITestInterface
    {
        void Add(int a, int b);

    }
    interface ITestInterface2 : ITestInterface
    {
        void sub(int a, int b);
    }
    class ImplementationClass : ITestInterface2
    {
        public void Add(int a,int b)
        {
             Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
