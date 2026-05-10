using System.Media;

namespace CyberSecurityChatBotGUI.Classes
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Assets/Greeting.wav");

                player.Load();

                player.Play();
            }
            catch
            {

            }
        }
    }
}
