using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }        
        public void sub(int x, int y)
        {
            Console.WriteLine(x-y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
    class childcls : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);

        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
             
    }
    internal class abstractdemo
    {
        static void Main(string[] args)
        {
            childcls c = new childcls();
            c.Mul(4, 5);
            Console.ReadKey();
        }
    }
}
  