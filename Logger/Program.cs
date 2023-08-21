using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

static class Logger
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger.LogMessage("Starting the application...");

        // Simulating some application logic
        for (int i = 1; i <= 5; i++)
        {
            Logger.LogMessage($"Performing task {i}");
        }

        Logger.LogMessage("Application finished.");
        Console.ReadLine();
    }
}
