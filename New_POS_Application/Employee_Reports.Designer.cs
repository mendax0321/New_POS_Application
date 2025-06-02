namespace New_POS_Application
{
    partial class Employee_Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.Option_tbox = new System.Windows.Forms.TextBox();
            this.Option_cbox = new System.Windows.Forms.ComboBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT AN OPTION:";
            // 
            // Option_tbox
            // 
            this.Option_tbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_tbox.Location = new System.Drawing.Point(353, 22);
            this.Option_tbox.Name = "Option_tbox";
            this.Option_tbox.Size = new System.Drawing.Size(190, 22);
            this.Option_tbox.TabIndex = 1;
            // 
            // Option_cbox
            // 
            this.Option_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Option_cbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_cbox.FormattingEnabled = true;
            this.Option_cbox.Items.AddRange(new object[] {
            "EMPLOYEE_NUMBER",
            "SURNAME",
            "FIRSTNAME",
            "DEPARTMENT",
            "DESIGNATION",
            "ZIPCODE",
            "PROVINCE",
            "CITY"});
            this.Option_cbox.Location = new System.Drawing.Point(182, 23);
            this.Option_cbox.Name = "Option_cbox";
            this.Option_cbox.Size = new System.Drawing.Size(165, 21);
            this.Option_cbox.TabIndex = 2;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.Search_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(549, 19);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(100, 30);
            this.Search_btn.TabIndex = 3;
            this.Search_btn.Text = "SEARCH";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.BurlyWood;
            this.Back_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(655, 19);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 30);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "BACK";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 56);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(776, 382);
            this.GridView.TabIndex = 4;
            // 
            // Employee_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Option_cbox);
            this.Controls.Add(this.Option_tbox);
            this.Controls.Add(this.label1);
            this.Name = "Employee_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Reports";
            this.Load += new System.EventHandler(this.Employee_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Option_tbox;
        private System.Windows.Forms.ComboBox Option_cbox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.DataGridView GridView;
    }
}