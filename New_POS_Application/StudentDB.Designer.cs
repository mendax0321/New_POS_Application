namespace New_POS_Application
{
    partial class StudentDB
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
            this.Pbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentNo_tbox = new System.Windows.Forms.TextBox();
            this.StudentName_tbox = new System.Windows.Forms.TextBox();
            this.Dept_tbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pboxpath = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.New_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Browse_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbox
            // 
            this.Pbox.Location = new System.Drawing.Point(12, 55);
            this.Pbox.Name = "Pbox";
            this.Pbox.Size = new System.Drawing.Size(300, 300);
            this.Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbox.TabIndex = 0;
            this.Pbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT DATABASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department :";
            // 
            // StudentNo_tbox
            // 
            this.StudentNo_tbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNo_tbox.Location = new System.Drawing.Point(458, 52);
            this.StudentNo_tbox.Name = "StudentNo_tbox";
            this.StudentNo_tbox.Size = new System.Drawing.Size(285, 25);
            this.StudentNo_tbox.TabIndex = 3;
            // 
            // StudentName_tbox
            // 
            this.StudentName_tbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName_tbox.Location = new System.Drawing.Point(458, 87);
            this.StudentName_tbox.Name = "StudentName_tbox";
            this.StudentName_tbox.Size = new System.Drawing.Size(285, 25);
            this.StudentName_tbox.TabIndex = 3;
            // 
            // Dept_tbox
            // 
            this.Dept_tbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dept_tbox.Location = new System.Drawing.Point(458, 123);
            this.Dept_tbox.Name = "Dept_tbox";
            this.Dept_tbox.Size = new System.Drawing.Size(285, 25);
            this.Dept_tbox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Pboxpath
            // 
            this.Pboxpath.Location = new System.Drawing.Point(99, 29);
            this.Pboxpath.Name = "Pboxpath";
            this.Pboxpath.Size = new System.Drawing.Size(100, 20);
            this.Pboxpath.TabIndex = 5;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Save_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(337, 318);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(146, 41);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Search_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(489, 318);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(137, 41);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "SEARCH";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Del_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_btn.Location = new System.Drawing.Point(632, 318);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(130, 41);
            this.Del_btn.TabIndex = 6;
            this.Del_btn.Text = "DELETE";
            this.Del_btn.UseVisualStyleBackColor = false;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Edit_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.Location = new System.Drawing.Point(337, 365);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(146, 41);
            this.Edit_btn.TabIndex = 6;
            this.Edit_btn.Text = "EDIT";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // New_btn
            // 
            this.New_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.New_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_btn.Location = new System.Drawing.Point(489, 365);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(137, 41);
            this.New_btn.TabIndex = 6;
            this.New_btn.Text = "NEW";
            this.New_btn.UseVisualStyleBackColor = false;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Cancel_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Location = new System.Drawing.Point(632, 365);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(130, 41);
            this.Cancel_btn.TabIndex = 6;
            this.Cancel_btn.Text = "CANCEL";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Browse_btn
            // 
            this.Browse_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Browse_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_btn.Location = new System.Drawing.Point(87, 361);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(146, 41);
            this.Browse_btn.TabIndex = 6;
            this.Browse_btn.Text = "BROWSE";
            this.Browse_btn.UseVisualStyleBackColor = false;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // StudentDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(774, 422);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.New_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Browse_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Pboxpath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Dept_tbox);
            this.Controls.Add(this.StudentName_tbox);
            this.Controls.Add(this.StudentNo_tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pbox);
            this.DoubleBuffered = true;
            this.Name = "StudentDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDB";
            this.Load += new System.EventHandler(this.StudentDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentNo_tbox;
        private System.Windows.Forms.TextBox StudentName_tbox;
        private System.Windows.Forms.TextBox Dept_tbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Pboxpath;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button New_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Browse_btn;
    }
}