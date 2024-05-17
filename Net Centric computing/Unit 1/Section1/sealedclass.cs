using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("Method of Base Class..");
        }

    }
    class DerivedClass : BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("Method of Derived Class..");
        }
    }
    class Sealedclass
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.Show1();
            Console.WriteLine(); 
        }
    }
}