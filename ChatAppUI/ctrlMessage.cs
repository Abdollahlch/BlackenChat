using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ChatAppUI
{
    public partial class ctrlMessage : UserControl
    {

        public ctrlMessage(string MessageContent,DateTime dateTime)
        {
            InitializeComponent();
            label1.Text = MessageContent;
            label2.Text = dateTime.ToString("HH:mm");
            Size messageSize = TextRenderer.MeasureText(MessageContent, siticoneCustomGradientPanel1.Font);
            siticoneCustomGradientPanel1.Size = new Size(messageSize.Width + 20, 50);
            this.Size = new Size(messageSize.Width + 120, 50);
            //how to make sure that the message displaying time correctly in right of the message
            label2.Location = new Point(siticoneCustomGradientPanel1.Width - label2.Width - 5, label2.Location.Y);


        }

        public DateTime MessageTime
        {
            get
            {
                return DateTime.Parse(label2.Text);
            }
            set
            {
                label2.Text = value.ToString("HH:mm");
            }
        }
        public string MessageContent
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public Font MessageFont
        {
            get
            {
                return label1.Font;
            }
            set
            {
                label1.Font = value;
            }
        }

        public Color MessageColor { set { 
                siticoneCustomGradientPanel1.FillColor = value;
                siticoneCustomGradientPanel1.FillColor2 = value;
                siticoneCustomGradientPanel1.FillColor3 = value;
                siticoneCustomGradientPanel1.FillColor4 = value;
            } }
       

        private void ctrlMessage_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void siticoneCustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
