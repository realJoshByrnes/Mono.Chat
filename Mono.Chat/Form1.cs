using MSNChatControl;

namespace Mono.Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form();
            var cs = new ChatSettings();
            cs.Dock = DockStyle.Fill;
            form.Controls.Add(cs);
            form.Text = "Chat Settings";
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
