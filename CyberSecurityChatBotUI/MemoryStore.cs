namespace CyberSecurityChatbotUI
{
    public class MemoryStore
    {
        // ensure non-null default to avoid CS8618 in older language versions
        public string UserName { get; set; } = string.Empty;

        public string GetMemoryResponse()
        {
            if (!string.IsNullOrEmpty(UserName))
                return $"Welcome back, {UserName}!";

            return "";
        }
    }
}