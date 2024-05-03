using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppUI
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        Point GenerateChatPosition()
        {
            return new Point(-1, 300 + (0 * 51));
        }
        private void test_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Hello bro";
            button.Location = GenerateChatPosition();
            button.Visible = true;
            this.Controls.Add(button);
        }
    }
}
