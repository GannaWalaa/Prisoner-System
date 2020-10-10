namespace WindowsFormsApp1
{
    partial class addPrisonerForm
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
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.cellNumbLbl = new System.Windows.Forms.Label();
            this.crimeLbl = new System.Windows.Forms.Label();
            this.prunishmentYearsLbl = new System.Windows.Forms.Label();
            this.prisonNameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.cellNumbTxt = new System.Windows.Forms.TextBox();
            this.crimeTxt = new System.Windows.Forms.TextBox();
            this.punishmentTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.prisonNameTxt = new System.Windows.Forms.TextBox();
            this.enterDataLbl = new System.Windows.Forms.Label();
            this.prisonDateTxt = new System.Windows.Forms.TextBox();
            this.prisonDateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(141, 115);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(36, 20);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = " ID:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(141, 145);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(58, 20);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name:";
            // 
            // cellNumbLbl
            // 
            this.cellNumbLbl.AutoSize = true;
            this.cellNumbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellNumbLbl.Location = new System.Drawing.Point(141, 176);
            this.cellNumbLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cellNumbLbl.Name = "cellNumbLbl";
            this.cellNumbLbl.Size = new System.Drawing.Size(107, 20);
            this.cellNumbLbl.TabIndex = 2;
            this.cellNumbLbl.Text = "Cell Number:";
            // 
            // crimeLbl
            // 
            this.crimeLbl.AutoSize = true;
            this.crimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeLbl.Location = new System.Drawing.Point(141, 205);
            this.crimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crimeLbl.Name = "crimeLbl";
            this.crimeLbl.Size = new System.Drawing.Size(59, 20);
            this.crimeLbl.TabIndex = 3;
            this.crimeLbl.Text = "Crime:";
            // 
            // prunishmentYearsLbl
            // 
            this.prunishmentYearsLbl.AutoSize = true;
            this.prunishmentYearsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prunishmentYearsLbl.Location = new System.Drawing.Point(141, 235);
            this.prunishmentYearsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prunishmentYearsLbl.Name = "prunishmentYearsLbl";
            this.prunishmentYearsLbl.Size = new System.Drawing.Size(150, 20);
            this.prunishmentYearsLbl.TabIndex = 4;
            this.prunishmentYearsLbl.Text = "Punishment Years:";
            // 
            // prisonNameLbl
            // 
            this.prisonNameLbl.AutoSize = true;
            this.prisonNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonNameLbl.Location = new System.Drawing.Point(141, 265);
            this.prisonNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prisonNameLbl.Name = "prisonNameLbl";
            this.prisonNameLbl.Size = new System.Drawing.Size(111, 20);
            this.prisonNameLbl.TabIndex = 5;
            this.prisonNameLbl.Text = "Prison Name:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(141, 295);
            this.ageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(43, 20);
            this.ageLbl.TabIndex = 6;
            this.ageLbl.Text = "Age:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(325, 113);
            this.idTxt.Margin = new System.Windows.Forms.Padding(4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(223, 22);
            this.idTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(325, 143);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(223, 22);
            this.nameTxt.TabIndex = 8;
            // 
            // cellNumbTxt
            // 
            this.cellNumbTxt.Location = new System.Drawing.Point(325, 174);
            this.cellNumbTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cellNumbTxt.Name = "cellNumbTxt";
            this.cellNumbTxt.Size = new System.Drawing.Size(223, 22);
            this.cellNumbTxt.TabIndex = 9;
            // 
            // crimeTxt
            // 
            this.crimeTxt.Location = new System.Drawing.Point(325, 203);
            this.crimeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.crimeTxt.Name = "crimeTxt";
            this.crimeTxt.Size = new System.Drawing.Size(223, 22);
            this.crimeTxt.TabIndex = 10;
            // 
            // punishmentTxt
            // 
            this.punishmentTxt.Location = new System.Drawing.Point(325, 233);
            this.punishmentTxt.Margin = new System.Windows.Forms.Padding(4);
            this.punishmentTxt.Name = "punishmentTxt";
            this.punishmentTxt.Size = new System.Drawing.Size(223, 22);
            this.punishmentTxt.TabIndex = 11;
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(325, 293);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(223, 22);
            this.ageTxt.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(253, 378);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(139, 57);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // prisonNameTxt
            // 
            this.prisonNameTxt.Location = new System.Drawing.Point(325, 263);
            this.prisonNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.prisonNameTxt.Name = "prisonNameTxt";
            this.prisonNameTxt.Size = new System.Drawing.Size(223, 22);
            this.prisonNameTxt.TabIndex = 15;
            // 
            // enterDataLbl
            // 
            this.enterDataLbl.AutoSize = true;
            this.enterDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDataLbl.Location = new System.Drawing.Point(143, 65);
            this.enterDataLbl.Name = "enterDataLbl";
            this.enterDataLbl.Size = new System.Drawing.Size(224, 25);
            this.enterDataLbl.TabIndex = 16;
            this.enterDataLbl.Text = "Please enter the data:";
            // 
            // prisonDateTxt
            // 
            this.prisonDateTxt.Location = new System.Drawing.Point(325, 325);
            this.prisonDateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.prisonDateTxt.Name = "prisonDateTxt";
            this.prisonDateTxt.Size = new System.Drawing.Size(223, 22);
            this.prisonDateTxt.TabIndex = 18;
            // 
            // prisonDateLbl
            // 
            this.prisonDateLbl.AutoSize = true;
            this.prisonDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonDateLbl.Location = new System.Drawing.Point(141, 327);
            this.prisonDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prisonDateLbl.Name = "prisonDateLbl";
            this.prisonDateLbl.Size = new System.Drawing.Size(103, 20);
            this.prisonDateLbl.TabIndex = 20;
            this.prisonDateLbl.Text = "Prison Date:";
            // 
            // addPrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(717, 481);
            this.Controls.Add(this.prisonDateLbl);
            this.Controls.Add(this.prisonDateTxt);
            this.Controls.Add(this.enterDataLbl);
            this.Controls.Add(this.prisonNameTxt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.punishmentTxt);
            this.Controls.Add(this.crimeTxt);
            this.Controls.Add(this.cellNumbTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.prisonNameLbl);
            this.Controls.Add(this.prunishmentYearsLbl);
            this.Controls.Add(this.crimeLbl);
            this.Controls.Add(this.cellNumbLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addPrisonerForm";
            this.Text = "Add Prisoner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label cellNumbLbl;
        private System.Windows.Forms.Label crimeLbl;
        private System.Windows.Forms.Label prunishmentYearsLbl;
        private System.Windows.Forms.Label prisonNameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox cellNumbTxt;
        private System.Windows.Forms.TextBox crimeTxt;
        private System.Windows.Forms.TextBox punishmentTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox prisonNameTxt;
        private System.Windows.Forms.Label enterDataLbl;
        private System.Windows.Forms.TextBox prisonDateTxt;
        private System.Windows.Forms.Label prisonDateLbl;
    }
}