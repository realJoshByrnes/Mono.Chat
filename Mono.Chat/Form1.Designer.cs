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
            tabPage1 = new TabPage();
            menuStrip1.SuspendLayout();
            chatFrameTab.SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, openInInternetExplorerToolStripMenuItem, exitToolStripMenuItem });
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
            chatFrameTab.Controls.Add(tabPage1);
            chatFrameTab.Dock = DockStyle.Fill;
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
            // tabPage1
            // 
            tabPage1.Location = new Point(204, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1077, 621);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " The Lobby";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1285, 653);
            Controls.Add(chatFrameTab);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mono.Chat";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            chatFrameTab.ResumeLayout(false);
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
        private TabPage tabPage1;
    }
}