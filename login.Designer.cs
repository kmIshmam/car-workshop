namespace Car_Workshop_Management_System
{
    partial class login
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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Showpass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9F);
            this.label2.Location = new System.Drawing.Point(88, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);

            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this.Username.Location = new System.Drawing.Point(88, 102);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(190, 22);
            this.Username.TabIndex = 2;

            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this.Password.Location = new System.Drawing.Point(88, 160);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(190, 22);
            this.Password.TabIndex = 3;

            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9F);
            this.label3.Location = new System.Drawing.Point(88, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Showpass.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.Showpass.Location = new System.Drawing.Point(88, 190);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(118, 19);
            this.Showpass.TabIndex = 5;
            this.Showpass.Text = "Show Password";
            this.Showpass.UseVisualStyleBackColor = false;
            this.Showpass.CheckedChanged += new System.EventHandler(this.Showpass_CheckedChanged);

            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(88, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(88, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 8.25F,
                System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);

            this.label4.Location = new System.Drawing.Point(88, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "New here? Create an account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Showpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Workshop Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Showpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}