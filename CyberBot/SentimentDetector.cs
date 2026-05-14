using System;
using System.Collections.Generic;
using System.Text;

namespace CyberBot
{
    // summary
    // Detects user sentiment from input and returns empathetic responses.
    // Covers worried, frustrated, curious, angry and happy sentiments.
    // (GeeksforGeeks, 2023) - keyword-based sentiment analysis
    public static class SentimentDetector
    {
        // (GeeksforGeeks, 2023) - keyword-based sentiment detection
        public static string? Detect(string input, string userName)
        {
            if (input.Contains("worried") || input.Contains("scared") || input.Contains("afraid"))
                return $"It's completely understandable to feel that way, {userName}. Cyber threats can be overwhelming, but knowledge is your best defence. Let me help!";

            if (input.Contains("frustrated") || input.Contains("confused") || input.Contains("don't understand"))
                return $"I'm sorry you're feeling frustrated, {userName}. Let me try to explain things more clearly for you.";

            if (input.Contains("curious") || input.Contains("want to know"))
                return $"Great curiosity, {userName}! Wanting to learn is the first step to staying safe online.";

            if (input.Contains("angry") || input.Contains("annoyed"))
                return $"I understand your frustration, {userName}. Cybercrime is genuinely upsetting. Let me share some tips to help you feel more in control.";

            if (input.Contains("happy") || input.Contains("great") || input.Contains("good"))
                return $"Glad to hear you're feeling good, {userName}! Let's keep that energy going by staying cyber safe!";

            return null; //no sentiment detect
        }
    }
}