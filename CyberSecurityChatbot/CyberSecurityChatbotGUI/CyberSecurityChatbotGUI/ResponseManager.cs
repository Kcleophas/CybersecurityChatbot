using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot

{
    public class ResponseManager
    {
        private Random random = new Random();

        private List<string> loadingMessages =
            new List<string>
            {
                "Analyzing cybersecurity threat...",
                "Scanning security database...",
                "Encrypting secure response...",
                "Running malware detection..."
            };

        private List<string> fallbackResponses =
            new List<string>
            {
                "Please ask a cybersecurity question.",
                "I can help with phishing, malware, passwords, and privacy.",
                "Try rephrasing your cybersecurity question.",
                "I am still learning that topic."
            };

        public string GetLoadingMessage()
        {
            return loadingMessages[
                random.Next(loadingMessages.Count)];
        }

        public string GetFallbackResponse()
        {
            return fallbackResponses[
                random.Next(fallbackResponses.Count)];
        }
    }
}