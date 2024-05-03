using ChatAppBusinessLogic;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppUI
{
    public partial class MainMenu : Form
    {
        public MainMenu(clsUser User)
        {
            InitializeComponent();
            CurrentUser = User;
           
        }

        

        enum enMessageType { Sent,Recieved};
        public clsUser CurrentUser;
        clsUser CurrentPartner;
        int NumberOfMessages = 0;
        int NumberOfPartners = 0;
        public List<int> PartnersIDs = new List<int>();
        Point GeneratePartnerLocationInList()
        {
            return new Point(-1, 120 + (NumberOfPartners * 51));
        }
        Point GenerateMessageLocation(enMessageType messageType,ctrlMessage message)
        {
            if (messageType == enMessageType.Sent)
            {
            return new Point(22, 15 + (NumberOfMessages * 55)+50);//22, 15 as initial size
            }
            else
            {
                int Xpostion = 925 - message.Width;
                return new Point(Xpostion, (NumberOfMessages * 55) + 50);
            }

        }

        void ClearMessagesPanel()
        {
            pnlMessages.Controls.Clear();
            NumberOfMessages = 0;
        }
        
        public bool AddPartner(int ID)
        {
            clsUser Partner = clsUser.FindByID(ID);
            if (Partner == null)
                return false;
            Button button = new Button();
            // button1.TextAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button.Text = Partner.Username;
            button.Size = new Size(266, 59);
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Image = Image.FromFile(Partner.ImagePath);
            button.ImageAlign = ContentAlignment.TopLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.Tag = Partner.UserID;   
            //could you handle image size to make it better because it's so big
            button.Image = new Bitmap(button.Image, new Size(50, 50));
            //use #FFFFFF as backcolor for the button
            button.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;

            button.Location = GeneratePartnerLocationInList();
            PartnersIDs.Add(Partner.UserID);

            button.Click += BtnPartner_Click;
            panel1.Controls.Add(button);

            //ctrlChat pnl  = new ctrlChat();
            //pnl.Size = new Size(200, 59);
            ////pnl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            //pnl.Username = Partner.Username;
            //pnl.Location = GeneratePartnerLocationInList();
            //pnl.Cursor = Cursors.Hand;
            //pnl.Click += BtnPartner_Click;
            ////why here when i add the BtnPartner_Click event to pnl User control when i run the program and click on the pnl it doesn't work
            ////answer : i should add the event to the button inside the user control not the user control itself
            ////ok i will add the event to the button inside the user control
            //panel1.Controls.Add(pnl);
            NumberOfPartners++;
            return true;
        }
     
        private void Form2_DataBack(int PartnerID)
        {
            if (!AddPartner(PartnerID))
            {
                MessageBox.Show("Error occure while adding the partner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            
            
        }
        private void ClearPartnersPanel()
        {
            //here delete all buttons on the panel (Partners panel)
            //delete only buttons not the other controls
            foreach (Control button in panel1.Controls)
            {
                if (button is Button)
                {
                    panel1.Controls.Remove(button);
                    
                }
            }
            NumberOfPartners = 0;
        }
        public bool CheckChatAlreadyExist(int ID)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    if (PartnersIDs.Contains(ID)  &&((Button)control).Tag.ToString() == ID.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public void LoadAllPartners()
        {
            ClearPartnersPanel();
           
            List<int> PartnersIDs = CurrentUser.GetAllPartnersByUserID();
            if (PartnersIDs.Count == 0)
            {

                lblNoPartners.Visible = true;
                btnAddPartner.Visible = true;
                



                return;
            }
            lblNoPartners.Visible = false ;
            btnAddPartner.Visible = false ;
            foreach (int partnerID in PartnersIDs)
            {

                if (CheckChatAlreadyExist(partnerID))
                {
                    NumberOfPartners++;
                    continue;  
                }
                AddPartner(partnerID);
                
            }

        }
        //pnlMessages.ScrollControlIntoView(message);
        void LoadMessagesToPanel()
        {
            ClearMessagesPanel();
            if (CurrentUser==null || CurrentPartner==null) return;
            DataTable Messages = clsMessage.GetMessagesBetweenUsers(CurrentUser.UserID,CurrentPartner.UserID);
            if (Messages == null || Messages.Rows.Count==0) return;
            foreach (DataRow Row in Messages.Rows)
            {
               
                ctrlMessage message = new ctrlMessage(Row["Content"].ToString(),(DateTime) Row["TimeStamp"]);
                

                message.BorderStyle = BorderStyle.None;
                
                if (Row["SenderID"].ToString()==CurrentUser.UserID.ToString())
                message.Location = GenerateMessageLocation(enMessageType.Sent,message);
                else
                {
                    message.Location = GenerateMessageLocation(enMessageType.Recieved,message);
                    message.MessageColor = Color.White;
                }
                message.Tag = Row["MessageID"].ToString();
                pnlMessages.Controls.Add(message);
            
                NumberOfMessages++;
            }
            
            pnlMessages.ScrollControlIntoView(pnlMessages.Controls[pnlMessages.Controls.Count - 1]);
            
        }

        void AddExistsMessage(clsMessage Message)
        {
            ctrlMessage message = new ctrlMessage(Message.Content,Message.MessageDate);
            message.BorderStyle = BorderStyle.None;
            
            if (Message.SenderID == CurrentUser.UserID)
                message.Location = GenerateMessageLocation(enMessageType.Sent, message);
            else
            {
                message.Location = GenerateMessageLocation(enMessageType.Recieved, message);
                message.MessageColor = Color.White;
            }
            message.Tag = Message.MessageID.ToString();
            pnlMessages.Controls.Add(message);
            NumberOfMessages++;
        }



        //bool AddNewMessage(string MessageContent, int SenderID, int ReceiverID, DateTime time)
        //{
            
        //}
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (CurrentUser.ImagePath!=null)
            pbProfile.Image = Image.FromFile(CurrentUser.ImagePath);
            LoadAllPartners();
            lblGreeting.Text = "Welcome " + CurrentUser.Username.Split(' ')[0];
            
            //how can i center that label horizontally
            lblGreeting.Anchor = AnchorStyles.None; // Ensure the label is not anchored to any side
            //lblGreeting.TextAlign = ContentAlignment.MiddleCenter; // Center the text horizontally


        }
        private void ShowNotification(string title, string message)
        {
            // Display a notification balloon
            notifyIcon1.ShowBalloonTip(3000, title, message, ToolTipIcon.Info);
        }
        private void BtnPartner_Click(object sender, EventArgs e)
        {
            
            CurrentPartner = clsUser.FindByUsername(((Button)sender).Text);
            if (CurrentPartner == null)
            {
                MessageBox.Show("invalid Partner");
                return;
            }
            LoadMessagesToPanel();
            pnlChatHeader.Visible = true;
            if (CurrentPartner.UserID != CurrentUser.UserID)
                lblUsernameHeader.Text = CurrentPartner.Username;
            else
                lblUsernameHeader.Text = "You";
            pnlDown.Visible = true;
            txtInput.Focus();
            timer1.Start();
            lblGreeting.Visible = false;
            pbLogo.Visible = false;
            pbPartnerProfile.ImageLocation = CurrentPartner.ImagePath;

        }

       
        private void siticoneTextBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        bool SendMessage(string MessageContent, int SenderID, int ReceiverID)
        {
            clsMessage message = new clsMessage();
            message.Content = MessageContent;
            message.SenderID = SenderID;
            message.ReceiverID = ReceiverID;
            
            return message.Save();
        }

        private void siticoneTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NumberOfMessages+1==clsMessage.GetMessagesBetweenUsers(CurrentUser.UserID, CurrentPartner.UserID).Rows.Count)
            {
                clsMessage message = clsMessage.GetTheLastMessage();
                AddExistsMessage(message);
                notifyIcon1.Text = message.Content;
                if (message.ReceiverID == message.SenderID) return ;
                if (message.ReceiverID == CurrentUser.UserID)
                    ShowNotification($"You Received a New Message for {CurrentUser.Username}", message.Content);
                return;
            }
            
            
            
            if (NumberOfMessages<clsMessage.GetMessagesBetweenUsers(CurrentUser.UserID, CurrentPartner.UserID).Rows.Count)
            {
                LoadMessagesToPanel();
            }
            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.OpenForms[0].Close();

            //this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
            
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void txtInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {

                SendMessage(txtInput.Text, CurrentUser.UserID, CurrentPartner.UserID);
                LoadMessagesToPanel();
                txtInput.Clear();
                


                // Prevent the key press event from being handled by the control
                e.IsInputKey = true;
            }
        }

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            AddPartnerForm form = new AddPartnerForm(CurrentUser, PartnersIDs);
            form.PartnerID += Form2_DataBack;

            form.ShowDialog();
            if (NumberOfPartners > 0)
            {
                lblNoPartners.Visible = false;
                btnAddPartner.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnAddPartner_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmUserInfo form = new frmUserInfo(CurrentPartner);
            form.ShowDialog();
        }

        void DeletePartnerButton(string Username)
        {
            //here find and delete the button that it's text equal Username text
            foreach (Control button in panel1.Controls)
            {
                if (button is Button)
                {
                    if (((Button)button).Text == Username)
                    {
                        panel1.Controls.Remove(button);
                        NumberOfPartners--;
                        break;
                    }
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all messages between you and " + CurrentPartner.Username, "Delete All Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsMessage.DeleteAllMessagesBetweenUserPartner(CurrentUser.UserID, CurrentPartner.UserID))
                {
                    LoadAllPartners();
                    ClearMessagesPanel();
                    DeletePartnerButton(CurrentPartner.Username);
                    PartnersIDs.Remove(CurrentPartner.UserID);

                }
                else
                {
                    MessageBox.Show("Error while deleting the messages", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                PictureBox pb = new PictureBox();
                pb = pbLogo;
                pb.Visible = true;
                pnlMessages.Controls.Add(pb);

                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label = lblGreeting;
                label.Visible = true;
                pnlMessages.Controls.Add(label);
                pnlChatHeader.Visible = false;
                pnlDown.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmUpdateProfile frmUpdateProfile = new frmUpdateProfile(ref CurrentUser);
            frmUpdateProfile.ShowDialog();
            CurrentUser.Save();
            if (CurrentUser.ImagePath!=null)
            pbProfile.Image = Image.FromFile(CurrentUser.ImagePath);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm lazy to add this feature but it will coming Soon!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlMessages_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmDevContact frmDevContact = new frmDevContact();
            frmDevContact.ShowDialog();
        }
    }
}
