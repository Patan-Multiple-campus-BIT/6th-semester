//4.Create a class called Person with properties for FirstName and LastName. Implement a simple program that sets and retrieves these properties for an instance of the Person class.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class Person
    {
        private string firstname;
        private string lastname;

        public string Firstname
        {
            get => firstname;
            set => firstname = value;
        }

        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }

    }
    internal class question4
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Person p1 = new Person();
            p1.Firstname = "Keshab";
            p1.Lastname = "Aryal";
            Console.WriteLine($"The first name is: {p1.Firstname}");
            Console.WriteLine($"The last name is: {p1.Lastname}");
            Console.ReadLine();
        }
    }

}
