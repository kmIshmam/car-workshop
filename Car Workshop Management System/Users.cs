using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        // ================= LOAD =================

        private void Users_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // ================= LOAD USERS =================

        private void LoadUsers()
        {
            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT UserId, Name, Email, Phone, Age, Gender, Password, Role FROM Users",
                    conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        // ================= ADD =================

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Users
                    (Name, Email, Phone, Age, Gender, Password, Role)
                    VALUES
                    (@n,@e,@p,@a,@g,@pw,@r)", conn);

                cmd.Parameters.AddWithValue("@n", txtUsername.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@a", txtAge.Text);
                cmd.Parameters.AddWithValue("@g", comboGender.Text);
                cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                cmd.Parameters.AddWithValue("@r", comboRole.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadUsers();
            ClearFields();

            MessageBox.Show("User Added Successfully");
        }

        // ================= UPDATE =================

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select User First");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Users SET
                    Name=@n,
                    Email=@e,
                    Phone=@p,
                    Age=@a,
                    Gender=@g,
                    Password=@pw,
                    Role=@r
                    WHERE Id=@id", conn);

                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@n", txtUsername.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@a", txtAge.Text);
                cmd.Parameters.AddWithValue("@g", comboGender.Text);
                cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                cmd.Parameters.AddWithValue("@r", comboRole.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadUsers();
            ClearFields();

            MessageBox.Show("User Updated Successfully");
        }

        // ================= DELETE =================

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select User First");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Users WHERE UserId=@id", conn);

                cmd.Parameters.AddWithValue("@id", txtID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadUsers();
            ClearFields();

            MessageBox.Show("User Deleted Successfully");
        }

        // ================= GRID CLICK =================

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text =
                    row.Cells["UserId"].Value.ToString();

                txtUsername.Text =
                    row.Cells["Name"].Value.ToString();

                txtEmail.Text =
                    row.Cells["Email"].Value.ToString();

                txtPhone.Text =
                    row.Cells["Phone"].Value.ToString();

                txtAge.Text =
                    row.Cells["Age"].Value.ToString();

                comboGender.Text =
                    row.Cells["Gender"].Value.ToString();

                txtPassword.Text =
                    row.Cells["Password"].Value.ToString();

                comboRole.Text =
                    row.Cells["Role"].Value.ToString();
            }
        }

        // ================= CLEAR =================

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAge.Clear();
            txtPassword.Clear();

            comboGender.SelectedIndex = -1;
            comboRole.SelectedIndex = -1;
        }

        // ================= BACK =================

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}