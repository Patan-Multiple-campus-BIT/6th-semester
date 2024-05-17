//11.	Write a C#  program to get all unique characters in a string
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    internal class question11
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
            List<char> checkedchar = new List<char>();
            Console.Write("Enter your string: ");
            newstring = Console.ReadLine();
            for (int i = 0; i < newstring.Length; i++)
            {
                count = 0;
                target = newstring[i];
                if (checkedchar.Contains(target))
                    continue;
                for (int j =0 ; j < newstring.Length; j++)
                {
                    if (i == j)
                        continue;
                    else if (newstring[i] == newstring[j])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    if (!list.Contains(target))
                    {
                        list.Add(target);
                    }
                }
                checkedchar.Add(target);
            }
            if (list.Count > 0)
            {
                Console.WriteLine($"Unique character in the string '{newstring}' are as follow: ");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine($"No unique character found in the string '{newstring}'");
            }
            Console.ReadKey();
        }
    }
}
