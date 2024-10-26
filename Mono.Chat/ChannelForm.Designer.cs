namespace Mono.Chat
{
    partial class ChannelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chatHeader1 = new ChatHeader();
            cfPanel = new Panel();
            SuspendLayout();
            // 
            // chatHeader1
            // 
            chatHeader1.Dock = DockStyle.Top;
            chatHeader1.Location = new Point(0, 0);
            chatHeader1.Name = "chatHeader1";
            chatHeader1.Size = new Size(800, 106);
            chatHeader1.TabIndex = 0;
            // 
            // cfPanel
            // 
            cfPanel.Dock = DockStyle.Fill;
            cfPanel.Location = new Point(0, 106);
            cfPanel.Name = "cfPanel";
            cfPanel.Size = new Size(800, 422);
            cfPanel.TabIndex = 1;
            // 
            // ChannelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(cfPanel);
            Controls.Add(chatHeader1);
            Name = "ChannelForm";
            Text = "ChannelForm";
            ResumeLayout(false);
        }

        #endregion

        private ChatHeader chatHeader1;
        public Panel cfPanel;
    }
}