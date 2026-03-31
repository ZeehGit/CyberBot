using System;
using System.Media;
using System.Threading;

namespace CyberBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // 1. Display logo
            DisplayLogo();

            // 2. Play voice greeting
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();

            // 3. Greet user and get their name
            string userName = GreetUser();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n  Ready when you are, {userName}! Press any key to continue...");
            Console.ResetColor();
            Console.ReadKey();

            // 4. Start chat
            StartChat(userName);
        }

        static void StartChat(string userName)
        {
            while (true)
            {
                // Clear screen and show home page each loop
                Console.Clear();
                DisplayHomePage(userName);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\n  {userName}: ");
                Console.ResetColor();

                string input = (Console.ReadLine() ?? "").ToLower().Trim();

                if (input == "exit")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n  ╔══════════════════════════════════════════════╗");
                    Console.WriteLine($"  ║  Goodbye, {userName,-36}║");
                    Console.WriteLine("  ║  Stay safe online! 🛡️                        ║");
                    Console.WriteLine("  ╚══════════════════════════════════════════════╝");
                    Console.ResetColor();
                    break;
                }

                // Show answer on new screen
                string response = Responses.GetResponse(input, userName);
                Console.Clear();
                DisplayAnswerScreen(userName, input, response);

                // Countdown 10 seconds then return to home
                CountdownReturn();
            }
        }

        static void DisplayHomePage(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗ ██████╗  ██████╗ ████████╗
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗╚══██╔══╝
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██████╔╝██║   ██║   ██║   
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██╔══██╗██║   ██║   ██║   
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║██████╔╝╚██████╔╝   ██║   
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝   ╚═╝   
            ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ╔══════════════════════════════════════════════╗");
            Console.WriteLine($"  ║  Welcome back, {userName,-31}║");
            Console.WriteLine("  ║  What would you like to know today?         ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════╣");
            Console.WriteLine("  ║  Topics you can ask about:                  ║");
            Console.WriteLine("  ║    🔒 Password safety                       ║");
            Console.WriteLine("  ║    🎣 Phishing scams                        ║");
            Console.WriteLine("  ║    🌐 Safe browsing                         ║");
            Console.WriteLine("  ║    ⚠️  Suspicious links                      ║");
            Console.WriteLine("  ║    💳 Online fraud                          ║");
            Console.WriteLine("  ║                                              ║");
            Console.WriteLine("  ║  Type 'exit' to quit.                       ║");
            Console.WriteLine("  ╚══════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        static void DisplayAnswerScreen(string userName, string question, string response)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  ╔══════════════════════════════════════════════╗");
            Console.WriteLine("  ║              🛡️  CYBERBOT RESPONSE           ║");
            Console.WriteLine("  ╚══════════════════════════════════════════════╝\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  You asked: {question}\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  CyberBot: {response}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  ══════════════════════════════════════════════");
            Console.ResetColor();
        }

        static void CountdownReturn()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                // Overwrite the same line each second
                Console.Write($"\r  Returning to home in {i} second(s)...   ");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }


        static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗ ██████╗  ██████╗ ████████╗
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗╚══██╔══╝
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██████╔╝██║   ██║   ██║   
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██╔══██╗██║   ██║   ██║   
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║██████╔╝╚██████╔╝   ██║   
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝   ╚═╝   
            ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
         ╔══════════════════════════════════════════╗
         ║             AWARENESS BOT  🛡             ║
         ║    Keeping South Africa Cyber Safe!      ║
         ╚══════════════════════════════════════════╝
            ");
            Console.ResetColor();
        }

        static string GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("         Welcome to CyberBot! 🛡️");
            Console.WriteLine("  Your Cybersecurity Awareness Assistant");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n  Please enter your name: ");
            Console.ResetColor();

            string name = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n╔══════════════════════════════════════════════╗");
            Console.WriteLine($"║  Hello, {name,-38}║");
            Console.WriteLine("║  I'm here to help you stay safe online.      ║");
            Console.WriteLine("║  Together we'll explore:                     ║");
            Console.WriteLine("║    🔒 Phishing scams                         ║");
            Console.WriteLine("║    🔑 Password safety                        ║");
            Console.WriteLine("║    🌐 Safe browsing                         ║");
            Console.WriteLine("║    ⚠️  Suspicious links                      ║");
            Console.WriteLine("║    💳 Online fraud                          ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();

            return name;
        }
    }
}