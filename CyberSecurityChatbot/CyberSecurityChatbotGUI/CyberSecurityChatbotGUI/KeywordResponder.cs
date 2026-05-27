using System;
using System.Collections.Generic;

namespace CyberSecurityChatbotGUI
{
    public class KeywordResponder
    {
        private Dictionary<string, List<string>> responses;

        private Random random;

        public KeywordResponder()
        {
            random = new Random();

            responses = new Dictionary<string, List<string>>();

            responses.Add("password", new List<string>
            {
                "Use strong passwords with symbols and numbers.",
                "Never reuse the same password for multiple accounts.",
                "Enable two-factor authentication for better security."
            });

            responses.Add("phishing", new List<string>
            {
                "Be careful of suspicious emails asking for personal information.",
                "Do not click unknown links in emails.",
                "Phishing scams often pretend to be trusted companies."
            });

            responses.Add("privacy", new List<string>
            {
                "Review your social media privacy settings regularly.",
                "Avoid sharing sensitive information online.",
                "Use websites with HTTPS encryption."
            });

            responses.Add("scam", new List<string>
            {
                "Never share banking details with strangers online.",
                "Scammers often create urgency to pressure victims.",
                "Verify online sellers before making payments."
            });

            responses.Add("malware", new List<string>
            {
                "Install antivirus software to protect your device.",
                "Avoid downloading files from unknown websites.",
                "Keep your software updated to reduce malware risks."
            });

            responses.Add("vpn", new List<string>
            {
                "VPNs help secure your connection on public Wi-Fi.",
                "A VPN encrypts your internet traffic.",
                "VPNs improve online privacy and security."
            });
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();

            foreach (var item in responses)
            {
                if (input.Contains(item.Key))
                {
                    int index = random.Next(item.Value.Count);

                    return item.Value[index];
                }
            }

            return "";
        }
    }
}