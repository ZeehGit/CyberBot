using System;
using System.Collections.Generic;

namespace CyberBot
{
    // summary
    // Handles all chatbot keyword recognition and response logic.
    // Uses arrays for random responses and a dictionary for memory recall.
    // (Microsoft, 2023) - Dictionary and List data structures
    public static class Responses
    {
        // (GeeksforGeeks, 2023) - using arrays for random responses
        private static readonly Random random = new Random();

        private static readonly string[] phishingResponses =
        {
            $"Watch out for urgent emails asking you to click a link immediately — this is a classic phishing tactic!",
            "Always check the sender's email address. Scammers disguise themselves as trusted organisations.",
            "Never enter your password on a site you reached by clicking an email link. Go directly to the website instead.",
            "Phishing messages often contain spelling mistakes and generic greetings like 'Dear Customer'.",
            "Be cautious of emails offering prizes or threatening account suspension — these are common phishing tricks."
        };

        private static readonly string[] passwordResponses =
        {
            "Use at least 12 characters mixing uppercase, lowercase, numbers and symbols for a strong password.",
            "Never reuse the same password across multiple sites — if one gets breached, all accounts are at risk.",
            "Consider using a password manager like Bitwarden or 1Password to generate and store strong passwords.",
            "A passphrase like 'BlueSky$River99' is both strong and easier to remember than random characters.",
            "Enable two-factor authentication wherever possible for an extra layer of security."
        };

        private static readonly string[] browsingResponses =
        {
            "Always check for 'https://' and a padlock icon before entering personal information on a website.",
            "Avoid using public Wi-Fi for banking or shopping — use a VPN if you must connect to public networks.",
            "Keep your browser and extensions updated to protect against known vulnerabilities.",
            "Use a trusted antivirus program and make sure it stays updated.",
            "Be careful what browser extensions you install — some can steal your data."
        };

        // (Microsoft, 2023) - Dictionary for keyword mapping
        private static readonly Dictionary<string, string> memoryStore = new Dictionary<string, string>();

        public static string GetResponse(string input, string userName, string lastTopic, out string detectedTopic)
        {
            detectedTopic = lastTopic;

            // Q5 - Memory: store interest
            if (input.Contains("i am interested in") || input.Contains("i'm interested in"))
            {
                string topic = input.Replace("i am interested in", "").Replace("i'm interested in", "").Trim();
                memoryStore[userName] = topic;
                detectedTopic = topic;
                return $"Great! I'll remember that you're interested in {topic}, {userName}. It's a crucial part of staying safe online.";
            }

            // Q5 - Memory: recall interest
            if (input.Contains("what do i like") || input.Contains("what am i interested in"))
            {
                if (memoryStore.ContainsKey(userName))
                    return $"As someone interested in {memoryStore[userName]}, {userName}, you might want to review your account security settings regularly.";
                return $"I don't have any saved interests for you yet, {userName}. Tell me what cybersecurity topic interests you!";
            }

            // General questions
            if (input.Contains("how are you"))
            {
                detectedTopic = "general";
                return $"I'm running at full security, {userName}! Ready to help you stay cyber safe.";
            }

            if (input.Contains("what is your purpose") || input.Contains("what's your purpose"))
            {
                detectedTopic = "general";
                return $"My purpose is to educate you on cybersecurity threats, {userName}. I help with phishing, passwords, safe browsing and more!";
            }

            if (input.Contains("who are you") || input.Contains("your name"))
            {
                detectedTopic = "general";
                return "I'm CyberBot, your Cybersecurity Awareness Assistant!";
            }

            if (input.Contains("what can i ask") || input.Contains("help") || input.Contains("topics"))
            {
                detectedTopic = "general";
                return $"You can ask me about:\n🔒 Password safety\n🎣 Phishing\n🌐 Safe browsing\n⚠️ Suspicious links\n💳 Online fraud\n🔐 Privacy";
            }

            // Q2 + Q3 - Keyword recognition with random responses
            if (input.Contains("phishing") || input.Contains("phish"))
            {
                detectedTopic = "phishing";
                return phishingResponses[random.Next(phishingResponses.Length)];
            }

            if (input.Contains("password"))
            {
                detectedTopic = "password";
                return passwordResponses[random.Next(passwordResponses.Length)];
            }

            if (input.Contains("browsing") || input.Contains("browse") || input.Contains("internet") || input.Contains("website"))
            {
                detectedTopic = "browsing";
                return browsingResponses[random.Next(browsingResponses.Length)];
            }

            if (input.Contains("link") || input.Contains("url") || input.Contains("suspicious"))
            {
                detectedTopic = "links";
                return $"Before clicking any link, {userName}: Hover over it to preview the real URL, check for misspellings like 'amaz0n.com', and use virustotal.com to scan it.";
            }

            if (input.Contains("fraud") || input.Contains("scam"))
            {
                detectedTopic = "fraud";
                return $"To protect yourself from online fraud, {userName}: Never share banking details via email or SMS, and report suspicious activity to cybercrime.org.za";
            }

            if (input.Contains("privacy"))
            {
                detectedTopic = "privacy";
                return $"Great topic, {userName}! I'll remember that you're interested in privacy. Review your social media settings regularly and use strong, unique passwords for each account.";
            }

            // Q7 - Default fallback for unrecognised input
            detectedTopic = lastTopic;
            return $"I'm not sure I understand that, {userName}. Could you try rephrasing? You can ask about passwords, phishing, safe browsing, suspicious links, or online fraud.";
        }
    }
}

/*
 * Author:ChatGPT
 * Title: Code help
 * Available at: https://chatgpt.com/share/69cc1a2d-6d80-832a-937b-6d4a6a0bf556
 * Accessed date: 30 March 2026
 */

/*
* Author:Microsoft
* Title: Password safety
* Available at: https://www.microsoft.com/en-za/security/business/security-101/what-is-password-protection
* Accessed date: 30 March 2026
*/

/*
* Author:Microsoft
* Title: Phishing scams
* Available at:https://support.microsoft.com/en-us/security/protect-yourself-from-phishing#:~:text=Phishing%20(pronounced:%20fishing)%20is,link%20to%20a%20phishing%20website.
* Accessed date: 30 March 2026
*/

/*
* Author:Google
* Title: Safe browsing
* Available at: https://safebrowsing.google.com/
* Accessed date: 30 March 2026
*/

/*
* Author:University of Denver
* Title: Suspicious links
* Available at: https://www.du.edu/it/services/security/5-url-warning-signs
* Accessed date: 30 March 2026
*/

/*
* Author:Fortinet
* Title: Online fraud
* Available at: https://www.fortinet.com/uk/resources/cyberglossary/internet-fraud
* Accessed date: 30 March 2026
*/