﻿namespace ChatAppUI
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddPartner = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblNoPartners = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChatHeader = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbPartnerProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUsernameHeader = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.txtInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMessages = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChatHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartnerProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.pnlMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pbProfile);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnAddPartner);
            this.panel1.Controls.Add(this.lblNoPartners);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 694);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dev Contacts";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::BlackenChat.Properties.Resources.icons8_info_64;
            this.pictureBox7.Location = new System.Drawing.Point(193, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Partner";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BlackenChat.Properties.Resources.icons8_add_new_contact_78;
            this.pictureBox2.Location = new System.Drawing.Point(71, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.BorderRadius = 10;
            this.btnAddPartner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPartner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPartner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPartner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPartner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPartner.ForeColor = System.Drawing.Color.White;
            this.btnAddPartner.Location = new System.Drawing.Point(84, 275);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(104, 36);
            this.btnAddPartner.TabIndex = 4;
            this.btnAddPartner.Text = "Add Partner";
            this.btnAddPartner.Visible = false;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // lblNoPartners
            // 
            this.lblNoPartners.AutoSize = true;
            this.lblNoPartners.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPartners.Location = new System.Drawing.Point(49, 232);
            this.lblNoPartners.Name = "lblNoPartners";
            this.lblNoPartners.Size = new System.Drawing.Size(168, 25);
            this.lblNoPartners.TabIndex = 3;
            this.lblNoPartners.Text = "No Partners exists";
            this.lblNoPartners.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log Out";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BlackenChat.Properties.Resources.icons8_log_out_100;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Andalus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chats";
            // 
            // pnlChatHeader
            // 
            this.pnlChatHeader.BackColor = System.Drawing.Color.White;
            this.pnlChatHeader.Controls.Add(this.pictureBox6);
            this.pnlChatHeader.Controls.Add(this.pbPartnerProfile);
            this.pnlChatHeader.Controls.Add(this.pictureBox4);
            this.pnlChatHeader.Controls.Add(this.pictureBox3);
            this.pnlChatHeader.Controls.Add(this.lblUsernameHeader);
            this.pnlChatHeader.Location = new System.Drawing.Point(260, 0);
            this.pnlChatHeader.Name = "pnlChatHeader";
            this.pnlChatHeader.Size = new System.Drawing.Size(965, 59);
            this.pnlChatHeader.TabIndex = 1;
            this.pnlChatHeader.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::BlackenChat.Properties.Resources.icons8_block_user_48__2_;
            this.pictureBox6.Location = new System.Drawing.Point(783, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pbPartnerProfile
            // 
            this.pbPartnerProfile.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbPartnerProfile.ErrorImage")));
            this.pbPartnerProfile.ImageRotate = 0F;
            this.pbPartnerProfile.Location = new System.Drawing.Point(24, 4);
            this.pbPartnerProfile.Name = "pbPartnerProfile";
            this.pbPartnerProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.pbPartnerProfile.Size = new System.Drawing.Size(52, 52);
            this.pbPartnerProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPartnerProfile.TabIndex = 9;
            this.pbPartnerProfile.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::BlackenChat.Properties.Resources.icons8_delete_contact_78;
            this.pictureBox4.Location = new System.Drawing.Point(841, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::BlackenChat.Properties.Resources.icons8_information_64;
            this.pictureBox3.Location = new System.Drawing.Point(899, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblUsernameHeader
            // 
            this.lblUsernameHeader.AutoSize = true;
            this.lblUsernameHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameHeader.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameHeader.Location = new System.Drawing.Point(95, 14);
            this.lblUsernameHeader.Name = "lblUsernameHeader";
            this.lblUsernameHeader.Size = new System.Drawing.Size(65, 25);
            this.lblUsernameHeader.TabIndex = 0;
            this.lblUsernameHeader.Text = "label2";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.Transparent;
            this.pnlDown.Controls.Add(this.txtInput);
            this.pnlDown.Location = new System.Drawing.Point(266, 644);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(962, 50);
            this.pnlDown.TabIndex = 2;
            this.pnlDown.Visible = false;
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.AcceptsTab = true;
            this.txtInput.Animated = true;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.DefaultText = "";
            this.txtInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.IconRight = global::BlackenChat.Properties.Resources.icons8_send_30;
            this.txtInput.Location = new System.Drawing.Point(3, 2);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.PlaceholderText = "Type your message here";
            this.txtInput.SelectedText = "";
            this.txtInput.Size = new System.Drawing.Size(956, 48);
            this.txtInput.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            this.txtInput.Enter += new System.EventHandler(this.siticoneTextBox1_Enter_1);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.siticoneTextBox1_KeyDown);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siticoneTextBox1_KeyPress);
            this.txtInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInput_PreviewKeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMessages
            // 
            this.pnlMessages.AutoScroll = true;
            this.pnlMessages.BackColor = System.Drawing.Color.Transparent;
            this.pnlMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMessages.Controls.Add(this.lblGreeting);
            this.pnlMessages.Controls.Add(this.pbLogo);
            this.pnlMessages.FillColor = System.Drawing.Color.Transparent;
            this.pnlMessages.FillColor2 = System.Drawing.Color.Transparent;
            this.pnlMessages.FillColor3 = System.Drawing.Color.Transparent;
            this.pnlMessages.FillColor4 = System.Drawing.Color.Transparent;
            this.pnlMessages.Location = new System.Drawing.Point(263, 42);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(965, 606);
            this.pnlMessages.TabIndex = 3;
            this.pnlMessages.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMessages_Paint);
            // 
            // lblGreeting
            // 
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblGreeting.Location = new System.Drawing.Point(139, 374);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Padding = new System.Windows.Forms.Padding(160, 0, 0, 0);
            this.lblGreeting.Size = new System.Drawing.Size(687, 45);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Label1";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::BlackenChat.Properties.Resources.icons8_messages_512;
            this.pbLogo.Location = new System.Drawing.Point(370, 156);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(225, 192);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pbProfile
            // 
            this.pbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfile.Image = global::BlackenChat.Properties.Resources.icons8_test_account_96;
            this.pbProfile.ImageRotate = 0F;
            this.pbProfile.Location = new System.Drawing.Point(130, 1);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.pbProfile.Size = new System.Drawing.Size(45, 45);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 11;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::BlackenChat.Properties.Resources.qwd83nc4xxf41;
            this.ClientSize = new System.Drawing.Size(1226, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChatHeader);
            this.Controls.Add(this.pnlMessages);
            this.Controls.Add(this.pnlDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blacken Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChatHeader.ResumeLayout(false);
            this.pnlChatHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartnerProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlChatHeader;
        public System.Windows.Forms.Panel pnlDown;
        public  System.Windows.Forms.Label label1;
        public  Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel pnlMessages;
        public  System.Windows.Forms.Label lblUsernameHeader;
        public  Siticone.Desktop.UI.WinForms.SiticoneTextBox txtInput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.PictureBox pbLogo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddPartner;
        private System.Windows.Forms.Label lblNoPartners;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox pbPartnerProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox pbProfile;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

