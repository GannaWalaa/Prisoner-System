namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.PleaseEnterDataLbl = new System.Windows.Forms.Label();
            this.officerRdoBtn = new System.Windows.Forms.RadioButton();
            this.adminRdoBtn = new System.Windows.Forms.RadioButton();
            this.signInBtn = new System.Windows.Forms.Button();
            this.signInPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signInPic)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(195, 234);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(331, 22);
            this.passwordTxt.TabIndex = 9;
            this.passwordTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(74, 236);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(88, 20);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(195, 207);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(331, 22);
            this.usernameTxt.TabIndex = 7;
            this.usernameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(75, 208);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(91, 20);
            this.usernameLbl.TabIndex = 6;
            this.usernameLbl.Text = "Username:";
            // 
            // PleaseEnterDataLbl
            // 
            this.PleaseEnterDataLbl.AutoSize = true;
            this.PleaseEnterDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseEnterDataLbl.Location = new System.Drawing.Point(74, 164);
            this.PleaseEnterDataLbl.Name = "PleaseEnterDataLbl";
            this.PleaseEnterDataLbl.Size = new System.Drawing.Size(312, 25);
            this.PleaseEnterDataLbl.TabIndex = 5;
            this.PleaseEnterDataLbl.Text = "Please enter your data to login:";
            // 
            // officerRdoBtn
            // 
            this.officerRdoBtn.AutoSize = true;
            this.officerRdoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerRdoBtn.Location = new System.Drawing.Point(195, 283);
            this.officerRdoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.officerRdoBtn.Name = "officerRdoBtn";
            this.officerRdoBtn.Size = new System.Drawing.Size(81, 24);
            this.officerRdoBtn.TabIndex = 10;
            this.officerRdoBtn.TabStop = true;
            this.officerRdoBtn.Text = "Officer";
            this.officerRdoBtn.UseVisualStyleBackColor = true;
            this.officerRdoBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // adminRdoBtn
            // 
            this.adminRdoBtn.AutoSize = true;
            this.adminRdoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRdoBtn.Location = new System.Drawing.Point(358, 283);
            this.adminRdoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminRdoBtn.Name = "adminRdoBtn";
            this.adminRdoBtn.Size = new System.Drawing.Size(77, 24);
            this.adminRdoBtn.TabIndex = 11;
            this.adminRdoBtn.TabStop = true;
            this.adminRdoBtn.Text = "Admin";
            this.adminRdoBtn.UseVisualStyleBackColor = true;
            this.adminRdoBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Location = new System.Drawing.Point(267, 349);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(115, 52);
            this.signInBtn.TabIndex = 12;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // signInPic
            // 
            this.signInPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signInPic.BackgroundImage")));
            this.signInPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signInPic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("signInPic.ErrorImage")));
            this.signInPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("signInPic.InitialImage")));
            this.signInPic.Location = new System.Drawing.Point(267, 39);
            this.signInPic.Name = "signInPic";
            this.signInPic.Size = new System.Drawing.Size(93, 107);
            this.signInPic.TabIndex = 13;
            this.signInPic.TabStop = false;
            this.signInPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.signInPic);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.adminRdoBtn);
            this.Controls.Add(this.officerRdoBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.PleaseEnterDataLbl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signInPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label PleaseEnterDataLbl;
        private System.Windows.Forms.RadioButton officerRdoBtn;
        private System.Windows.Forms.RadioButton adminRdoBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.PictureBox signInPic;
    }
}