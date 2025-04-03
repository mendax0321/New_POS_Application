namespace New_POS_Application
{
    partial class QRscanner
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.QRcamera = new System.Windows.Forms.ComboBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.CashScanned_tbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(221, 398);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(150, 40);
            this.Exit_btn.TabIndex = 1;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // QRcamera
            // 
            this.QRcamera.FormattingEnabled = true;
            this.QRcamera.Location = new System.Drawing.Point(12, 454);
            this.QRcamera.Name = "QRcamera";
            this.QRcamera.Size = new System.Drawing.Size(121, 21);
            this.QRcamera.TabIndex = 2;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // CashScanned_tbox
            // 
            this.CashScanned_tbox.Location = new System.Drawing.Point(12, 428);
            this.CashScanned_tbox.Name = "CashScanned_tbox";
            this.CashScanned_tbox.Size = new System.Drawing.Size(100, 20);
            this.CashScanned_tbox.TabIndex = 3;
            // 
            // QRscanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(585, 487);
            this.ControlBox = false;
            this.Controls.Add(this.CashScanned_tbox);
            this.Controls.Add(this.QRcamera);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRscanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRscanner";
            this.Load += new System.EventHandler(this.QRscanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.ComboBox QRcamera;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox CashScanned_tbox;
    }
}