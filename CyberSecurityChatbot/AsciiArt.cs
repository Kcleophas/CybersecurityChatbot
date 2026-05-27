using System;

namespace CyberSecurityChatbot
{
    public class AsciiArt
    {
        //-----------------------------------------
        // MAIN DISPLAY METHOD
        //-----------------------------------------

        public static void Show()
        {
            Console.Clear();

            SetConsoleWindow();

            DrawTopBorder();

            DrawTitleSection();

            DrawAsciiBanner();

            DrawSubtitle();

            DrawFeatures();

            DrawStatusSection();

            DrawFooter();

            LaunchMessage();
        }

        //-----------------------------------------
        // WINDOW SETTINGS
        //-----------------------------------------

        private static void SetConsoleWindow()
        {
            try
            {
                Console.SetWindowSize(140, 45);
                Console.SetBufferSize(140, 45);
            }
            catch
            {
                // Ignore errors if console size cannot be changed
            }
        }

        //-----------------------------------------
        // TOP BORDER
        //-----------------------------------------

        private static void DrawTopBorder()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
        }

        //-----------------------------------------
        // TITLE SECTION
        //-----------------------------------------

        private static void DrawTitleSection()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("║                                                                                                            ║");
            Console.WriteLine("║                         🔐 CYBERSECURITY AWARENESS ASSISTANT 🔐                                           ║");
            Console.WriteLine("║                                                                                                            ║");
        }

        //-----------------------------------------
        // ASCII BANNER
        //-----------------------------------------

        private static void DrawAsciiBanner()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("║   ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗███████╗ ██████╗██╗   ██╗██████╗ ██╗████████╗██╗   ██╗  ║");
            Console.WriteLine("║  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝██╔════╝██╔════╝██║   ██║██╔══██╗██║╚══██╔══╝╚██╗ ██╔╝  ║");
            Console.WriteLine("║  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝███████╗█████╗  ██║     ██║   ██║██████╔╝██║   ██║    ╚████╔╝   ║");
            Console.WriteLine("║  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════██║██╔══╝  ██║     ██║   ██║██╔══██╗██║   ██║     ╚██╔╝    ║");
            Console.WriteLine("║  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████║███████╗╚██████╗╚██████╔╝██║  ██║██║   ██║      ██║     ║");
            Console.WriteLine("║   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝   ╚═╝      ╚═╝     ║");

            Console.WriteLine("║                                                                                                           ║");
        }

        //-----------------------------------------
        // SUBTITLE
        //-----------------------------------------

        private static void DrawSubtitle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("║                            🛡 PROTECT • DETECT • RESPOND 🛡                                                ║");
        }

        //-----------------------------------------
        // FEATURES SECTION
        //-----------------------------------------

        private static void DrawFeatures()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("║                                                                                                             ║");
            Console.WriteLine("║         🔐 PASSWORD SECURITY             🔍 PHISHING DETECTION                                              ║");
            Console.WriteLine("║         🌐 PRIVACY PROTECTION            ⚠ ONLINE SCAM AWARENESS                                           ║");
            Console.WriteLine("║         🔒 SECURE BROWSING               🦠 MALWARE PREVENTION                                              ║");
            Console.WriteLine("║         📧 EMAIL SAFETY                  🛡 TWO-FACTOR AUTHENTICATION                                       ║");

            DrawDivider();
        }

        //-----------------------------------------
        // DIVIDER
        //-----------------------------------------

        private static void DrawDivider()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("╠════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
        }

        //-----------------------------------------
        // STATUS SECTION
        //-----------------------------------------

        private static void DrawStatusSection()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("║                                                                                                            ║");
            Console.WriteLine("║   SYSTEM STATUS : ONLINE              FIREWALL : ACTIVE              THREATS DETECTED : 0                  ║");
            Console.WriteLine("║   SECURITY MODE : ENABLED             VPN STATUS : SECURE            MONITORING : ACTIVE                   ║");
            Console.WriteLine("║                                                                                                            ║");

            DrawDivider();
        }

        //-----------------------------------------
        // FOOTER SECTION
        //-----------------------------------------

        private static void DrawFooter()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("║                                                                                                            ║");
            Console.WriteLine("║                     Stay Smart • Stay Secure • Stay Cyber Aware                                            ║");
            Console.WriteLine("║                                                                                                            ║");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }

        //-----------------------------------------
        // LAUNCH MESSAGE
        //-----------------------------------------

        private static void LaunchMessage()
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("                                  Press ENTER to launch the assistant...");

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}