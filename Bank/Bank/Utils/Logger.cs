using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Utils
{
    internal class Logger
    {
        public static void LoggerMessage(string message)
        {
            Console.Write($"{message}");
        }
        public static void LoggerError(string message, [CallerMemberName] string caller = "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[{caller}]: {message}");
            Console.ResetColor();
        }

        public static void LoggerAccept(string message, [CallerMemberName] string caller = "")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[{caller}]: {message}");
            Console.ResetColor();
        }

        public static void LoggerWarning(string message, [CallerMemberName] string caller = "")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[{caller}]: {message}");
            Console.ResetColor();
        }
    }
}
