namespace CyberBot
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            subtitleLabel = new Label();
            logoLabel = new Label();
            chatPanel = new Panel();
            chatBox = new RichTextBox();
            inputPanel = new Panel();
            sendButton = new Button();
            inputBox = new TextBox();
            namePanel = new Panel();
            startButton = new Button();
            nameBox = new TextBox();
            nameLabel = new Label();
            statusLabel = new Label();
            headerPanel.SuspendLayout();
            chatPanel.SuspendLayout();
            inputPanel.SuspendLayout();
            namePanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 17, 23);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(logoLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10);
            headerPanel.Size = new Size(947, 130);
            this.headerPanel.Height = 160;
            // 
            // subtitleLabel
            // 
            subtitleLabel.Dock = DockStyle.Bottom;
            subtitleLabel.Font = new Font("Courier New", 9F);
            subtitleLabel.ForeColor = Color.FromArgb(0, 200, 100);
            subtitleLabel.Location = new Point(10, 80);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(927, 40);
            subtitleLabel.TabIndex = 0;
            subtitleLabel.Text = "━━━  Cybersecurity Awareness Assistant  |  Keeping South Africa Cyber Safe  ━━━";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoLabel
            // 
            this.logoLabel.Text = "  ██████╗██╗   ██╗██████╗ ███████╗██████╗ ██████╗  ██████╗ ████████╗\n ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗╚══██╔══╝\n ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██████╔╝██║   ██║   ██║\n ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██╔══██╗██║   ██║   ██║\n ╚██████╗   ██║   ██████╔╝███████╗██║  ██║██████╔╝╚██████╔╝   ██║\n  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝   ╚═╝";
            this.logoLabel.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.logoLabel.ForeColor = System.Drawing.Color.Cyan;
            this.logoLabel.AutoSize = false;
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoLabel.Height = 110;
            // 
            // chatPanel
            // 
            chatPanel.Controls.Add(chatBox);
            chatPanel.Dock = DockStyle.Fill;
            chatPanel.Location = new Point(0, 130);
            chatPanel.Name = "chatPanel";
            chatPanel.Padding = new Padding(10);
            chatPanel.Size = new Size(947, 465);
            chatPanel.TabIndex = 1;
            chatPanel.Visible = false;
            // 
            // chatBox
            // 
            chatBox.BackColor = Color.FromArgb(13, 17, 23);
            chatBox.BorderStyle = BorderStyle.None;
            chatBox.Dock = DockStyle.Fill;
            chatBox.Font = new Font("Courier New", 10F);
            chatBox.ForeColor = Color.White;
            chatBox.Location = new Point(10, 10);
            chatBox.Name = "chatBox";
            chatBox.ReadOnly = true;
            chatBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            chatBox.Size = new Size(927, 445);
            chatBox.TabIndex = 0;
            chatBox.Text = "";
            // 
            // inputPanel
            // 
            inputPanel.BackColor = Color.FromArgb(22, 27, 34);
            inputPanel.Controls.Add(sendButton);
            inputPanel.Controls.Add(inputBox);
            inputPanel.Dock = DockStyle.Bottom;
            inputPanel.Location = new Point(0, 595);
            inputPanel.Name = "inputPanel";
            inputPanel.Padding = new Padding(10, 8, 10, 8);
            inputPanel.Size = new Size(947, 60);
            inputPanel.TabIndex = 2;
            inputPanel.Visible = false;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.Cyan;
            sendButton.Dock = DockStyle.Right;
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.Font = new Font("Courier New", 10F, FontStyle.Bold);
            sendButton.ForeColor = Color.Black;
            sendButton.Location = new Point(837, 8);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(100, 44);
            sendButton.TabIndex = 0;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += SendButton_Click;
            
            // inputBox
            
            inputBox.BackColor = Color.FromArgb(13, 17, 23);
            inputBox.BorderStyle = BorderStyle.FixedSingle;
            inputBox.Dock = DockStyle.Fill;
            inputBox.Font = new Font("Courier New", 11F);
            inputBox.ForeColor = Color.White;
            inputBox.Location = new Point(10, 8);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(927, 28);
            inputBox.TabIndex = 1;
            inputBox.KeyPress += InputBox_KeyPress;
            // 
            // namePanel
            // 
            namePanel.BackColor = Color.FromArgb(22, 27, 34);
            namePanel.BorderStyle = BorderStyle.FixedSingle;
            namePanel.Controls.Add(startButton);
            namePanel.Controls.Add(nameBox);
            namePanel.Controls.Add(nameLabel);
            namePanel.Location = new Point(250, 250);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(400, 180);
            namePanel.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(0, 200, 100);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Courier New", 10F, FontStyle.Bold);
            startButton.ForeColor = Color.Black;
            startButton.Location = new Point(60, 120);
            startButton.Name = "startButton";
            startButton.Size = new Size(280, 40);
            startButton.TabIndex = 0;
            startButton.Text = "Start Chat";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.FromArgb(13, 17, 23);
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Courier New", 11F);
            nameBox.ForeColor = Color.White;
            nameBox.Location = new Point(60, 70);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(280, 28);
            nameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Courier New", 10F);
            nameLabel.ForeColor = Color.Cyan;
            nameLabel.Location = new Point(10, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(380, 40);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Welcome! Please enter your name:";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Bottom;
            statusLabel.Font = new Font("Courier New", 8F);
            statusLabel.ForeColor = Color.Gray;
            statusLabel.Location = new Point(0, 655);
            statusLabel.Name = "statusLabel";
            statusLabel.Padding = new Padding(0, 0, 10, 0);
            statusLabel.Size = new Size(947, 20);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Ready";
            statusLabel.TextAlign = ContentAlignment.MiddleRight;
            statusLabel.Visible = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(947, 675);
            Controls.Add(namePanel);
            Controls.Add(chatPanel);
            Controls.Add(inputPanel);
            Controls.Add(statusLabel);
            Controls.Add(headerPanel);
            Name = "MainForm";
            headerPanel.ResumeLayout(false);
            chatPanel.ResumeLayout(false);
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            namePanel.ResumeLayout(false);
            namePanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}