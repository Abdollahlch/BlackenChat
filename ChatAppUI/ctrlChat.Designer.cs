namespace ChatAppUI
{
    partial class ctrlChat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.pbImageProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.pbImageProfile);
            this.siticoneCustomGradientPanel1.Controls.Add(this.lblLastMessage);
            this.siticoneCustomGradientPanel1.Controls.Add(this.lblUsername);
            this.siticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneCustomGradientPanel1.FillColor = System.Drawing.SystemColors.Info;
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(200, 59);
            this.siticoneCustomGradientPanel1.TabIndex = 0;
            this.siticoneCustomGradientPanel1.Click += new System.EventHandler(this.siticoneCustomGradientPanel1_Click);
            this.siticoneCustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneCustomGradientPanel1_Paint);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(54, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(38, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "label";
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblLastMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMessage.Location = new System.Drawing.Point(54, 32);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(41, 17);
            this.lblLastMessage.TabIndex = 1;
            this.lblLastMessage.Text = "label2";
            // 
            // pbImageProfile
            // 
            this.pbImageProfile.Image = global::BlackenChat.Properties.Resources.profile;
            this.pbImageProfile.ImageRotate = 0F;
            this.pbImageProfile.Location = new System.Drawing.Point(3, 9);
            this.pbImageProfile.Name = "pbImageProfile";
            this.pbImageProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.pbImageProfile.Size = new System.Drawing.Size(44, 40);
            this.pbImageProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageProfile.TabIndex = 2;
            this.pbImageProfile.TabStop = false;
            // 
            // ctrlChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.Name = "ctrlChat";
            this.Size = new System.Drawing.Size(200, 59);
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private System.Windows.Forms.Label lblUsername;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox pbImageProfile;
        private System.Windows.Forms.Label lblLastMessage;
    }
}
