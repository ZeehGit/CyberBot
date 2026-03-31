using System;
using System.Media;

namespace CyberBot
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }

        static void DisplayLogo() // logo only - no user input here
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
         ║       AWARENESS BOT  🛡                  ║
         ║    Keeping South Africa Cyber Safe!       ║
         ╚══════════════════════════════════════════╝
    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            

            Console.ResetColor();
        }

        static string GreetUser() // greeting and name input
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║        Welcome to CyberBot! 🛡️               ║");
            Console.WriteLine("║  Your Cybersecurity Awareness Assistant       ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n  Please enter your name: ");
            Console.ResetColor();

            string name = Console.ReadLine();

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
            Console.WriteLine("║    ⚠️  Suspicious links                       ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();

            return name;
        }
    }
}