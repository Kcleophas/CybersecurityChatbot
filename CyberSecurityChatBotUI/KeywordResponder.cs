namespace CyberSecurityChatbotGUI
{
    public class KeywordResponder
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("password"))
                return "Use strong unique passwords.";

            if (input.Contains("phishing"))
                return "Never click suspicious email links.";

            if (input.Contains("virus"))
                return "Keep antivirus software updated.";

            if (input.Contains("scam"))
                return "Be cautious of suspicious offers.";

            return "";
        }
    }
}