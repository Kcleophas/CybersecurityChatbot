using System;
using System.IO;
using System.Media;

namespace CyberSecurityChatbot
{
    public class AudioPlayer
    {
        public static void Play()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "greeting.wav");

                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("⚠️ greeting.wav not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio error: " + ex.Message);
            }
        }
    }
}