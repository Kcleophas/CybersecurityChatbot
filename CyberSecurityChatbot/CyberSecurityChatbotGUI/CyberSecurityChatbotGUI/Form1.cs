using System;
using System.Media;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSecurityChatbot
{
    public partial class Form1 : Form
    {
        //-------------------------------------------------
        // ONLY FIELD REQUIRED HERE
        //-------------------------------------------------

        private ChatBot _chatBot;

        private SpeechSynthesizer _speaker =
            new SpeechSynthesizer();

        //-------------------------------------------------
        // CONSTRUCTOR
        //-------------------------------------------------

        public Form1()
        {
            InitializeComponent();

            _chatBot = new ChatBot();

            LoadAsciiArt();

            PlayVoiceGreeting();

            _ = AppendBotMessage(
                _chatBot.GetGreeting());
        }

        //-------------------------------------------------
        // ASCII ART
        //-------------------------------------------------

        private void LoadAsciiArt()
        {
            lblAscii.Text =
@" ██████╗██╗   ██╗██████╗ ███████╗██████╗
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
╚██████╗   ██║   ██████╔╝███████╗██║  ██║
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝

[ CYBERSECURITY AWARENESS TERMINAL ]";
        }

        //-------------------------------------------------
        // VOICE GREETING
        //-------------------------------------------------

        private void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player =
                    new SoundPlayer("greeting.wav");

                player.Play();
            }
            catch
            {
            }
        }

        //-------------------------------------------------
        // SEND BUTTON
        //-------------------------------------------------

        private async void btnSend_Click(
            object sender,
            EventArgs e)
        {
            await SendMessage();
        }

        //-------------------------------------------------
        // ENTER KEY
        //-------------------------------------------------

        private async void txtUserInput_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                await SendMessage();
            }
        }

        //-------------------------------------------------
        // SEND MESSAGE
        //-------------------------------------------------

        private async Task SendMessage()
        {
            string userInput =
                txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                return;
            }

            AppendUserMessage(userInput);

            txtUserInput.Clear();

            string loading =
                _chatBot.GetLoadingMessage();

            await AppendBotMessage(loading);

            await Task.Delay(700);

            string response =
                _chatBot.ProcessInput(userInput);

            await AppendBotMessage(response);
        }

        //-------------------------------------------------
        // USER MESSAGE DISPLAY
        //-------------------------------------------------

        private void AppendUserMessage(string message)
        {
            rtbChat.SelectionColor =
                System.Drawing.Color.Cyan;

            rtbChat.AppendText(
                $"You: {message}\n\n");

            rtbChat.ScrollToCaret();
        }

        //-------------------------------------------------
        // BOT MESSAGE DISPLAY
        //-------------------------------------------------

        private async Task AppendBotMessage(
            string message)
        {
            rtbChat.SelectionColor =
                System.Drawing.Color.Lime;

            rtbChat.AppendText("Bot: ");

            foreach (char c in message)
            {
                rtbChat.AppendText(c.ToString());

                await Task.Delay(15);
            }

            rtbChat.AppendText("\n\n");

            _speaker.SpeakAsync(message);

            rtbChat.ScrollToCaret();
        }
    }
}