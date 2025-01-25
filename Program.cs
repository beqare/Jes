using System;
using System.Diagnostics;

namespace ConsoleApp
{
    class Program
    {
        // ---------------------------------------- config ----------------------------------------

        private const string Version = "1.0.0";
        private const string Name = "JES";
        private const string Author = "beqare";
        private const string continueMessage = "Press any key to continue.";
        private const string Title = " | " + Name + " v" + Version + " by " + Author;

        // ---------------------------------------- menu ----------------------------------------
        static void Main(string[] args)
        {
            // ---------------------------------------- setup ----------------------------------------
            Console.Title = Title;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("Welcome to JES - Choose an option:");
                Console.WriteLine("====================================");
                Console.WriteLine("[1] Start JES");
                Console.WriteLine("[3] Aks for help");
                Console.WriteLine("[4] View on Github");
                Console.WriteLine("[5] Exit");
                Console.WriteLine("");
                Console.Write("Option: ");
                string input = Console.ReadLine() ?? string.Empty;

                switch (input)
                {
                    case "1":
                        Console.Title = Title + " | Starting...";
                        StartJES();
                        break;
                    case "3":
                        Console.Title = Title + " | Help";
                        OpenUrl("https://beqare.de/discord");
                        break;
                    case "4":
                        Console.Title = Title + " | Github";
                        OpenUrl("https://github.com/beqare/jes");
                        break;
                    case "5":
                        Console.WriteLine("Exiting JES...");
                        return;
                    default:
                        Console.Title = Title + " | Error";
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        // Methods

        static void StartJES()
        {
            Console.Clear();
            Console.WriteLine("Starting JES...");
            Console.WriteLine(continueMessage);
            Console.ReadKey();
            Console.WriteLine("cleaning pc...");
            try
            {
                string user = Environment.UserName;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // side methods
        static void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
                Console.WriteLine($"{url} opened, check your browser.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}