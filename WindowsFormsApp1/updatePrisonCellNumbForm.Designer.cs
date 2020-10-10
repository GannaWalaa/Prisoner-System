namespace WindowsFormsApp1
{
    partial class updatePrisonCellNumbForm
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
            this.prisonerIDLbl = new System.Windows.Forms.Label();
            this.cellNumbLbl = new System.Windows.Forms.Label();
            this.prisonerIDTxt = new System.Windows.Forms.TextBox();
            this.cellNumbTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.enterDataLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prisonerIDLbl
            // 
            this.prisonerIDLbl.AutoSize = true;
            this.prisonerIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonerIDLbl.Location = new System.Drawing.Point(123, 161);
            this.prisonerIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prisonerIDLbl.Name = "prisonerIDLbl";
            this.prisonerIDLbl.Size = new System.Drawing.Size(99, 20);
            this.prisonerIDLbl.TabIndex = 0;
            this.prisonerIDLbl.Text = "Prisoner ID:";
            // 
            // cellNumbLbl
            // 
            this.cellNumbLbl.AutoSize = true;
            this.cellNumbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellNumbLbl.Location = new System.Drawing.Point(123, 230);
            this.cellNumbLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cellNumbLbl.Name = "cellNumbLbl";
            this.cellNumbLbl.Size = new System.Drawing.Size(107, 20);
            this.cellNumbLbl.TabIndex = 1;
            this.cellNumbLbl.Text = "Cell Number:";
            // 
            // prisonerIDTxt
            // 
            this.prisonerIDTxt.Location = new System.Drawing.Point(254, 161);
            this.prisonerIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.prisonerIDTxt.Name = "prisonerIDTxt";
            this.prisonerIDTxt.Size = new System.Drawing.Size(263, 22);
            this.prisonerIDTxt.TabIndex = 2;
            // 
            // cellNumbTxt
            // 
            this.cellNumbTxt.Location = new System.Drawing.Point(254, 228);
            this.cellNumbTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cellNumbTxt.Name = "cellNumbTxt";
            this.cellNumbTxt.Size = new System.Drawing.Size(263, 22);
            this.cellNumbTxt.TabIndex = 3;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(254, 298);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(138, 57);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterDataLbl
            // 
            this.enterDataLbl.AutoSize = true;
            this.enterDataLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDataLbl.Location = new System.Drawing.Point(122, 91);
            this.enterDataLbl.Name = "enterDataLbl";
            this.enterDataLbl.Size = new System.Drawing.Size(284, 25);
            this.enterDataLbl.TabIndex = 5;
            this.enterDataLbl.Text = "Please enter data to update:";
            // 
            // updatePrisonCellNumbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(699, 506);
            this.Controls.Add(this.enterDataLbl);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.cellNumbTxt);
            this.Controls.Add(this.prisonerIDTxt);
            this.Controls.Add(this.cellNumbLbl);
            this.Controls.Add(this.prisonerIDLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "updatePrisonCellNumbForm";
            this.Text = "Update Prison Cell Number";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prisonerIDLbl;
        private System.Windows.Forms.Label cellNumbLbl;
        private System.Windows.Forms.TextBox prisonerIDTxt;
        private System.Windows.Forms.TextBox cellNumbTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label enterDataLbl;
    }
}