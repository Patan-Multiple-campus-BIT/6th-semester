//12.Q: Implement an interface "ILogger" with a method "Log" that takes a string parameter. Create a class "FileLogger" that implements the "ILogger" interface and writes the log message to a file.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1_Reamaining
{
    interface Ilogger
    {
        void Log(string message);
    }
    class FileLogger : Ilogger
    {
        public void Log(string message)
        {
            File.WriteAllText("Newfile.txt", message);
            Console.WriteLine("Log message is written into the file sucessfully.");
        }
    }
    class question12
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            FileLogger fl = new FileLogger();
            Console.Write("Enter the message: ");
            string message = Console.ReadLine();
            fl.Log(message);
            Console.ReadKey();
        }
    }

}
