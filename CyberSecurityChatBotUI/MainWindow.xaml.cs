using System;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace CyberSecurityChatBotUI
{
    public partial class MainWindow : Window
    {
        private ChatBot Bot;

        public MainWindow()
        {
            InitializeComponent();

            Bot = new ChatBot();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                SoundPlayer player = new SoundPlayer("welcome.wav");
                player.PlaySync();
            }

            AddMessage(Bot.GetGreeting(), false);
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            string input = InputBox.Text;

            if (string.IsNullOrWhiteSpace(input))
                return;

            AddMessage(input, true);

            string response = Bot.ProcessInput(input);

            AddMessage(response, false);

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
                bubble.Background = new SolidColorBrush(Color.FromRgb(34, 197, 94));
                bubble.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else
            {
                bubble.Background = new SolidColorBrush(Color.FromRgb(30, 41, 59));
                bubble.HorizontalAlignment = HorizontalAlignment.Left;
            }

            ChatPanel.Children.Add(bubble);
        }
    }
}