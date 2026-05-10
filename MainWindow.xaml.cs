
using System.Windows;
using CyberSecurityChatBotGUI.Classes;

namespace CyberSecurityChatBotGUI
{
    public partial class MainWindow : Window
    {
        private ChatBot bot = new ChatBot();
        private MessageHandler displayMessage;

        public MainWindow()
        {
            AudioPlayer.PlayGreeting();

            InitializeComponent();

            displayMessage = ShowMessage;

            ChatDisplay.Text += "🤖 Bot: Hello! Welcome to the CyberSecurity Awareness Bot.\n\n";
        }
        private void ShowMessage(string message)
        {
            ChatDisplay.Text += message + "\n";
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userMessage = UserInput.Text;

            if (string.IsNullOrWhiteSpace(userMessage))
            {
                return;
            }

            // DISPLAY USER MESSAGE
            displayMessage($"🧑 You: {userMessage}");

            // GET BOT RESPONSE
            string response = bot.GetResponse(userMessage);

            // DISPLAY BOT RESPONSE
            displayMessage($"🤖 Bot: {response}\n");

            // CLEAR INPUT
            UserInput.Clear();
        }
    }
}