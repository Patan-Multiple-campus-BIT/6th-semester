//5.Develop a class called Book with auto-implemented properties for Title and Author. Create an object of this class and set the properties to represent a book’s details.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class Book
    {
        private string title;
        private string author;

        public Book(string t, string a)
        {
            this.title = t;
            this.author = a;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"The title of the book is '{this.title}' and name of the author is '{this.author}'");
            return;
        }
    }
    internal class question5
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Book book1 = new Book("The dark light", "Keshab Aryal");
            book1.DisplayDetails();
            Console.ReadKey();
            return;
        }
    }
}
