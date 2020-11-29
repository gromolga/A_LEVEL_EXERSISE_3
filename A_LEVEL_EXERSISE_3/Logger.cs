using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_3
{
    class Logger
    {
        private static Logger instance;

        List<string> errors = new List<string>();

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
            errors.Add("Info: " + message);
            Console.WriteLine($"Info: {message}");
        }
        public void Warning(string message)
        {
            errors.Add("Warning: " + message);
            Console.WriteLine($"Warning: {message}");
        }
        public void Error(string message)
        {
            errors.Add("Error: " + message);
            Console.WriteLine($"Error: {message}");
        }
        public string GetAllErrors()
        {
            return string.Join(",'\n'", errors.ToArray());
        }
    }
}
