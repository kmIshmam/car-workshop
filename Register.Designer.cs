namespace Car_Workshop_Management_System
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.comboGender = new System.Windows.Forms.ComboBox();

            this.SuspendLayout();

            // FORM

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.PeachPuff;

            this.ClientSize =
                new System.Drawing.Size(700, 420);

            this.Font =
                new System.Drawing.Font("Lucida Bright", 9F);

            this.Name = "Register";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Car Workshop Register";

            this.Load +=
                new System.EventHandler(this.Register_Load);

            // TITLE

            this.label5.BackColor =
                System.Drawing.Color.LightYellow;

            this.label5.BorderStyle =
                System.Windows.Forms.BorderStyle.Fixed3D;

            this.label5.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    16F,
                    System.Drawing.FontStyle.Bold);

            this.label5.Location =
                new System.Drawing.Point(250, 15);

            this.label5.Size =
                new System.Drawing.Size(180, 35);

            this.label5.Text =
                "SIGN UP";

            this.label5.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // NAME

            this.label1.AutoSize = true;
            this.label1.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.label1.Location =
                new System.Drawing.Point(60, 80);

            this.label1.Text = "NAME:";

            this.Username.Location =
                new System.Drawing.Point(60, 100);

            this.Username.Size =
                new System.Drawing.Size(220, 22);

            // EMAIL

            this.label4.AutoSize = true;
            this.label4.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.label4.Location =
                new System.Drawing.Point(60, 140);

            this.label4.Text = "EMAIL:";

            this.txtEmail.Location =
                new System.Drawing.Point(60, 160);

            this.txtEmail.Size =
                new System.Drawing.Size(220, 22);

            // PHONE

            this.label3.AutoSize = true;
            this.label3.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.label3.Location =
                new System.Drawing.Point(60, 200);

            this.label3.Text =
                "PHONE NUMBER:";

            this.txtPhone.Location =
                new System.Drawing.Point(60, 220);

            this.txtPhone.Size =
                new System.Drawing.Size(220, 22);

            // AGE

            this.label2.AutoSize = true;
            this.label2.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.label2.Location =
                new System.Drawing.Point(60, 260);

            this.label2.Text = "AGE:";

            this.txtAge.Location =
                new System.Drawing.Point(60, 280);

            this.txtAge.Size =
                new System.Drawing.Size(220, 22);

            // GENDER

            this.label8.AutoSize = true;
            this.label8.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.label8.Location =
                new System.Drawing.Point(380, 80);

            this.label8.Text = "GENDER:";

            this.comboGender.Location =
                new System.Drawing.Point(380, 100);

            this.comboGender.Size =
                new System.Drawing.Size(220, 22);

            this.comboGender.Items.AddRange(
                new object[]
                {
                    "Male",
                    "Female",
                    "Others"
                });

            this.comboGender.SelectedIndexChanged +=
                new System.EventHandler(
                    this.ComboGender_SelectedIndexChanged);

            // PASSWORD

            this.label6.AutoSize = true;
            this.label6.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.label6.Location =
                new System.Drawing.Point(380, 140);

            this.label6.Text = "PASSWORD:";

            this.Password.Location =
                new System.Drawing.Point(380, 160);

            this.Password.Size =
                new System.Drawing.Size(220, 22);

            // CONFIRM PASSWORD

            this.label7.AutoSize = true;
            this.label7.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.label7.Location =
                new System.Drawing.Point(380, 200);

            this.label7.Text =
                "CONFIRM PASSWORD:";

            this.ConfirmPassword.Location =
                new System.Drawing.Point(380, 220);

            this.ConfirmPassword.Size =
                new System.Drawing.Size(220, 22);

            // SHOW PASSWORD

            this.checkBoxShowPassword.AutoSize = true;

            this.checkBoxShowPassword.Location =
                new System.Drawing.Point(380, 255);

            this.checkBoxShowPassword.Text =
                "Show Password";

            this.checkBoxShowPassword.CheckedChanged +=
                new System.EventHandler(
                    this.CheckBoxShowPassword_CheckedChanged);

            // REGISTER BUTTON

            this.btnRegister.BackColor =
                System.Drawing.Color.LightGreen;

            this.btnRegister.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnRegister.Location =
                new System.Drawing.Point(380, 290);

            this.btnRegister.Size =
                new System.Drawing.Size(220, 35);

            this.btnRegister.Text =
                "REGISTER";

            this.btnRegister.UseVisualStyleBackColor = false;

            this.btnRegister.Click +=
                new System.EventHandler(
                    this.BtnRegister_Click);

            // LOGIN LABEL

            this.label9.AutoSize = true;

            this.label9.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    8F,
                    System.Drawing.FontStyle.Underline);

            this.label9.Location =
                new System.Drawing.Point(220, 350);

            this.label9.Text =
                "Already have an account?";

            // SIGN IN BUTTON

            this.btnSignIn.BackColor =
                System.Drawing.Color.LightCoral;

            this.btnSignIn.Font =
                new System.Drawing.Font(
                    "Lucida Bright",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnSignIn.Location =
                new System.Drawing.Point(220, 370);

            this.btnSignIn.Size =
                new System.Drawing.Size(180, 30);

            this.btnSignIn.Text =
                "SIGN IN";

            this.btnSignIn.UseVisualStyleBackColor = false;

            this.btnSignIn.Click +=
                new System.EventHandler(
                    this.BtnSignIn_Click);

            // CONTROLS

            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.comboGender);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.ComboBox comboGender;
    }
}