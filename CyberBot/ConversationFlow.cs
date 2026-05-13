using System;
using System.Collections.Generic;
using System.Text;

namespace CyberBot
{
    public static class ConversationFlow
    {
        // (Microsoft, 2023) - handling follow-up conversation
        public static bool IsFollowUp(string input)
        {
            return input.Contains("tell me more") ||
                   input.Contains("explain more") ||
                   input.Contains("give me another tip") ||
                   input.Contains("more info") ||
                   input.Contains("what else") ||
                   input.Contains("another tip") ||
                   input.Contains("more details");
        }

        public static string GetFollowUp(string input, string lastTopic, string userName)
        {
            if (string.IsNullOrEmpty(lastTopic))
                return $"Sure, {userName}! What topic would you like to know more about? Try asking about passwords, phishing, or safe browsing.";

            return lastTopic switch
            {
                "password" => $"Here's another password tip, {userName}: Consider using a passphrase — a string of random words like 'PurpleCloud9Rocket' which is long but easy to remember!",
                "phishing" => $"Another phishing tip, {userName}: Always check the sender's email address carefully. Scammers often use addresses like 'support@amaz0n.com' to trick you.",
                "browsing" => $"Another browsing tip, {userName}: Use a VPN when connecting to public Wi-Fi to encrypt your internet traffic.",
                "links" => $"Another tip about links, {userName}: Use virustotal.com to scan suspicious URLs before clicking them.",
                "fraud" => $"Another fraud tip, {userName}: Set up transaction alerts on your bank account so you're notified of any unusual activity immediately.",
                "privacy" => $"Another privacy tip, {userName}: Review your social media privacy settings regularly and limit what personal info is publicly visible.",
                _ => $"Here's a general tip, {userName}: Always keep your software and operating system updated — many cyberattacks exploit outdated software vulnerabilities."
            };
        }
    }
}