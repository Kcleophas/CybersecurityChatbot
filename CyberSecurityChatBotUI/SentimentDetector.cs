namespace CyberSecurityChatbotUI
{
    public enum Sentiment
    {
        Positive,
        Negative,
        Neutral
    }

    public class SentimentDetector
    {
        public Sentiment Detect(string input)
        {
            input = input.ToLower();

            if (input.Contains("happy") || input.Contains("good"))
                return Sentiment.Positive;

            if (input.Contains("sad") || input.Contains("bad"))
                return Sentiment.Negative;

            return Sentiment.Neutral;
        }

        public string GetSentimentResponse(Sentiment sentiment)
        {
            // Replaced switch expression with classic switch statement for C# 7.3 compatibility
            switch (sentiment)
            {
                case Sentiment.Positive:
                    return "Glad you're feeling positive!";
                case Sentiment.Negative:
                    return "I'm sorry you're having a tough time.";
                case Sentiment.Neutral:
                    return "I understand.";
                default:
                    return "I understand.";
            }
        }
    }
}