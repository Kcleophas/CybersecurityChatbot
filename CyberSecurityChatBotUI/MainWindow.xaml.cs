using CyberSecurityChatbotUI;
using System;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Runtime.InteropServices; // added

namespace CyberSecurityChatBotUI
{
    public partial class MainWindow : Window
    {
        public ResponseManager Bot { get => Bot1; set => Bot1 = value; }
        public ResponseManager Bot1 { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Bot = new ResponseManager();

            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) // changed
            {
            }
            else
            {
                SoundPlayer player = new SoundPlayer("welcome.wav");
                player.PlaySync();
            }

            AddMessage("Bot: Hello!", false);
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            string input = InputBox.Text;

            if (string.IsNullOrWhiteSpace(input))
                return;

            AddMessage(input, true);

            AddMessage("Bot: Message received securely 🔐", false);


            InputBox.Clear();
        }
        private void AddMessage(string message, bool isUser)
        {
            TextBlock text = new TextBlock
            {
                Text = message,
                Foreground = Brushes.White,
                TextWrapping = TextWrapping.Wrap,
                FontSize = 14
            };

            Border bubble = new Border
            {
                Child = text,
                Padding = new Thickness(10),
                Margin = new Thickness(5),
                CornerRadius = new CornerRadius(10),
                MaxWidth = 600
            };

            if (isUser)
            {
                bubble.Background = new SolidColorBrush(Color.FromRgb(34, 197, 94)); // green
                bubble.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else
            {
                bubble.Background = new SolidColorBrush(Color.FromRgb(30, 41, 59)); // dark
                bubble.HorizontalAlignment = HorizontalAlignment.Left;
            }

            ChatPanel.Children.Add(bubble); // ✅ THIS replaces AppendText
        }
    }
}