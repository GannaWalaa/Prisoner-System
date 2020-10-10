namespace WindowsFormsApp1
{
    partial class deleteOfficerForm
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
            this.officerNameLbl = new System.Windows.Forms.Label();
            this.officerIDLbl = new System.Windows.Forms.Label();
            this.officerNameTxt = new System.Windows.Forms.TextBox();
            this.officerIDTxt = new System.Windows.Forms.TextBox();
            this.officerDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // officerNameLbl
            // 
            this.officerNameLbl.AutoSize = true;
            this.officerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerNameLbl.Location = new System.Drawing.Point(44, 68);
            this.officerNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.officerNameLbl.Name = "officerNameLbl";
            this.officerNameLbl.Size = new System.Drawing.Size(155, 20);
            this.officerNameLbl.TabIndex = 0;
            this.officerNameLbl.Text = "Enter officer Name:";
            // 
            // officerIDLbl
            // 
            this.officerIDLbl.AutoSize = true;
            this.officerIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerIDLbl.Location = new System.Drawing.Point(44, 154);
            this.officerIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.officerIDLbl.Name = "officerIDLbl";
            this.officerIDLbl.Size = new System.Drawing.Size(87, 20);
            this.officerIDLbl.TabIndex = 1;
            this.officerIDLbl.Text = "Officer ID:";
            // 
            // officerNameTxt
            // 
            this.officerNameTxt.Location = new System.Drawing.Point(237, 66);
            this.officerNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.officerNameTxt.Name = "officerNameTxt";
            this.officerNameTxt.Size = new System.Drawing.Size(170, 22);
            this.officerNameTxt.TabIndex = 2;
            // 
            // officerIDTxt
            // 
            this.officerIDTxt.Location = new System.Drawing.Point(237, 152);
            this.officerIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.officerIDTxt.Name = "officerIDTxt";
            this.officerIDTxt.Size = new System.Drawing.Size(170, 22);
            this.officerIDTxt.TabIndex = 3;
            // 
            // officerDataGridView
            // 
            this.officerDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.officerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officerDataGridView.Location = new System.Drawing.Point(33, 221);
            this.officerDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.officerDataGridView.Name = "officerDataGridView";
            this.officerDataGridView.RowHeadersWidth = 51;
            this.officerDataGridView.Size = new System.Drawing.Size(571, 262);
            this.officerDataGridView.TabIndex = 4;
            this.officerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(439, 49);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 57);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(439, 135);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(138, 57);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteOfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(642, 539);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.officerDataGridView);
            this.Controls.Add(this.officerIDTxt);
            this.Controls.Add(this.officerNameTxt);
            this.Controls.Add(this.officerIDLbl);
            this.Controls.Add(this.officerNameLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "deleteOfficerForm";
            this.Text = "Delete Officer";
            ((System.ComponentModel.ISupportInitialize)(this.officerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label officerNameLbl;
        private System.Windows.Forms.Label officerIDLbl;
        private System.Windows.Forms.TextBox officerNameTxt;
        private System.Windows.Forms.TextBox officerIDTxt;
        private System.Windows.Forms.DataGridView officerDataGridView;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}