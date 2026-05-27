using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Play voice
            AudioPlayer.Play();

            // Show logo
            AsciiArt.Show();

            // Start chatbot
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}
