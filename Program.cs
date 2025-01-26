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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("====================================");
                Console.WriteLine("       Welcome to JES - Main Menu   ");
                Console.WriteLine("====================================");
                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine("[1] Start JES");
                Console.WriteLine("[3] Ask for help");
                Console.WriteLine("[4] View on Github");
                Console.WriteLine("[5] Exit");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Option: ");
                Console.ResetColor();

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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Exiting JES...");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Title = Title + " | Error";
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        Console.ResetColor();
                        break;
                }
            }
        }


        // ---------------------------------------- start ----------------------------------------

        static void StartJES()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine("        Starting JES...             ");
            Console.WriteLine("=====================================");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cleaning your PC...");
            Console.ResetColor();

            Console.WriteLine("=====================================");
            Console.WriteLine("Please press any key to continue...");
            Console.WriteLine("=====================================");

            Console.ReadKey();

            SystemOptimizer();
        }
        // ---------------------------------------- optimizer ----------------------------------------
        static void SystemOptimizer()
        {
            Console.WriteLine();
            Console.WriteLine("deleting temp files...");
            Console.WriteLine();
            try
            {
                string user = Environment.UserName;
                string tempPath = Path.GetTempPath();
                string[] foldersToEmpty =
                {
                    tempPath,
                    // programdata
                    $@"C:\ProgramData\Microsoft\Windows Defender\Scans\History\Results\Resource",
                    $@"C:\ProgramData\Microsoft\Windows Defender\Scans\History\Results\Quick",
                    $@"C:\ProgramData\Microsoft\Windows Defender\Support",
                    $@"C:\ProgramData\Microsoft\Windows Defender\Scans\MetaStore",
                    $@"C:\ProgramData\Microsoft\Windows Defender\Scans\History\ReportLatency\Latency",
                    $@"C:\ProgramData\Microsoft\Windows Defender\Scans\History\CacheManager",
                    $@"C:\ProgramData\Microsoft\Windows\WER\Temp",
                    $@"C:\ProgramData\Microsoft\Windows\WER\ReportQueue",
                    $@"C:\ProgramData\Microsoft\Windows\WER\ReportArchive",
                    $@"C:\ProgramData\temp",
                    $@"C:\ProgramData\Microsoft\Windows\WER\ReportArchive",

                    // windows
                    $@"C:\Windows\pchealth\helpctr\OfflineCache",
                    $@"C:\Windows\pchealth\ERRORREP",
                    $@"C:\Windows\System32\Winevt\Logs",
                    $@"C:\Windows\SysNative\Winevt\Logs",
                    $@"C:\Windows\LiveKernelReports",
                    $@"C:\Windows\ServiceProfiles\NetworkService\AppData\Local\Microsoft\Windows\DeliveryOptimization",
                    $@"C:\Windows\system32\catroot2",
                    $@"C:\Windows\SoftwareDistribution\Download",
                    $@"C:\Windows\Temp",
                    $@"C:\Windows\Minidump",
                    $@"C:\Windows\Prefetch",
                    $@"C:\Windows\Temp",
                    $@"C:\Windows\SoftwareDistribution\download",
                    $@"C:\Windows\Downloaded Program Files",

                    // user
                    $@"C:\Users\{user}\.cache",

                    // roaming
                    $@"C:\Users\{user}\AppData\Roaming\discord\Code Cache",
                    $@"C:\Users\{user}\AppData\Roaming\Microsoft\Teams\Code Cache\js",
                    $@"C:\Users\{user}\AppData\Roaming\discord\Code Cache\js",
                    $@"C:\Users\{user}\AppData\Microsoft\Windows\Recent\AutomaticDestinations",
                    $@"C:\Users\{user}\AppData\Microsoft\Windows\Recent\CustomDestinations",

                    // local
                    $@"C:\Users\{user}\AppData\Local\PCHealth\ErrorRep\QSignoff",
                    $@"C:\Users\{user}\AppData\Local\D3DSCache",
                    $@"C:\Users\{user}\AppData\Local\Microsoft\Windows\AppCache",
                    $@"C:\Users\{user}\AppData\Local\Microsoft\Windows\WebCache",
                    $@"C:\Users\{user}\AppData\Local\Microsoft\Windows\Temporary Internet Files",
                    $@"C:\Users\{user}\AppData\Local\Microsoft\Windows\INetCache\IE\",
                    $@"C:\Users\{user}\AppData\Local\D3DSCache",
                    $@"C:\Users\{user}\AppData\Local\Temp",
                    $@"C:\Users\{user}\AppData\Local\NVIDIA\DXCache",
                    $@"C:\Users\{user}\AppData\Local\NVIDIA\GLCache",
                    $@"C:\Users\{user}\AppData\Local\CapCut\User Data\Cache",
                    $@"C:\Users\{user}\AppData\Local\pip\cache",
                    $@"C:\Users\{user}\AppData\Local\Microsoft\Edge\User Data\BrowserMetrics",
                    $@"C:\Users\{user}\AppData\Local\Google\Chrome\User Data\Default\Cache\Cache_Data",
                    $@"C:\Users\{user}\AppData\Local\Google\Chrome\User Data\Default\Service Worker\CacheStorage",
                    $@"C:\Users\{user}\AppData\Local\Opera Software\Opera Stable\Default\Cache\Cache_Data",
                    $@"C:\Users\{user}\AppData\Local\Opera Software\Opera Stable\Default\System Cache\Cache_Data",

                    // locallow
                    $@"C:\Users\{user}\AppData\LocalLow\Temp",
                    $@"C:\Users\{user}\AppData\LocalLow\Microsoft\CryptnetUrlCache\Content",
                    $@"C:\Users\{user}\AppData\LocalLow\Microsoft\CryptnetUrlCache\MetaData"
                };

                foreach (string folder in foldersToEmpty)
                {
                    EmptyFolder(folder);
                }

                Console.WriteLine("");
                Console.WriteLine("finished, press any key to continue.");
                Console.WriteLine("");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
        }

        static void EmptyFolder(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, recursive: true);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(path);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(path);
                    Console.ResetColor();
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(path);
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(path);
                Console.ResetColor();
            }
        }

        // ---------------------------------------- open url ----------------------------------------
        static void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
                Console.WriteLine($"{url}, check your browser.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
