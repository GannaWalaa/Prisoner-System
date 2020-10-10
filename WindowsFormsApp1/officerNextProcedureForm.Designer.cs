namespace WindowsFormsApp1
{
    partial class officerNextProcedureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(officerNextProcedureForm));
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nextProcedureLbl = new System.Windows.Forms.Label();
            this.officerPic = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(451, 236);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(281, 82);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update Cell";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(107, 236);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(281, 82);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // nextProcedureLbl
            // 
            this.nextProcedureLbl.AutoSize = true;
            this.nextProcedureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextProcedureLbl.Location = new System.Drawing.Point(101, 167);
            this.nextProcedureLbl.Name = "nextProcedureLbl";
            this.nextProcedureLbl.Size = new System.Drawing.Size(489, 25);
            this.nextProcedureLbl.TabIndex = 7;
            this.nextProcedureLbl.Text = "Hello Officer, Please Select Your Next Procedure:";
            // 
            // officerPic
            // 
            this.officerPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("officerPic.BackgroundImage")));
            this.officerPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.officerPic.Location = new System.Drawing.Point(353, 17);
            this.officerPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.officerPic.Name = "officerPic";
            this.officerPic.Size = new System.Drawing.Size(131, 121);
            this.officerPic.TabIndex = 10;
            this.officerPic.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(284, 326);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(281, 82);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add Prisoner";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // officerNextProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(843, 469);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.officerPic);
            this.Controls.Add(this.nextProcedureLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.updateBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "officerNextProcedureForm";
            this.Text = "Officer";
            ((System.ComponentModel.ISupportInitialize)(this.officerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label nextProcedureLbl;
        private System.Windows.Forms.PictureBox officerPic;
        private System.Windows.Forms.Button addBtn;
    }
}