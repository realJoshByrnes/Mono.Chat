using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mono.Chat
{
    public partial class ChannelForm : Form
    {
        TabControl tabControl;

        public ChannelForm(Form mdiParent, TabControl tabControl)
        {
            InitializeComponent();

            this.MdiParent = mdiParent;

            TabPage tabPage = new TabPage();
            tabPage.Text = this.Text;
            tabControl.TabPages.Add(tabPage);
            tabPage.GotFocus += (object? sender, EventArgs e) =>
            {
                this.Activate();
            };

            // Keep our references
            this.tabControl = tabControl;
            this.Tag = tabPage;
            tabPage.Tag = this;

            // Set up event handlers
            this.FormClosed += new FormClosedEventHandler(ChannelForm_FormClosed);
            this.LostFocus += new EventHandler(ChannelForm_LostFocus);
            this.GotFocus += new EventHandler(ChannelForm_GotFocus);
            this.TextChanged += new EventHandler(ChannelForm_TextChanged);
        }

        private void ChannelForm_TextChanged(object? sender, EventArgs e)
        {
            ((TabPage)this.Tag!).Text = this.Text;
        }

        private void ChannelForm_LostFocus(object? sender, EventArgs e)
        {
            Debug.WriteLine("-- Test {0}", this.Tag);
            //this.tabControl.DeselectTab((TabPage)this.Tag!);
            Debug.WriteLine("State {0}", this.WindowState);
        }

        private void ChannelForm_GotFocus(object? sender, EventArgs e)
        {
            this.tabControl.SelectTab((TabPage)this.Tag!);
        }

        private void ChannelForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.tabControl.TabPages.Remove((TabPage)this.Tag!);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Hello, World!";
        }
    }
}
