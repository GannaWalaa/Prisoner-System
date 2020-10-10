namespace WindowsFormsApp1
{
    partial class updateOfficerInfoForm
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
            this.enterDataLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.teleNumbTxt = new System.Windows.Forms.TextBox();
            this.teleNumbLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.dutyTxt = new System.Windows.Forms.TextBox();
            this.dutyLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.maleRdoBtn = new System.Windows.Forms.RadioButton();
            this.femaleRdoBtn = new System.Windows.Forms.RadioButton();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.prisonLbl = new System.Windows.Forms.Label();
            this.prisonTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterDataLbl
            // 
            this.enterDataLbl.AutoSize = true;
            this.enterDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDataLbl.Location = new System.Drawing.Point(44, 66);
            this.enterDataLbl.Name = "enterDataLbl";
            this.enterDataLbl.Size = new System.Drawing.Size(224, 25);
            this.enterDataLbl.TabIndex = 0;
            this.enterDataLbl.Text = "Please enter the data:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(45, 121);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(87, 20);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "Officer ID:";
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(299, 119);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(331, 22);
            this.IDTxt.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(299, 149);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(331, 22);
            this.nameTxt.TabIndex = 4;
            this.nameTxt.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(45, 153);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(114, 20);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Officer Name:";
            // 
            // teleNumbTxt
            // 
            this.teleNumbTxt.Location = new System.Drawing.Point(299, 238);
            this.teleNumbTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teleNumbTxt.Name = "teleNumbTxt";
            this.teleNumbTxt.Size = new System.Drawing.Size(331, 22);
            this.teleNumbTxt.TabIndex = 6;
            // 
            // teleNumbLbl
            // 
            this.teleNumbLbl.AutoSize = true;
            this.teleNumbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleNumbLbl.Location = new System.Drawing.Point(45, 241);
            this.teleNumbLbl.Name = "teleNumbLbl";
            this.teleNumbLbl.Size = new System.Drawing.Size(211, 20);
            this.teleNumbLbl.TabIndex = 5;
            this.teleNumbLbl.Text = "Officer Telephone Number:";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(45, 363);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(125, 20);
            this.genderLbl.TabIndex = 9;
            this.genderLbl.Text = "Officer Gender:";
            // 
            // dutyTxt
            // 
            this.dutyTxt.Location = new System.Drawing.Point(299, 297);
            this.dutyTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dutyTxt.Name = "dutyTxt";
            this.dutyTxt.Size = new System.Drawing.Size(331, 22);
            this.dutyTxt.TabIndex = 12;
            // 
            // dutyLbl
            // 
            this.dutyLbl.AutoSize = true;
            this.dutyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dutyLbl.Location = new System.Drawing.Point(45, 300);
            this.dutyLbl.Name = "dutyLbl";
            this.dutyLbl.Size = new System.Drawing.Size(147, 20);
            this.dutyLbl.TabIndex = 11;
            this.dutyLbl.Text = "Officer Duty Time:";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(155, 406);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(139, 57);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(389, 406);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(139, 57);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(299, 267);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(331, 22);
            this.addressTxt.TabIndex = 8;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(45, 271);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(123, 20);
            this.addressLbl.TabIndex = 7;
            this.addressLbl.Text = "Officer Adress:";
            this.addressLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(45, 212);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(144, 20);
            this.passwordLbl.TabIndex = 19;
            this.passwordLbl.Text = "Officer Password:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(299, 208);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(331, 22);
            this.passwordTxt.TabIndex = 20;
            this.passwordTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maleRdoBtn
            // 
            this.maleRdoBtn.AutoSize = true;
            this.maleRdoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRdoBtn.Location = new System.Drawing.Point(299, 363);
            this.maleRdoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleRdoBtn.Name = "maleRdoBtn";
            this.maleRdoBtn.Size = new System.Drawing.Size(61, 22);
            this.maleRdoBtn.TabIndex = 21;
            this.maleRdoBtn.TabStop = true;
            this.maleRdoBtn.Text = "Male";
            this.maleRdoBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRdoBtn
            // 
            this.femaleRdoBtn.AutoSize = true;
            this.femaleRdoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRdoBtn.Location = new System.Drawing.Point(439, 363);
            this.femaleRdoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleRdoBtn.Name = "femaleRdoBtn";
            this.femaleRdoBtn.Size = new System.Drawing.Size(78, 22);
            this.femaleRdoBtn.TabIndex = 22;
            this.femaleRdoBtn.TabStop = true;
            this.femaleRdoBtn.Text = "Female";
            this.femaleRdoBtn.UseVisualStyleBackColor = true;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(44, 182);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(147, 20);
            this.usernameLbl.TabIndex = 23;
            this.usernameLbl.Text = "Officer Username:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(299, 178);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(331, 22);
            this.usernameTxt.TabIndex = 24;
            // 
            // prisonLbl
            // 
            this.prisonLbl.AutoSize = true;
            this.prisonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonLbl.Location = new System.Drawing.Point(45, 330);
            this.prisonLbl.Name = "prisonLbl";
            this.prisonLbl.Size = new System.Drawing.Size(153, 20);
            this.prisonLbl.TabIndex = 25;
            this.prisonLbl.Text = "Prison he works at:";
            // 
            // prisonTxt
            // 
            this.prisonTxt.Location = new System.Drawing.Point(299, 326);
            this.prisonTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prisonTxt.Name = "prisonTxt";
            this.prisonTxt.Size = new System.Drawing.Size(331, 22);
            this.prisonTxt.TabIndex = 26;
            // 
            // updateOfficerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(717, 504);
            this.Controls.Add(this.prisonTxt);
            this.Controls.Add(this.prisonLbl);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.femaleRdoBtn);
            this.Controls.Add(this.maleRdoBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dutyTxt);
            this.Controls.Add(this.dutyLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.teleNumbTxt);
            this.Controls.Add(this.teleNumbLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.enterDataLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updateOfficerInfoForm";
            this.Text = "Updating Officer Information";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterDataLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox teleNumbTxt;
        private System.Windows.Forms.Label teleNumbLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.TextBox dutyTxt;
        private System.Windows.Forms.Label dutyLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.RadioButton maleRdoBtn;
        private System.Windows.Forms.RadioButton femaleRdoBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label prisonLbl;
        private System.Windows.Forms.TextBox prisonTxt;
        private System.Windows.Forms.Button deleteBtn;
    }
}