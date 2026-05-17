using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================

        private void Register_Load(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
            ConfirmPassword.PasswordChar = '*';
        }

        // ================= SIGN IN =================

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        // ================= REGISTER =================

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = Username.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string gender = comboGender.Text.Trim();
            string password = Password.Text;
            string confirmPassword = ConfirmPassword.Text;

            // REQUIRED

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(ageText) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            // EMAIL VALIDATION

            if (!email.EndsWith("@gmail.com") || !email.Contains("@"))
            {
                MessageBox.Show("Email must be valid!");
                return;
            }

            // PHONE VALIDATION

            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be 11 digits!");
                return;
            }

            // AGE VALIDATION

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be numeric!");
                return;
            }

            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100!");
                return;
            }

            // PASSWORD VALIDATION

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be minimum 8 characters!");
                return;
            }

            // MATCH PASSWORD

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                conn.Open();

                string query =
                    @"INSERT INTO Users
                    (Name, Email, Phone, Age, Gender, Password, Role)
                    VALUES
                    (@n,@e,@p,@a,@g,@pass,'Customer')";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", phone);
                cmd.Parameters.AddWithValue("@a", age);
                cmd.Parameters.AddWithValue("@g", gender);
                cmd.Parameters.AddWithValue("@pass", password);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!");

                login l = new login();
                l.Show();

                this.Hide();
            }
        }

        // ================= SHOW PASSWORD =================

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                Password.PasswordChar = '\0';
                ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
                ConfirmPassword.PasswordChar = '*';
            }
        }

        // ================= GENDER =================

        private void ComboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}