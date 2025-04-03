namespace New_POS_Application
{
    partial class POS_PrintEmpSal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_PrintEmpSal));
            this.PrintDisplay_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PrintDisplay_listbox
            // 
            this.PrintDisplay_listbox.BackColor = System.Drawing.Color.Lavender;
            this.PrintDisplay_listbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintDisplay_listbox.FormattingEnabled = true;
            this.PrintDisplay_listbox.ItemHeight = 15;
            this.PrintDisplay_listbox.Location = new System.Drawing.Point(12, 12);
            this.PrintDisplay_listbox.Name = "PrintDisplay_listbox";
            this.PrintDisplay_listbox.Size = new System.Drawing.Size(384, 499);
            this.PrintDisplay_listbox.TabIndex = 0;
            // 
            // POS_PrintEmpSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(408, 528);
            this.Controls.Add(this.PrintDisplay_listbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POS_PrintEmpSal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Employee Salary";
            this.Load += new System.EventHandler(this.POS_PrintEmpSal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox PrintDisplay_listbox;
    }
}