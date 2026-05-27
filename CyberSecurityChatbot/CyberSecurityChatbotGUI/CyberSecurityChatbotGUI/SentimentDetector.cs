using System.Collections.Generic;

namespace CyberSecurityChatbotGUI
{
    public enum Sentiment
    {
        Neutral,
        Worried,
        Curious,
        Frustrated,
        Happy
    }

    public class SentimentDetector
    {
        private Dictionary<Sentiment, List<string>> sentimentKeywords;

        public SentimentDetector()
        {
            sentimentKeywords =
                new Dictionary<Sentiment, List<string>>();

            sentimentKeywords.Add(Sentiment.Worried,
                new List<string>
                {
                    "worried",
                    "scared",
                    "afraid",
                    "nervous",
                    "unsafe"
                });

            sentimentKeywords.Add(Sentiment.Curious,
                new List<string>
                {
                    "curious",
                    "interested",
                    "wondering",
                    "learn",
                    "how"
                });

            sentimentKeywords.Add(Sentiment.Frustrated,
                new List<string>
                {
                    "frustrated",
                    "confused",
                    "annoyed",
                    "angry"
                });

            sentimentKeywords.Add(Sentiment.Happy,
                new List<string>
                {
                    "great",
                    "awesome",
                    "happy",
                    "thanks"
                });
        }

        public Sentiment Detect(string input)
        {
            input = input.ToLower();

            foreach (var item in sentimentKeywords)
            {
                foreach (string word in item.Value)
                {
                    if (input.Contains(word))
                    {
                        return item.Key;
                    }
                }
            }

            return Sentiment.Neutral;
        }

        public string GetSentimentResponse(Sentiment sentiment)
        {
            switch (sentiment)
            {
                case Sentiment.Worried:
                    return "It is understandable to feel worried. Let me help you stay safe online. ";

                case Sentiment.Curious:
                    return "That is a great question. Cybersecurity awareness is important. ";

                case Sentiment.Frustrated:
                    return "Cybersecurity can feel confusing sometimes, but I will explain clearly. ";

                case Sentiment.Happy:
                    return "I am glad you are enjoying cybersecurity awareness. ";

                default:
                    return "";
            }
        }
    }
}