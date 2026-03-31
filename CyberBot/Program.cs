using System;
using System.Media;

namespace CyberBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display logo
            DisplayLogo();

            Console.WriteLine("\nPress any key to start...");
            Console.ReadKey();

            // Play voice greeting
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync(); // PlaySync waits for it to finish before continuing

            Console.WriteLine("Welcome to CyberBot!");
           
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
         ║       AWARENESS BOT  🛡                  ║
         ║    Keeping South Africa Cyber Safe!       ║
         ╚══════════════════════════════════════════╝
    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
              [=] Phishing Detection
              [=] Password Safety  
              [=] Threat Awareness 
    ");

            Console.ResetColor();
        }
    }
}
