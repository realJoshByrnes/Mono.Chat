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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
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
            cfPanel.Size = new Size(800, 400);
            cfPanel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(214, 67, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 506);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(242, 17);
            toolStripStatusLabel1.Text = "  Try MSN Internet Software for FREE!";
            // 
            // ChannelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(cfPanel);
            Controls.Add(chatHeader1);
            Controls.Add(statusStrip1);
            Name = "ChannelForm";
            Text = "ChannelForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ChatHeader chatHeader1;
        public Panel cfPanel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}