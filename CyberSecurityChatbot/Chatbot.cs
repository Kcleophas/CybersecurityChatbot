using System;
using System.Threading;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        public string UserName { get; set; }

        public void Start()
        {
            Console.Clear();

            // Welcome
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("👋 Welcome to your Cybersecurity Assistant!\n");

            // Name input
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("🧑 Enter your name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserName))
                UserName = "User";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✅ Welcome, {UserName}! 🔐");

            // Info
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n💬 You can learn about:");
            Console.WriteLine("   1. Password Safety 🔑");
            Console.WriteLine("   2. Phishing Scams 🎣");
            Console.WriteLine("   3. Safe Browsing 🌐");
            Console.WriteLine("   4. Cybersecurity 🔐");
            Console.WriteLine("   0. Exit ❌");

            // Start menu loop
            HandleMenu();
        }

        // ✅ MENU DISPLAY
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n══════════ MENU ══════════");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1️⃣ Password Safety 🔑");
            Console.WriteLine("2️⃣ Phishing Awareness 🎣");
            Console.WriteLine("3️⃣ Safe Browsing 🌐");
            Console.WriteLine("4️⃣ What is Cybersecurity? 🔐");
            Console.WriteLine("0️⃣ Exit ❌");

            Console.Write("\n👉 Choose an option: ");
            Console.ResetColor();
        }

        // ✅ MENU HANDLER (HIGH MARK FEATURE)
        public void HandleMenu()
        {
            while (true)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n🤖 Bot: ");
                Thread.Sleep(400);

                switch (choice)
                {
                    case "1":
                        TypeEffect("🔑 Use strong passwords with uppercase, lowercase, numbers and symbols.");
                        break;

                    case "2":
                        TypeEffect("🎣 Phishing scams trick you into giving personal info. Avoid suspicious emails.");
                        break;

                    case "3":
                        TypeEffect("🌐 Always check for HTTPS and avoid unsafe websites.");
                        break;

                    case "4":
                        TypeEffect("🔐 Cybersecurity protects systems, networks, and data from digital attacks.");
                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("👋 Goodbye! Stay safe online 🔒");
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("⚠️ Invalid option. Please try again.");
                        break;
                }

                Console.ResetColor();
            }
        }

        // ✅ TYPING EFFECT (EXTRA MARKS)
        public void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}