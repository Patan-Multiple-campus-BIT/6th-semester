using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{

    class Delegates
    {
        public delegate void AddDelegate(int a, int b);
        public delegate string AddStringDelegate(string name);
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string AddString(string name)
        {
            return "Hello "+name;
        }
        static void Main(string[] args)
        {
            Delegates del = new Delegates();

            AddDelegate ad = new AddDelegate(del.AddNums);
            ad(100, 150);


            AddStringDelegate adstring = new AddStringDelegate(Delegates.AddString);
            string str = AddString("Keshab");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
