using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        // ================= LOAD =================

        private void Category_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        // ================= LOAD GRID =================

        private void LoadGrid()
        {
            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM Categories",
                        conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        // ================= CLEAR =================

        private void ClearFields()
        {
            txtCategoryName.Clear();
            txtCategoryName.Focus();
        }

        // ================= ADD =================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Enter category name!");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO Categories (CategoryName) VALUES (@name)",
                        conn);

                cmd.Parameters.AddWithValue(
                    "@name",
                    txtCategoryName.Text);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Category Added Successfully!");

            LoadGrid();

            ClearFields();
        }

        // ================= UPDATE =================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a row first!");
                return;
            }

            int id =
                Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["CategoryId"].Value);

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "UPDATE Categories SET CategoryName=@name WHERE CategoryId=@id",
                        conn);

                cmd.Parameters.AddWithValue(
                    "@name",
                    txtCategoryName.Text);

                cmd.Parameters.AddWithValue(
                    "@id",
                    id);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Category Updated Successfully!");

            LoadGrid();

            ClearFields();
        }

        // ================= DELETE =================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a row first!");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure?",
                    "Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            int id =
                Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["CategoryId"].Value);

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "DELETE FROM Categories WHERE CategoryId=@id",
                        conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    id);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Category Deleted Successfully!");

            LoadGrid();

            ClearFields();
        }

        // ================= GRID CLICK =================

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCategoryName.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["CategoryName"]
                    .Value
                    .ToString();
            }
        }

        // ================= CLEAR BUTTON =================

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ================= BACK =================

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.Show();

            this.Hide();
        }
    }
}