using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mono.Chat
{
    public partial class ChatHeader : UserControl
    {
        public ChatHeader()
        {
            InitializeComponent();
            this.Resize += (object? sender, EventArgs e) =>
            {
                this.Height = 106;
                rightImage.Width = this.Width;
            };
        }
    }
}
