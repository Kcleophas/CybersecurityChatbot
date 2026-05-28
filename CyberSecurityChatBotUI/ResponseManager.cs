namespace CyberSecurityChatbotGUI
{
    public class ResponseManager
    {
        public string GetLoadingResponse()
        {
            return "Thinking...";
        }

        public string GetFallbackResponse()
        {
            return "I'm not sure how to respond to that yet.";
        }
    }
}