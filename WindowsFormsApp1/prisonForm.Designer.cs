namespace WindowsFormsApp1
{
    partial class prisonForm
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
            this.prisonNameLbl = new System.Windows.Forms.Label();
            this.prisonNameTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.prisonDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prisonNameLbl
            // 
            this.prisonNameLbl.AutoSize = true;
            this.prisonNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisonNameLbl.Location = new System.Drawing.Point(110, 94);
            this.prisonNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prisonNameLbl.Name = "prisonNameLbl";
            this.prisonNameLbl.Size = new System.Drawing.Size(156, 20);
            this.prisonNameLbl.TabIndex = 1;
            this.prisonNameLbl.Text = "Enter Prison Name:";
            // 
            // prisonNameTxt
            // 
            this.prisonNameTxt.Location = new System.Drawing.Point(283, 94);
            this.prisonNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.prisonNameTxt.Name = "prisonNameTxt";
            this.prisonNameTxt.Size = new System.Drawing.Size(246, 22);
            this.prisonNameTxt.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(63, 137);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 57);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(448, 137);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(138, 57);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // prisonDataGridView
            // 
            this.prisonDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prisonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prisonDataGridView.Location = new System.Drawing.Point(13, 202);
            this.prisonDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.prisonDataGridView.Name = "prisonDataGridView";
            this.prisonDataGridView.RowHeadersWidth = 51;
            this.prisonDataGridView.Size = new System.Drawing.Size(673, 216);
            this.prisonDataGridView.TabIndex = 8;
            // 
            // prisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(709, 506);
            this.Controls.Add(this.prisonDataGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.prisonNameTxt);
            this.Controls.Add(this.prisonNameLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "prisonForm";
            this.Text = "Prison";
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prisonNameLbl;
        private System.Windows.Forms.TextBox prisonNameTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView prisonDataGridView;
    }
}