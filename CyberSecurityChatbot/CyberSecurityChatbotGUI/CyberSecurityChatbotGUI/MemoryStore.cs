namespace CyberSecurityChatbotGUI
{
    public class MemoryStore
    {
        public string UserName { get; set; }

        public string FavouriteTopic { get; set; }

        public void RememberTopic(string input)
        {
            input = input.ToLower();

            if (input.Contains("privacy"))
            {
                FavouriteTopic = "privacy";
            }

            if (input.Contains("password"))
            {
                FavouriteTopic = "password security";
            }

            if (input.Contains("phishing"))
            {
                FavouriteTopic = "phishing";
            }

            if (input.Contains("malware"))
            {
                FavouriteTopic = "malware";
            }
        }

        public string GetMemoryResponse()
        {
            if (!string.IsNullOrEmpty(FavouriteTopic))
            {
                return $"As someone interested in {FavouriteTopic}, ";
            }

            return "";
        }
    }
}