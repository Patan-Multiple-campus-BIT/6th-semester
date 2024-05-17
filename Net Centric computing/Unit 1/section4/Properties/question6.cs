//6.Design a class with an indexer to represent a student's list of grades, allowing access and modification by index.
using System;
using System.Collections.Generic;
namespace section4.Properties
{
    public class Student
    {
        private List<char> grades = new List<char>();


        public object this[int index]
        {
            get
            {
                if(index<0 && index >= grades.Count)
                {
                    throw new IndexOutOfRangeException("Index of out of range");
                }
                else
                {
                    return grades[index];
                }
            }
            set
            {
                if (index < 0 || index > grades.Count)
                {
                    throw new Exception($"Index {index} cann't be access");
                }
                else
                    grades.Add((char)value);
            }
        }
    }

    internal class question6
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Student std = new Student();
            std[0] = 'A';
            std[1] = 'B';
            std[2] = 'A';
            std[3] = 'C';
            std[4] = 'A';

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Grade of student at position {i + 1} is: {std[i]}");
            }

            std[1] = 'A';
            Console.WriteLine($"New grade of student at positon 2 is: {std[1]}");
            Console.ReadKey();
        }
    }
}