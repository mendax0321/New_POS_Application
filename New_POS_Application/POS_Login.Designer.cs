namespace New_POS_Application
{
    partial class POS_Login
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
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.usernameTxtbox = new System.Windows.Forms.TextBox();
            this.Password_tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.BackColor = System.Drawing.Color.MistyRose;
            this.LogIn_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_btn.Location = new System.Drawing.Point(281, 328);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(109, 41);
            this.LogIn_btn.TabIndex = 10;
            this.LogIn_btn.Text = "Login";
            this.LogIn_btn.UseVisualStyleBackColor = false;
            this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbox.Location = new System.Drawing.Point(332, 220);
            this.usernameTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(189, 29);
            this.usernameTxtbox.TabIndex = 8;
            // 
            // Password_tbox
            // 
            this.Password_tbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tbox.Location = new System.Drawing.Point(332, 270);
            this.Password_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_tbox.Name = "Password_tbox";
            this.Password_tbox.Size = new System.Drawing.Size(189, 29);
            this.Password_tbox.TabIndex = 9;
            this.Password_tbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.MistyRose;
            this.Cancel_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Location = new System.Drawing.Point(396, 328);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(109, 41);
            this.Cancel_btn.TabIndex = 11;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // picbox
            // 
            this.picbox.Image = global::New_POS_Application.Properties.Resources._default;
            this.picbox.Location = new System.Drawing.Point(310, 47);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(186, 155);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 12;
            this.picbox.TabStop = false;
            // 
            // POS_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::New_POS_Application.Properties.Resources.FHnMmwAaMAkHwSN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.LogIn_btn);
            this.Controls.Add(this.usernameTxtbox);
            this.Controls.Add(this.Password_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "POS_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.POS_Login_FormClosed);
            this.Load += new System.EventHandler(this.POS_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.TextBox usernameTxtbox;
        private System.Windows.Forms.TextBox Password_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.PictureBox picbox;
    }
}