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
        void Log();
    }
    class FileLogger : Ilogger
    {
        public void Log()
        {
            string writetext = "Hello World";
            File.WriteAllText("Newfile.txt", writetext);
        }
    }
    class question12
    {
        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger();
            fl.Log();
            Console.ReadKey();
        }
    }

}
