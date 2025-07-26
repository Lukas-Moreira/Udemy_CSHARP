using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato.Utils
{
    internal class Logger
    {
        public static void Log(string message, bool carrieReturn)
        {
            // In a real application, you might write to a file or a logging system
            if (!carrieReturn)
            {
                Console.Write($"[{DateTime.Now}]: {message} ");
                return;
            }
            Console.WriteLine($"[{DateTime.Now}]: {message}");
        }

        public static void LogError(string message, [CallerMemberName] string caller = "")
        {
            // In a real application, you might write to a file or a logging system
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] [{caller}] [{DateTime.Now}]: {message}");
            Console.ResetColor();
        }
        
        public static void LogWarning(string message, [CallerMemberName] string caller = "")
        {
            // In a real application, you might write to a file or a logging system
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING] [{caller}] [{DateTime.Now}]: {message}");
            Console.ResetColor();
        }
    }
}
