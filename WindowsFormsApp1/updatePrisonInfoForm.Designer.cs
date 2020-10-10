namespace WindowsFormsApp1
{
    partial class updatePrisonInfoForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.capacityTxt = new System.Windows.Forms.TextBox();
            this.capacityLbl = new System.Windows.Forms.Label();
            this.placeTxt = new System.Windows.Forms.TextBox();
            this.placeLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.IDLbl = new System.Windows.Forms.Label();
            this.enterDataLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.amountOfCellTxt = new System.Windows.Forms.TextBox();
            this.amountOfCellLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(160, 302);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(139, 57);
            this.addBtn.TabIndex = 27;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // capacityTxt
            // 
            this.capacityTxt.Location = new System.Drawing.Point(293, 197);
            this.capacityTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capacityTxt.Name = "capacityTxt";
            this.capacityTxt.Size = new System.Drawing.Size(331, 22);
            this.capacityTxt.TabIndex = 22;
            // 
            // capacityLbl
            // 
            this.capacityLbl.AutoSize = true;
            this.capacityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLbl.Location = new System.Drawing.Point(45, 199);
            this.capacityLbl.Name = "capacityLbl";
            this.capacityLbl.Size = new System.Drawing.Size(166, 20);
            this.capacityLbl.TabIndex = 21;
            this.capacityLbl.Text = "Prison Cell Capacity:";
            // 
            // placeTxt
            // 
            this.placeTxt.Location = new System.Drawing.Point(293, 169);
            this.placeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeTxt.Name = "placeTxt";
            this.placeTxt.Size = new System.Drawing.Size(331, 22);
            this.placeTxt.TabIndex = 20;
            // 
            // placeLbl
            // 
            this.placeLbl.AutoSize = true;
            this.placeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeLbl.Location = new System.Drawing.Point(45, 171);
            this.placeLbl.Name = "placeLbl";
            this.placeLbl.Size = new System.Drawing.Size(109, 20);
            this.placeLbl.TabIndex = 19;
            this.placeLbl.Text = "Prison Place:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(293, 142);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(331, 22);
            this.nameTxt.TabIndex = 18;
            this.nameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(45, 143);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(111, 20);
            this.nameLbl.TabIndex = 17;
            this.nameLbl.Text = "Prison Name:";
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(293, 113);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(331, 22);
            this.IDTxt.TabIndex = 16;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLbl.Location = new System.Drawing.Point(45, 114);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(84, 20);
            this.IDLbl.TabIndex = 15;
            this.IDLbl.Text = "Prison ID:";
            // 
            // enterDataLbl
            // 
            this.enterDataLbl.AutoSize = true;
            this.enterDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDataLbl.Location = new System.Drawing.Point(45, 70);
            this.enterDataLbl.Name = "enterDataLbl";
            this.enterDataLbl.Size = new System.Drawing.Size(224, 25);
            this.enterDataLbl.TabIndex = 14;
            this.enterDataLbl.Text = "Please enter the data:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(357, 302);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(139, 57);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // amountOfCellTxt
            // 
            this.amountOfCellTxt.Location = new System.Drawing.Point(293, 226);
            this.amountOfCellTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountOfCellTxt.Name = "amountOfCellTxt";
            this.amountOfCellTxt.Size = new System.Drawing.Size(331, 22);
            this.amountOfCellTxt.TabIndex = 29;
            // 
            // amountOfCellLbl
            // 
            this.amountOfCellLbl.AutoSize = true;
            this.amountOfCellLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOfCellLbl.Location = new System.Drawing.Point(45, 228);
            this.amountOfCellLbl.Name = "amountOfCellLbl";
            this.amountOfCellLbl.Size = new System.Drawing.Size(189, 20);
            this.amountOfCellLbl.TabIndex = 30;
            this.amountOfCellLbl.Text = "Prison amount of Cells :";
            // 
            // updatePrisonInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.amountOfCellLbl);
            this.Controls.Add(this.amountOfCellTxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.capacityTxt);
            this.Controls.Add(this.capacityLbl);
            this.Controls.Add(this.placeTxt);
            this.Controls.Add(this.placeLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.enterDataLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updatePrisonInfoForm";
            this.Text = "Update Prison Information";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox capacityTxt;
        private System.Windows.Forms.Label capacityLbl;
        private System.Windows.Forms.TextBox placeTxt;
        private System.Windows.Forms.Label placeLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label enterDataLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox amountOfCellTxt;
        private System.Windows.Forms.Label amountOfCellLbl;
    }
}