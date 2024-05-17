using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class ParentClass
    {
        public virtual void test1()
        {
            Console.WriteLine("Mehods test1 from parent class");
        }
        public void test2()
        {
            Console.WriteLine("Method test2 from parent class");
        }
    }
    class ChildClass:ParentClass
    {
        public override void test1()
        {
            Console.WriteLine("Method test2 from child class");
        }
        public new void test2() 
        {
            Console.WriteLine("Method test2 from child class");
        }
        static void Main()
        {
            ChildClass c = new ChildClass(); ;
            c.test1();
            c.test2();
            Console.ReadKey();
        }
    }
}
