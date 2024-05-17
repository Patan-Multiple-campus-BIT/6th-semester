using System;

namespace keshab
{
    class LoadParent
    {
        public void show()
        {
            Console.WriteLine("Parent's show method is called");
        }
        public virtual void test()
        {
            Console.WriteLine("Parent's Test method is called");
        }
    }
    class LoadChild : LoadParent
    {
        public void show(int i)
        {
            Console.WriteLine($"child show method is called");
        }
        public override void test()
        {
            Console.WriteLine("Child's test method is callled"); 
        }
        static void Main(string[] args)
        {
            LoadChild c = new LoadChild();
            c.show(10);
            c.show();
            c.test();
            Console.ReadKey();
        }
    }
}