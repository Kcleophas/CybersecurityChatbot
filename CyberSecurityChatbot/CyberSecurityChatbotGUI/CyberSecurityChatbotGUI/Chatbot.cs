using System;

namespace CyberSecurityChatbotGUI
{
    public class ChatBot
    {
        //-----------------------------------------
        // FIELDS
        //-----------------------------------------

        private readonly KeywordResponder _keywordResponder;

        private readonly SentimentDetector _sentimentDetector;

        private readonly MemoryStore _memoryStore;

        private readonly ResponseManager _responseManager;

        private bool _awaitingName = true;

        private string _lastTopic = "";

        //-----------------------------------------
        // CONSTRUCTOR
        //-----------------------------------------

        public ChatBot()
        {
            _keywordResponder = new KeywordResponder();

            _sentimentDetector = new SentimentDetector();

            _memoryStore = new MemoryStore();

            _responseManager = new ResponseManager();
        }

        //-----------------------------------------
        // GREETING MESSAGE
        //-----------------------------------------

        public string GetGreeting()
        {
            return "Welcome to the Cybersecurity Awareness Assistant.\nWhat is your name?";
        }

        //-----------------------------------------
        // LOADING MESSAGE
        //-----------------------------------------

        public string GetLoadingMessage()
        {
            return _responseManager.GetLoadingResponse();
        }

        //-----------------------------------------
        // MAIN CHATBOT ROUTING METHOD
        //-----------------------------------------

        public string ProcessInput(string input)
        {
            //-----------------------------------------
            // VALIDATE INPUT
            //-----------------------------------------

            if (string.IsNullOrWhiteSpace(input))
            {
                return "Please type a message.";
            }

            string lowerInput =
                input.ToLower().Trim();

            //-----------------------------------------
            // STEP 1 - CAPTURE USER NAME
            //-----------------------------------------

            if (_awaitingName)
            {
                _memoryStore.UserName = input;

                _awaitingName = false;

                return $"Welcome {_memoryStore.UserName}! " +
                       "Ask me anything about cybersecurity.";
            }

            //-----------------------------------------
            // STEP 2 - STORE MEMORY
            //-----------------------------------------

            _memoryStore.RememberTopic(lowerInput);

            //-----------------------------------------
            // STEP 3 - FOLLOW-UP FLOW
            //-----------------------------------------

            if (IsFollowUpRequest(lowerInput))
            {
                return GetFollowUpResponse();
            }

            //-----------------------------------------
            // STEP 4 - SENTIMENT DETECTION
            //-----------------------------------------

            Sentiment sentiment =
                _sentimentDetector.Detect(lowerInput);

            string sentimentResponse =
                _sentimentDetector.GetSentimentResponse(sentiment);

            //-----------------------------------------
            // STEP 5 - KEYWORD RECOGNITION
            //-----------------------------------------

            string keywordResponse =
                _keywordResponder.GetResponse(lowerInput);

            if (!string.IsNullOrWhiteSpace(keywordResponse))
            {
                _lastTopic = lowerInput;

                return BuildResponse(
                    sentimentResponse,
                    _memoryStore.GetMemoryResponse(),
                    keywordResponse
                );
            }

            //-----------------------------------------
            // STEP 6 - SPECIAL QUESTIONS
            //-----------------------------------------

            if (lowerInput.Contains("how are you"))
            {
                return "I am functioning optimally and ready to assist you.";
            }

            if (lowerInput.Contains("purpose"))
            {
                return "My purpose is to educate users about cybersecurity awareness.";
            }

            if (lowerInput.Contains("what can you do"))
            {
                return "I can help with phishing, malware, passwords, scams, privacy, and online safety.";
            }

            //-----------------------------------------
            // STEP 7 - FALLBACK RESPONSE
            //-----------------------------------------

            return _responseManager.GetFallbackResponse();
        }

        //-----------------------------------------
        // FOLLOW-UP DETECTION
        //-----------------------------------------

        private bool IsFollowUpRequest(string input)
        {
            return input.Contains("tell me more") ||
                   input.Contains("more") ||
                   input.Contains("explain more") ||
                   input.Contains("continue");
        }

        //-----------------------------------------
        // FOLLOW-UP RESPONSES
        //-----------------------------------------

        private string GetFollowUpResponse()
        {
            if (_lastTopic.Contains("password"))
            {
                return "Password managers can help generate and securely store strong passwords.";
            }

            if (_lastTopic.Contains("phishing"))
            {
                return "Phishing attacks often create urgency to trick users into clicking fake links.";
            }

            if (_lastTopic.Contains("privacy"))
            {
                return "Review your app permissions regularly to improve your online privacy.";
            }

            if (_lastTopic.Contains("malware"))
            {
                return "Avoid downloading cracked software because it may contain hidden malware.";
            }

            if (_lastTopic.Contains("scam"))
            {
                return "Online scams often promise rewards or urgent payments to trick victims.";
            }

            return "Cybersecurity awareness helps users stay safe online.";
        }

        //-----------------------------------------
        // RESPONSE BUILDER
        //-----------------------------------------

        private string BuildResponse(
            string sentiment,
            string memory,
            string keyword)
        {
            return sentiment +
                   memory +
                   keyword;
        }
    }
}