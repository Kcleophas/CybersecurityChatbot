using System;
using System.Text;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console settings
            Console.Title = "Cybersecurity Awareness Bot";
            Console.OutputEncoding = Encoding.UTF8;

            // Play voice greeting
            try
            {
                AudioPlayer.Play();
            }
            catch
            {
                Console.WriteLine("Voice greeting could not play.");
            }
             
            // Show ASCII Art
            AsciiArt.Show();

            // Pause so user can see art
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to launch the chatbot...");
            Console.ResetColor();

            Console.ReadLine();

            // Clear screen before chatbot starts
            Console.Clear();

            // Start chatbot
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}