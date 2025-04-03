namespace New_POS_Application
{
    partial class PrintFrm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printDisplayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(11, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(330, 384);
            this.textBox1.TabIndex = 0;
            // 
            // printDisplayListbox
            // 
            this.printDisplayListbox.FormattingEnabled = true;
            this.printDisplayListbox.Location = new System.Drawing.Point(29, 28);
            this.printDisplayListbox.Name = "printDisplayListbox";
            this.printDisplayListbox.Size = new System.Drawing.Size(295, 355);
            this.printDisplayListbox.TabIndex = 5;
            // 
            // PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 418);
            this.Controls.Add(this.printDisplayListbox);
            this.Controls.Add(this.textBox1);
            this.Name = "PrintFrm";
            this.Text = "PrintFrm";
            this.Load += new System.EventHandler(this.PrintFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox printDisplayListbox;
    }
}