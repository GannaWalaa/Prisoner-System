namespace WindowsFormsApp1
{
    partial class adminManageChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminManageChooseForm));
            this.nextProcedureLbl = new System.Windows.Forms.Label();
            this.officerInfoBtn = new System.Windows.Forms.Button();
            this.prisonInfoBtn = new System.Windows.Forms.Button();
            this.adminPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nextProcedureLbl
            // 
            this.nextProcedureLbl.AutoSize = true;
            this.nextProcedureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextProcedureLbl.Location = new System.Drawing.Point(102, 168);
            this.nextProcedureLbl.Name = "nextProcedureLbl";
            this.nextProcedureLbl.Size = new System.Drawing.Size(486, 25);
            this.nextProcedureLbl.TabIndex = 6;
            this.nextProcedureLbl.Text = "Hello Admin, Please Select Your Next Procedure:";
            this.nextProcedureLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // officerInfoBtn
            // 
            this.officerInfoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.officerInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerInfoBtn.Location = new System.Drawing.Point(107, 236);
            this.officerInfoBtn.Name = "officerInfoBtn";
            this.officerInfoBtn.Size = new System.Drawing.Size(281, 82);
            this.officerInfoBtn.TabIndex = 7;
            this.officerInfoBtn.Text = "Manage Officer Information";
            this.officerInfoBtn.UseVisualStyleBackColor = false;
            this.officerInfoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // prisonInfoBtn
            // 
            this.prisonInfoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prisonInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonInfoBtn.Location = new System.Drawing.Point(451, 236);
            this.prisonInfoBtn.Name = "prisonInfoBtn";
            this.prisonInfoBtn.Size = new System.Drawing.Size(281, 82);
            this.prisonInfoBtn.TabIndex = 8;
            this.prisonInfoBtn.Text = "Manage Prison Information";
            this.prisonInfoBtn.UseVisualStyleBackColor = false;
            this.prisonInfoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminPic
            // 
            this.adminPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminPic.BackgroundImage")));
            this.adminPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminPic.Location = new System.Drawing.Point(353, 17);
            this.adminPic.Name = "adminPic";
            this.adminPic.Size = new System.Drawing.Size(130, 120);
            this.adminPic.TabIndex = 9;
            this.adminPic.TabStop = false;
            // 
            // adminManageChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(830, 406);
            this.Controls.Add(this.adminPic);
            this.Controls.Add(this.prisonInfoBtn);
            this.Controls.Add(this.officerInfoBtn);
            this.Controls.Add(this.nextProcedureLbl);
            this.Name = "adminManageChooseForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nextProcedureLbl;
        private System.Windows.Forms.Button officerInfoBtn;
        private System.Windows.Forms.Button prisonInfoBtn;
        private System.Windows.Forms.PictureBox adminPic;
    }
}