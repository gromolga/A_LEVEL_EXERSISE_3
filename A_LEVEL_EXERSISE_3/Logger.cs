using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_3
{
    class Logger
    {
        private static Logger instance;

        private Logger()
        {

        }
        public static Logger getInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }
        public void Warning(string message)
        {
            Console.WriteLine($"Warning: {message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
    }
}
