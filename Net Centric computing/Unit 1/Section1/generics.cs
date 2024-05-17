using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Section1
{
    class Example<T>
    {
        T box;
        public Example(T b)
        {
          this.box = b;
        }
        public T getbox()
        {
          return box;
        }
    }
    internal class generic
    {
        static void Main(string[] args)
        {
            Example<int> e = new Example<int>(20);
            Console.WriteLine(e.getbox());
            Example<string> e1 = new Example<string>("keshab");
            Console.WriteLine(e1.getbox());
            Console.ReadKey();
        }
    }
}
