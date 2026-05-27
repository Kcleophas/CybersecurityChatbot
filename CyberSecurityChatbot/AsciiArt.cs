using System;

namespace CyberSecurityChatbot
{
    public class AsciiArt
    {
        public static void Show()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("════════════════════════════════════════════════════");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      🔐 CYBERSECURITY AWARENESS BOT 🔐");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("════════════════════════════════════════════════════");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        🛡 Protect   🔍 Detect   ⚡ Respond");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("════════════════════════════════════════════════════\n");

            Console.ResetColor();
        }
    }
}