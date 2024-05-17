//10.Write a C#  program to find duplicate characters in a string
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    internal class question10
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string newstring;
            char target;
            int count;
            List<char> list = new List<char>();
            Console.Write("Enter your string: ");
            newstring = Console.ReadLine();
            for(int i = 0; i < newstring.Length; i++)
            {
                count = 0;
                target = newstring[i];
                for(int j=i+1;j< newstring.Length; j++)
                {
                    if (newstring[i] == newstring[j])
                    {
                        count++;
                    }
                }
                if(count > 0)
                {
                    if (!list.Contains(target))
                    {
                        list.Add(target);
                    }
                }
            }
            if(list.Count > 0)
            {
                Console.WriteLine($"Duplicates character in the string '{newstring}' are as follow: ");
                    for(int i = 0; i < list.Count; i++)
                    {
                        Console.Write(list[i] + ", ");
                    }
            }
            else
            {
                Console.WriteLine($"No duplicates character found in the string '{newstring}'");
            }
            Console.ReadKey();
        }
    }
}
