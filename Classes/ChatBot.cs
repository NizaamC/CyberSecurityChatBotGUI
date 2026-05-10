using System;
using System.Collections.Generic;

namespace CyberSecurityChatBotGUI.Classes
{
    public class ChatBot
    {
        private Random random = new Random();

        // MEMORY
        private string favoriteTopic = "";
        private string lastTopic = "";

        // RESPONSES
        private Dictionary<string, List<string>> responses =
            new Dictionary<string, List<string>>()
        {
            {
                "password",
                new List<string>()
                {
                    "Use strong passwords with letters, numbers, and symbols.",
                    "Avoid using personal details in your passwords.",
                    "Use a different password for every account."
                }
            },

            {
                "phishing",
                new List<string>()
                {
                    "Be cautious of emails asking for personal information.",
                    "Never click suspicious links from unknown senders.",
                    "Phishing scams often pretend to be trusted companies."
                }
            },

            {
                "privacy",
                new List<string>()
                {
                    "Review your privacy settings regularly.",
                    "Avoid sharing sensitive information publicly online.",
                    "Use two-factor authentication for extra protection."
                }
            },

            {
                "scam",
                new List<string>()
                {
                    "Online scams often create urgency to trick victims.",
                    "Never send money to unverified people online.",
                    "Scammers may pretend to be banks or companies."
                }
            }
        };

        public string GetResponse(string input)
        {
            input = input.ToLower();
            // SENTIMENT DETECTION

            if (input.Contains("worried") ||
                input.Contains("scared") ||
                input.Contains("frustrated"))
            {
                return "It's understandable to feel that way. Cybersecurity threats can be stressful.\n\nTip: Stay cautious online, avoid suspicious links, and keep your accounts secure.";
            }

            if (input.Contains("curious") ||
                input.Contains("interested"))
            {
                return "Curiosity is great when learning about cybersecurity! Staying informed helps you stay protected online.";
            }

            if (input.Contains("confused"))
            {
                return "No problem — cybersecurity can sometimes feel complicated.\n\nTry asking about passwords, phishing, scams, or privacy.";
            }

            // MEMORY DETECTION
            if (input.Contains("i like"))
            {
                foreach (var topic in responses.Keys)
                {
                    if (input.Contains(topic))
                    {
                        favoriteTopic = topic;

                        return $"Great! I'll remember that you're interested in {topic}.";
                    }
                }
            }

            // FOLLOW-UP RESPONSES
            if (input.Contains("tell me more") ||
                input.Contains("another tip") ||
                input.Contains("explain more"))
            {
                if (lastTopic != "")
                {
                    return GetRandomResponse(lastTopic);
                }

                return "Can you tell me which cybersecurity topic you'd like to know more about?";
            }

            // KEYWORD RECOGNITION
            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    lastTopic = keyword;

                    string response = GetRandomResponse(keyword);

                    // PERSONALIZATION
                    if (favoriteTopic == keyword)
                    {
                        response += $"\n\nSince you're interested in {keyword}, remember to stay extra cautious online.";
                    }

                    return response;
                }
            }

            return "I'm not sure I understand. Can you try rephrasing?";
        }

        private string GetRandomResponse(string topic)
        {
            List<string> possibleResponses = responses[topic];

            int index = random.Next(possibleResponses.Count);

            return possibleResponses[index];
        }
    }
}