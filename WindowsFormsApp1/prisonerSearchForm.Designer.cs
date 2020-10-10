namespace WindowsFormsApp1
{
    partial class prisonerSearchForm
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
            this.freeSoonGrp = new System.Windows.Forms.GroupBox();
            this.searchFreeSoonBtn = new System.Windows.Forms.Button();
            this.punishmentYearTxt = new System.Windows.Forms.TextBox();
            this.punishmentYearLbl = new System.Windows.Forms.Label();
            this.certainPrisonGrp = new System.Windows.Forms.GroupBox();
            this.searchCertainPrisonBtn = new System.Windows.Forms.Button();
            this.prisonNameTxt = new System.Windows.Forms.TextBox();
            this.prisonNameLbl = new System.Windows.Forms.Label();
            this.certainCellGrp = new System.Windows.Forms.GroupBox();
            this.searchCertainCellBtn = new System.Windows.Forms.Button();
            this.cellNumbTxt = new System.Windows.Forms.TextBox();
            this.cellNumbLbl = new System.Windows.Forms.Label();
            this.certainCrimeGrp = new System.Windows.Forms.GroupBox();
            this.searchCertainCrimeBtn = new System.Windows.Forms.Button();
            this.crimeTxt = new System.Windows.Forms.TextBox();
            this.crimeLbl = new System.Windows.Forms.Label();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.freeSoonGrp.SuspendLayout();
            this.certainPrisonGrp.SuspendLayout();
            this.certainCellGrp.SuspendLayout();
            this.certainCrimeGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // freeSoonGrp
            // 
            this.freeSoonGrp.Controls.Add(this.searchFreeSoonBtn);
            this.freeSoonGrp.Controls.Add(this.punishmentYearTxt);
            this.freeSoonGrp.Controls.Add(this.punishmentYearLbl);
            this.freeSoonGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSoonGrp.Location = new System.Drawing.Point(36, 70);
            this.freeSoonGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.freeSoonGrp.Name = "freeSoonGrp";
            this.freeSoonGrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.freeSoonGrp.Size = new System.Drawing.Size(321, 166);
            this.freeSoonGrp.TabIndex = 0;
            this.freeSoonGrp.TabStop = false;
            this.freeSoonGrp.Text = "Prisoners who will be free soon";
            this.freeSoonGrp.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchFreeSoonBtn
            // 
            this.searchFreeSoonBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchFreeSoonBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchFreeSoonBtn.Location = new System.Drawing.Point(240, 114);
            this.searchFreeSoonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchFreeSoonBtn.Name = "searchFreeSoonBtn";
            this.searchFreeSoonBtn.Size = new System.Drawing.Size(75, 34);
            this.searchFreeSoonBtn.TabIndex = 2;
            this.searchFreeSoonBtn.Text = "search";
            this.searchFreeSoonBtn.UseVisualStyleBackColor = false;
            this.searchFreeSoonBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // punishmentYearTxt
            // 
            this.punishmentYearTxt.Location = new System.Drawing.Point(163, 52);
            this.punishmentYearTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.punishmentYearTxt.Name = "punishmentYearTxt";
            this.punishmentYearTxt.Size = new System.Drawing.Size(100, 24);
            this.punishmentYearTxt.TabIndex = 1;
            this.punishmentYearTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // punishmentYearLbl
            // 
            this.punishmentYearLbl.AutoSize = true;
            this.punishmentYearLbl.Location = new System.Drawing.Point(23, 52);
            this.punishmentYearLbl.Name = "punishmentYearLbl";
            this.punishmentYearLbl.Size = new System.Drawing.Size(124, 18);
            this.punishmentYearLbl.TabIndex = 0;
            this.punishmentYearLbl.Text = "Punishment Year:";
            // 
            // certainPrisonGrp
            // 
            this.certainPrisonGrp.Controls.Add(this.searchCertainPrisonBtn);
            this.certainPrisonGrp.Controls.Add(this.prisonNameTxt);
            this.certainPrisonGrp.Controls.Add(this.prisonNameLbl);
            this.certainPrisonGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certainPrisonGrp.Location = new System.Drawing.Point(36, 254);
            this.certainPrisonGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.certainPrisonGrp.Name = "certainPrisonGrp";
            this.certainPrisonGrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.certainPrisonGrp.Size = new System.Drawing.Size(321, 166);
            this.certainPrisonGrp.TabIndex = 3;
            this.certainPrisonGrp.TabStop = false;
            this.certainPrisonGrp.Text = "Prisoners in a certain prison:";
            // 
            // searchCertainPrisonBtn
            // 
            this.searchCertainPrisonBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchCertainPrisonBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchCertainPrisonBtn.Location = new System.Drawing.Point(240, 112);
            this.searchCertainPrisonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCertainPrisonBtn.Name = "searchCertainPrisonBtn";
            this.searchCertainPrisonBtn.Size = new System.Drawing.Size(75, 36);
            this.searchCertainPrisonBtn.TabIndex = 2;
            this.searchCertainPrisonBtn.Text = "search";
            this.searchCertainPrisonBtn.UseVisualStyleBackColor = false;
            this.searchCertainPrisonBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // prisonNameTxt
            // 
            this.prisonNameTxt.Location = new System.Drawing.Point(151, 52);
            this.prisonNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prisonNameTxt.Name = "prisonNameTxt";
            this.prisonNameTxt.Size = new System.Drawing.Size(100, 24);
            this.prisonNameTxt.TabIndex = 1;
            // 
            // prisonNameLbl
            // 
            this.prisonNameLbl.AutoSize = true;
            this.prisonNameLbl.Location = new System.Drawing.Point(23, 52);
            this.prisonNameLbl.Name = "prisonNameLbl";
            this.prisonNameLbl.Size = new System.Drawing.Size(99, 18);
            this.prisonNameLbl.TabIndex = 0;
            this.prisonNameLbl.Text = "Prison Name:";
            // 
            // certainCellGrp
            // 
            this.certainCellGrp.Controls.Add(this.searchCertainCellBtn);
            this.certainCellGrp.Controls.Add(this.cellNumbTxt);
            this.certainCellGrp.Controls.Add(this.cellNumbLbl);
            this.certainCellGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certainCellGrp.Location = new System.Drawing.Point(384, 70);
            this.certainCellGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.certainCellGrp.Name = "certainCellGrp";
            this.certainCellGrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.certainCellGrp.Size = new System.Drawing.Size(321, 166);
            this.certainCellGrp.TabIndex = 3;
            this.certainCellGrp.TabStop = false;
            this.certainCellGrp.Text = "Prisoners in certain cell";
            // 
            // searchCertainCellBtn
            // 
            this.searchCertainCellBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchCertainCellBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchCertainCellBtn.Location = new System.Drawing.Point(240, 114);
            this.searchCertainCellBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCertainCellBtn.Name = "searchCertainCellBtn";
            this.searchCertainCellBtn.Size = new System.Drawing.Size(75, 34);
            this.searchCertainCellBtn.TabIndex = 2;
            this.searchCertainCellBtn.Text = "search";
            this.searchCertainCellBtn.UseVisualStyleBackColor = false;
            this.searchCertainCellBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // cellNumbTxt
            // 
            this.cellNumbTxt.Location = new System.Drawing.Point(151, 52);
            this.cellNumbTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cellNumbTxt.Name = "cellNumbTxt";
            this.cellNumbTxt.Size = new System.Drawing.Size(100, 24);
            this.cellNumbTxt.TabIndex = 1;
            // 
            // cellNumbLbl
            // 
            this.cellNumbLbl.AutoSize = true;
            this.cellNumbLbl.Location = new System.Drawing.Point(23, 52);
            this.cellNumbLbl.Name = "cellNumbLbl";
            this.cellNumbLbl.Size = new System.Drawing.Size(94, 18);
            this.cellNumbLbl.TabIndex = 0;
            this.cellNumbLbl.Text = "Cell Number:";
            // 
            // certainCrimeGrp
            // 
            this.certainCrimeGrp.Controls.Add(this.searchCertainCrimeBtn);
            this.certainCrimeGrp.Controls.Add(this.crimeTxt);
            this.certainCrimeGrp.Controls.Add(this.crimeLbl);
            this.certainCrimeGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certainCrimeGrp.Location = new System.Drawing.Point(735, 70);
            this.certainCrimeGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.certainCrimeGrp.Name = "certainCrimeGrp";
            this.certainCrimeGrp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.certainCrimeGrp.Size = new System.Drawing.Size(321, 166);
            this.certainCrimeGrp.TabIndex = 3;
            this.certainCrimeGrp.TabStop = false;
            this.certainCrimeGrp.Text = "Prisoners who make certain crime";
            // 
            // searchCertainCrimeBtn
            // 
            this.searchCertainCrimeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchCertainCrimeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchCertainCrimeBtn.Location = new System.Drawing.Point(241, 114);
            this.searchCertainCrimeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCertainCrimeBtn.Name = "searchCertainCrimeBtn";
            this.searchCertainCrimeBtn.Size = new System.Drawing.Size(75, 34);
            this.searchCertainCrimeBtn.TabIndex = 2;
            this.searchCertainCrimeBtn.Text = "search";
            this.searchCertainCrimeBtn.UseVisualStyleBackColor = false;
            this.searchCertainCrimeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // crimeTxt
            // 
            this.crimeTxt.Location = new System.Drawing.Point(151, 52);
            this.crimeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crimeTxt.Name = "crimeTxt";
            this.crimeTxt.Size = new System.Drawing.Size(100, 24);
            this.crimeTxt.TabIndex = 1;
            // 
            // crimeLbl
            // 
            this.crimeLbl.AutoSize = true;
            this.crimeLbl.Location = new System.Drawing.Point(23, 52);
            this.crimeLbl.Name = "crimeLbl";
            this.crimeLbl.Size = new System.Drawing.Size(52, 18);
            this.crimeLbl.TabIndex = 0;
            this.crimeLbl.Text = "Crime:";
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(384, 254);
            this.searchDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.Size = new System.Drawing.Size(672, 166);
            this.searchDataGridView.TabIndex = 4;
            // 
            // prisonerSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1108, 494);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.certainCrimeGrp);
            this.Controls.Add(this.certainCellGrp);
            this.Controls.Add(this.certainPrisonGrp);
            this.Controls.Add(this.freeSoonGrp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "prisonerSearchForm";
            this.Text = "Prisoner Search";
            this.freeSoonGrp.ResumeLayout(false);
            this.freeSoonGrp.PerformLayout();
            this.certainPrisonGrp.ResumeLayout(false);
            this.certainPrisonGrp.PerformLayout();
            this.certainCellGrp.ResumeLayout(false);
            this.certainCellGrp.PerformLayout();
            this.certainCrimeGrp.ResumeLayout(false);
            this.certainCrimeGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox freeSoonGrp;
        private System.Windows.Forms.Button searchFreeSoonBtn;
        private System.Windows.Forms.TextBox punishmentYearTxt;
        private System.Windows.Forms.Label punishmentYearLbl;
        private System.Windows.Forms.Button searchCertainPrisonBtn;
        private System.Windows.Forms.TextBox prisonNameTxt;
        private System.Windows.Forms.Label prisonNameLbl;
        private System.Windows.Forms.GroupBox certainCellGrp;
        private System.Windows.Forms.Button searchCertainCellBtn;
        private System.Windows.Forms.TextBox cellNumbTxt;
        private System.Windows.Forms.Label cellNumbLbl;
        private System.Windows.Forms.GroupBox certainCrimeGrp;
        private System.Windows.Forms.Button searchCertainCrimeBtn;
        private System.Windows.Forms.TextBox crimeTxt;
        private System.Windows.Forms.Label crimeLbl;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.GroupBox certainPrisonGrp;
    }
}