namespace Mono.Chat
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openInInternetExplorerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            chatFrameTab = new TabControl();
            newToolStripMenuItem = new ToolStripMenuItem();
            channelToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1285, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, settingsToolStripMenuItem, openInInternetExplorerToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = SystemColors.ControlText;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.ForeColor = SystemColors.ControlText;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(205, 22);
            settingsToolStripMenuItem.Text = "&Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // openInInternetExplorerToolStripMenuItem
            // 
            openInInternetExplorerToolStripMenuItem.Enabled = false;
            openInInternetExplorerToolStripMenuItem.ForeColor = SystemColors.ControlText;
            openInInternetExplorerToolStripMenuItem.Name = "openInInternetExplorerToolStripMenuItem";
            openInInternetExplorerToolStripMenuItem.Size = new Size(205, 22);
            openInInternetExplorerToolStripMenuItem.Text = "&Open in Internet Explorer";
            openInInternetExplorerToolStripMenuItem.Click += openInInternetExplorerToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = SystemColors.ControlText;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(205, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // chatFrameTab
            // 
            chatFrameTab.Alignment = TabAlignment.Left;
            chatFrameTab.Dock = DockStyle.Left;
            chatFrameTab.DrawMode = TabDrawMode.OwnerDrawFixed;
            chatFrameTab.ItemSize = new Size(32, 200);
            chatFrameTab.Location = new Point(0, 24);
            chatFrameTab.Multiline = true;
            chatFrameTab.Name = "chatFrameTab";
            chatFrameTab.SelectedIndex = 0;
            chatFrameTab.Size = new Size(1285, 629);
            chatFrameTab.SizeMode = TabSizeMode.Fixed;
            chatFrameTab.TabIndex = 2;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { channelToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(205, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // channelToolStripMenuItem
            // 
            channelToolStripMenuItem.Name = "channelToolStripMenuItem";
            channelToolStripMenuItem.Size = new Size(180, 22);
            channelToolStripMenuItem.Text = "Channel";
            channelToolStripMenuItem.Click += channelToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1285, 653);
            Controls.Add(chatFrameTab);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mono.Chat";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem openInInternetExplorerToolStripMenuItem;
        private TabControl chatFrameTab;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem channelToolStripMenuItem;
    }
}