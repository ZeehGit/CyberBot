using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace CyberBot
{
    class UI
    {
        // Typing effect - prints text character by character
        public static void TypeText(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        // Coloured typing effect
        public static void TypeText(string text, ConsoleColor color, int delay = 30)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        // Section header with divider
        public static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ╔══════════════════════════════════════════════╗");
            Console.WriteLine($"  ║  {title,-44}║");
            Console.WriteLine("  ╚══════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        // Simple divider line
        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n  ══════════════════════════════════════════════\n");
            Console.ResetColor();
        }

        // Success message in green
        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            TypeText($"  ✅ {message}", ConsoleColor.Green);
            Console.ResetColor();
        }

        // Warning message in yellow
        public static void PrintWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeText($"  ⚠️  {message}", ConsoleColor.Yellow);
            Console.ResetColor();
        }

        // Error message in red
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            TypeText($"  ❌ {message}", ConsoleColor.Red);
            Console.ResetColor();
        }

        // Bot response with typing effect
        public static void PrintBotResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  🤖 CyberBot: ");
            Console.ResetColor();
            TypeText(message, ConsoleColor.Green, 20);
        }

        // Animated loading dots
        public static void PrintLoading(string message = "Thinking")
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"\n  {message}");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(400);
                Console.Write(".");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}