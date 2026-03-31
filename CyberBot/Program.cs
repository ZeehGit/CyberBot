using System;
using System.Media;

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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Type your question below. Type 'exit' to");
            Console.WriteLine("quit at any time.");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"  {userName}: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower().Trim();

                if (input == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\n  Goodbye, {userName}! Stay safe online. 🛡️");
                    Console.ResetColor();
                    break;
                }

                string response = GetResponse(input, userName);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n  CyberBot: {response}\n");
                Console.ResetColor();
            }
        }

        static string GetResponse(string input, string userName)
        {
            // General questions
            if (input.Contains("how are you"))
                return $"I'm running at full security, {userName}! Ready to help you stay cyber safe. 😊";

            if (input.Contains("what is your purpose") || input.Contains("what's your purpose"))
                return $"My purpose is to educate you on cybersecurity threats, {userName}. I can help you recognise phishing scams, create strong passwords, and browse safely online.";

            if (input.Contains("what can i ask") || input.Contains("help") || input.Contains("topics"))
                return $"Great question, {userName}! You can ask me about:\n" +
                       "  🔒 Password safety\n" +
                       "  🎣 Phishing scams\n" +
                       "  🌐 Safe browsing\n" +
                       "  ⚠️  Suspicious links\n" +
                       "  💳 Online fraud";

            if (input.Contains("your name") || input.Contains("who are you"))
                return "I'm CyberBot, your Cybersecurity Awareness Assistant! 🤖🛡️";

            // Password safety
            if (input.Contains("password"))
                return $"Here are some password safety tips, {userName}:\n" +
                       "  ✅ Use at least 12 characters\n" +
                       "  ✅ Mix uppercase, lowercase, numbers and symbols\n" +
                       "  ✅ Never reuse passwords across sites\n" +
                       "  ✅ Use a password manager\n" +
                       "  ❌ Never share your password with anyone";

            // Phishing
            if (input.Contains("phishing") || input.Contains("phish"))
                return $"Phishing is when attackers trick you into revealing personal info, {userName}. Watch out for:\n" +
                       "  ⚠️  Urgent or threatening emails\n" +
                       "  ⚠️  Suspicious sender addresses\n" +
                       "  ⚠️  Links that don't match the website name\n" +
                       "  ⚠️  Requests for passwords or banking details";

            // Safe browsing
            if (input.Contains("browsing") || input.Contains("browse") || input.Contains("internet") || input.Contains("website"))
                return $"Safe browsing tips for you, {userName}:\n" +
                       "  🌐 Always check for 'https://' before entering personal info\n" +
                       "  🌐 Avoid public Wi-Fi for banking or shopping\n" +
                       "  🌐 Keep your browser updated\n" +
                       "  🌐 Use a trusted antivirus program";

            // Suspicious links
            if (input.Contains("link") || input.Contains("url") || input.Contains("suspicious"))
                return $"Before clicking any link, {userName}:\n" +
                       "  🔍 Hover over it to preview the real URL\n" +
                       "  🔍 Check for misspellings (e.g. 'amaz0n.com')\n" +
                       "  🔍 Don't click links from unknown senders\n" +
                       "  🔍 Use a link checker like virustotal.com";

            // Online fraud
            if (input.Contains("fraud") || input.Contains("scam"))
                return $"To protect yourself from online fraud, {userName}:\n" +
                       "  💳 Never share banking details via email or SMS\n" +
                       "  💳 Verify requests by calling the organisation directly\n" +
                       "  💳 Report suspicious activity to cybercrime.org.za";

            // Default fallback
            return $"I'm not sure about that, {userName}. Try asking me about passwords, phishing, safe browsing, or suspicious links!";
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
         ║             AWARENESS BOT  🛡             ║
         ║    Keeping South Africa Cyber Safe!      ║
         ╚══════════════════════════════════════════╝
    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            

            Console.ResetColor();
        }

        static string GreetUser() // greeting and name input
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("         Welcome to CyberBot! 🛡️");
            Console.WriteLine("  Your Cybersecurity Awareness Assistant");
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