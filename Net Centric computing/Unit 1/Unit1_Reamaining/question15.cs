//15.Q: Write a C# program to create a generic class "Stack<T>" that implements a stack data structure. Test the stack by pushing and popping elements of different data types.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Reamaining
{
    class Stack<T>
    {
        T[] elements;
        int size;
        int index = -1;
        public Stack(int capacity = 10)
        {
            this.size = capacity;
            this.elements = new T[capacity];
            Console.WriteLine($"Stack of size {capacity} is created sucessfully");
        }
        public void push(T item)
        {
            if (this.index == this.size - 1)
            {
                Console.WriteLine($"Stack over flow.Item {item} was not pushed into the stack");
            }
            else
            {
                elements[++index] = item;
                Console.WriteLine($"Item {item} pushed into the stack sucessfully.");
            }
        }
        public T pop()
        {
            if (index == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            else
            {
                return elements[index--];
            }
        }

        
    }
    internal class question15
    {
        static void Main(string[] args)
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Int stack:");
                Stack<int> stack1 = new Stack<int>(2);
                stack1.push(1);
                stack1.push(2);
                stack1.push(3);
                Console.WriteLine(stack1.pop());
                Console.WriteLine(stack1.pop());
   

                Console.WriteLine("String stack:");
                Stack<string> stack2 = new Stack<string>(2);
                stack2.push("one");
                stack2.push("Two");
                stack2.push("Three");
                Console.WriteLine(stack2.pop());
                Console.WriteLine(stack2.pop());
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
