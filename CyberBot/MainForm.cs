using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace CyberBot
{
    public partial class MainForm : Form
    {
        // (Baeldung, 2023) - storing user session data as fields
        private string userName = "";
        private string lastTopic = "";

        public MainForm()
        {
            InitializeComponent();
            SetupForm();
            PlayVoiceGreeting();
        }

        private void SetupForm()
        {
            this.Text = "CyberBot - Cybersecurity Awareness Assistant";
            this.BackColor = Color.FromArgb(13, 17, 23);
            this.Size = new Size(900, 700);
            this.MinimumSize = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Resize += (s, e) =>
            {
                namePanel.Location = new Point(
                    (this.ClientSize.Width - namePanel.Width) / 2,
                    (this.ClientSize.Height - namePanel.Height) / 2
                );
            };

            // Initial centering
            namePanel.Location = new Point(
                (this.ClientSize.Width - namePanel.Width) / 2,
                (this.ClientSize.Height - namePanel.Height) / 2
            );
        }

        // Q1 - Voice greeting on launch
        // (Microsoft, 2023) - SoundPlayer for WAV playback
        private void PlayVoiceGreeting()
        {
            try
            {
#pragma warning disable CA1416
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Play();
#pragma warning restore CA1416
            }
            catch { }
        }

        // Start button click - get name and show chat
        private void StartButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                nameLabel.Text = "Please enter your name to continue:";
                nameLabel.ForeColor = Color.Red;
                return;
            }

            userName = name;
            namePanel.Visible = false;
            chatPanel.Visible = true;
            inputPanel.Visible = true;
            statusLabel.Visible = true;

            ShowWelcomeMessage();
            inputBox.Focus();
        }

        // Show welcome message in chat
        private void ShowWelcomeMessage()
        {
            AppendMessage("CyberBot", $"Hello, {userName}! Welcome to CyberBot.", Color.FromArgb(0, 200, 100));
            AppendMessage("CyberBot", "I'm here to help you stay safe online.", Color.FromArgb(0, 200, 100));
            AppendMessage("CyberBot", "You can ask me about:", Color.FromArgb(0, 200, 100));
            AppendMessage("CyberBot", "  🔒 Password safety", Color.FromArgb(0, 200, 100));
            AppendMessage("CyberBot", "  🎣 Phishing scams", Color.FromArgb(0, 200, 100));
            AppendMessage("CyberBot", "  🌐 Safe browsing", Color.FromArgb(0, 200, 100));
            AppendMessage("CyberBot", "  ⚠️  Suspicious links", Color.FromArgb(0, 200, 100));
            AppendMessage("CyberBot", "  💳 Online fraud", Color.FromArgb(0, 200, 100));
            AppendDivider();
        }

        // Send button click
        private void SendButton_Click(object sender, EventArgs e)
        {
            ProcessInput();
        }

        // Enter key to send
        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ProcessInput();
                e.Handled = true;
            }
        }

        // Process user input - Q2, Q3, Q4, Q5, Q6, Q7
        private void ProcessInput()
        {
            string input = inputBox.Text.Trim();
            inputBox.Clear();

            // Q7 - Error handling: empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                AppendMessage("CyberBot", "Please type something before sending!", Color.Orange);
                return;
            }

            // Show user message
            AppendMessage(userName, input, Color.Yellow);

            string lower = input.ToLower();

            // Q6 - Sentiment detection
            string sentimentResponse = SentimentDetector.Detect(lower, userName);
            if (sentimentResponse != null)
            {
                AppendMessage("CyberBot", sentimentResponse, Color.FromArgb(0, 200, 100));
                // Also provide topic info automatically
                string topicResponse = Responses.GetResponse(lower, userName, lastTopic, out string detectedTopic);
                lastTopic = detectedTopic;
                if (topicResponse != null)
                    AppendMessage("CyberBot", topicResponse, Color.FromArgb(0, 200, 100));
                AppendDivider();
                return;
            }

            // Q4 - Conversation flow: follow-up questions
            if (ConversationFlow.IsFollowUp(lower))
            {
                string followUp = ConversationFlow.GetFollowUp(lower, lastTopic, userName);
                AppendMessage("CyberBot", followUp, Color.FromArgb(0, 200, 100));
                AppendDivider();
                return;
            }

            // Q2 + Q3 + Q5 - Keyword recognition, random responses, memory
            string response = Responses.GetResponse(lower, userName, lastTopic, out string topic);
            lastTopic = topic;

            AppendMessage("CyberBot", response, Color.FromArgb(0, 200, 100));
            AppendDivider();
        }

        // Helper - append a message to chat box with colour
        // (Microsoft, 2023) - RichTextBox colour formatting
        public void AppendMessage(string sender, string message, Color color)
        {
            chatBox.SelectionStart = chatBox.TextLength;
            chatBox.SelectionLength = 0;
            chatBox.SelectionColor = color;
            chatBox.AppendText($"[{sender}]: {message}\n");
            chatBox.SelectionColor = chatBox.ForeColor;
            chatBox.ScrollToCaret();
            statusLabel.Text = $"Last message: {DateTime.Now:HH:mm:ss}";
        }

        // Helper - append a divider line
        public void AppendDivider()
        {
            chatBox.SelectionColor = Color.FromArgb(50, 50, 50);
            chatBox.AppendText("─────────────────────────────────────────\n");
            chatBox.SelectionColor = chatBox.ForeColor;
        }
    }
}