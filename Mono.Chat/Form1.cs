using MSNChatControl;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mono.Chat
{
    public partial class Form1 : Form
    {
        InternetExplorer ie;
        public Form1()
        {
            InitializeComponent();
            ie = new InternetExplorer();
            if (ie.IsInstalled)
            {
                openInInternetExplorerToolStripMenuItem.Enabled = true;
            }
            chatFrameTab.DrawItem += new DrawItemEventHandler(chatFrameTab_DrawItem);
        }

        private void chatFrameTab_DrawItem(object? sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = chatFrameTab.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = chatFrameTab.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);

                var _fillBrush = new SolidBrush(Color.FromArgb(69, 69, 69));
                g.FillRectangle(_fillBrush, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(Color.Green);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("system-ui", 14.0f, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Near;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form();
            var cs = new ChatSettings();
            cs.Dock = DockStyle.Fill;
            form.Controls.Add(cs);
            form.Text = "Chat Settings";
            form.ClientSize = new Size(420, 630);
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openInInternetExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ie.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cfm = new ChatFrameManager();
            var cf = cfm.createChatFrame();
            cf.Dock = DockStyle.Fill;
            cf.Visible = true;
            tabPage1.Controls.Add(cf);
        }
    }
}
