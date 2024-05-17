using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Matrix
    {
        public int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
        }
        public override string ToString()
        {
            return a + " "+b+"\n"+c+" "+d+"\n";
        }
    }
    internal class operatoroverload
    {

        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(1, 2, 3, 4);
            Matrix m2 = new Matrix(5, 6, 7, 8);
            Matrix m3 = m1 + m2;
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString()); 
            Console.WriteLine(m3.ToString());
            Console.ReadKey();
        }
    }
}
