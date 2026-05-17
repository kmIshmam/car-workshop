using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Car_Workshop_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Username.Text.Trim();
            string password = Password.Text;

            if (name == "" || password == "")
            {
                MessageBox.Show("Enter username and password!");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                conn.Open();

                string query = "SELECT Role FROM Users WHERE Name=@n AND Password=@p";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@p", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();

                    DBconnect.loggedinusername = name;
                    DBconnect.loggedinuserrole = role;

                    if (role == "Admin")
                    {
                        MessageBox.Show("Welcome Admin!");

                        Dashboard d = new Dashboard();
                        d.Show();
                    }
                    else
                    {
                        MessageBox.Show("Welcome Customer!");

                        Service s = new Service();
                        s.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login!");
                }
            }
        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpass.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}