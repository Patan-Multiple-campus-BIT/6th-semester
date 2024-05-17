using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Section1
{
    class GenericDelegates
    {
        public double AddNums1(int x,float y,double z)
        {
            return x + y + z;
        }
        public void AddNums2(int x, float y,double z)
        {
            Console.WriteLine(x + y + z);
        }
        public bool CheckLength(string name)
        {
            return name.Length >= 10 ? true : false;
        }
        static void Main(string[] args)
        {
            //GenericDelegates dg1 = new GenericDelegates();
            //Func<int, float, double, double> obj1 = dg1.AddNums1;
            //double result = obj1.Invoke(10, 12.2267f, 13.3999d);
            //Console.WriteLine(result);

            //Action<int, float, double> obj2 = dg1.AddNums2;
            //obj2.Invoke(10, 22.22f, 23.332d);

            //Predicate<string> obj3 = dg1.CheckLength;
            //bool ans = obj3.Invoke("keshab Aryal");
            //Console.WriteLine(ans);




            Console.ReadKey();
        }
    }

}
