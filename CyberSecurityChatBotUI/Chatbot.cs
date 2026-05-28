using System;
using System.Collections.Generic;

namespace CyberSecurityChatbotGUI
{
    public class Chatbot
    {
        private Dictionary<string, List<string>> responses;

        public Chatbot()
        {
            responses = new Dictionary<string, List<string>>()
            {
                { "hello", new List<string>
                    {
                        "Hello! Stay safe online.",
                        "Hi there! Need cybersecurity help?",
                        "Hey! I'm here to protect you."
                    }
                },

                { "password", new List<string>
                    {
                        "Use strong passwords with symbols and numbers.",
                        "Never reuse passwords across sites.",
                        "A good password has 12+ characters."
                    }
                },

                { "phishing", new List<string>
                    {
                        "Phishing is when attackers trick you into giving info.",
                        "Never click suspicious email links.",
                        "Check sender emails carefully."
                    }
                },

                { "virus", new List<string>
                    {
                        "Use antivirus software regularly.",
                        "Avoid downloading unknown files.",
                        "Keep your system updated."
                    }
                },

                { "help", new List<string>
                    {
                        "Ask me about passwords, phishing, or viruses.",
                        "I can teach you basic cyber safety.",
                        "Try typing: password, phishing, virus"
                    }
                }
            };
        }

        public string GetResponse(string input)
        {
            foreach (var key in responses.Keys)
            {
                if (input.Contains(key))
                {
                    Random rand = new Random();
                    var list = responses[key];
                    return list[rand.Next(list.Count)];
                }
            }

            return "I'm not sure about that. Try asking about passwords, phishing, or viruses.";
        }
    }
}