using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        // ================= LOAD =================

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCategories();
            LoadVehicleTypes();
            LoadFuelTypes();
        }

        // ================= LOAD CATEGORY =================

        private void LoadCategories()
        {
            comboCategory.Items.Clear();

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "SELECT CategoryName FROM Categories",
                        conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboCategory.Items.Add(
                        reader["CategoryName"].ToString());
                }
            }
        }

        // ================= VEHICLE TYPES =================

        private void LoadVehicleTypes()
        {
            comboVehicle.Items.Clear();

            comboVehicle.Items.Add("Car");
            comboVehicle.Items.Add("SUV");
            comboVehicle.Items.Add("Truck");
            comboVehicle.Items.Add("Bike");
            comboVehicle.Items.Add("Bus");
            comboVehicle.Items.Add("Hybrid");
        }

        // ================= FUEL TYPES =================

        private void LoadFuelTypes()
        {
            comboFuel.Items.Clear();

            comboFuel.Items.Add("Petrol");
            comboFuel.Items.Add("Diesel");
            comboFuel.Items.Add("Electric");
            comboFuel.Items.Add("Hybrid");
            comboFuel.Items.Add("CNG");
        }

        // ================= LOAD GRID =================

        private void LoadGrid()
        {
            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(

                    @"SELECT 
                        s.ServiceId,
                        c.CategoryName AS Category,
                        s.ServiceName,
                        s.VehicleType,
                        s.FuelType,
                        s.Price

                    FROM Services s

                    JOIN Categories c
                    ON s.CategoryId = c.CategoryId",

                    conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        // ================= GET CATEGORY ID =================

        private int GetCategoryId(string categoryName)
        {
            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "SELECT CategoryId FROM Categories WHERE CategoryName=@name",
                        conn);

                cmd.Parameters.AddWithValue(
                    "@name",
                    categoryName);

                conn.Open();

                return Convert.ToInt32(
                    cmd.ExecuteScalar());
            }
        }

        // ================= ADD =================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
                comboCategory.Text == "" ||
                txtService.Text == "" ||
                comboVehicle.Text == "" ||
                comboFuel.Text == "" ||
                txtPrice.Text == ""
               )
            {
                MessageBox.Show("Fill all fields!");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(

                    @"INSERT INTO Services
                    (
                        CategoryId,
                        ServiceName,
                        VehicleType,
                        FuelType,
                        Price
                    )

                    VALUES
                    (
                        @c,
                        @s,
                        @v,
                        @f,
                        @p
                    )",

                    conn);

                cmd.Parameters.AddWithValue(
                    "@c",
                    GetCategoryId(comboCategory.Text));

                cmd.Parameters.AddWithValue(
                    "@s",
                    txtService.Text);

                cmd.Parameters.AddWithValue(
                    "@v",
                    comboVehicle.Text);

                cmd.Parameters.AddWithValue(
                    "@f",
                    comboFuel.Text);

                cmd.Parameters.AddWithValue(
                    "@p",
                    txtPrice.Text);

                conn.Open();

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Service Added Successfully!");

            LoadGrid();

            ClearFields();
        }

        // ================= UPDATE =================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select row first!");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(

                    @"UPDATE Services

                    SET

                    CategoryId=@c,
                    ServiceName=@s,
                    VehicleType=@v,
                    FuelType=@f,
                    Price=@p

                    WHERE ServiceId=@id",

                    conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtID.Text);

                cmd.Parameters.AddWithValue(
                    "@c",
                    GetCategoryId(comboCategory.Text));

                cmd.Parameters.AddWithValue(
                    "@s",
                    txtService.Text);

                cmd.Parameters.AddWithValue(
                    "@v",
                    comboVehicle.Text);

                cmd.Parameters.AddWithValue(
                    "@f",
                    comboFuel.Text);

                cmd.Parameters.AddWithValue(
                    "@p",
                    txtPrice.Text);

                conn.Open();

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Service Updated!");

            LoadGrid();

            ClearFields();
        }

        // ================= DELETE =================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select row first!");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "DELETE FROM Services WHERE ServiceId=@id",
                        conn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    txtID.Text);

                conn.Open();

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Service Deleted!");

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
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                txtID.Text =
                    row.Cells["ServiceId"].Value.ToString();

                comboCategory.Text =
                    row.Cells["Category"].Value.ToString();

                txtService.Text =
                    row.Cells["ServiceName"].Value.ToString();

                comboVehicle.Text =
                    row.Cells["VehicleType"].Value.ToString();

                comboFuel.Text =
                    row.Cells["FuelType"].Value.ToString();

                txtPrice.Text =
                    row.Cells["Price"].Value.ToString();
            }
        }

        // ================= CLEAR =================

        private void ClearFields()
        {
            txtID.Clear();

            comboCategory.SelectedIndex = -1;

            txtService.Clear();

            comboVehicle.SelectedIndex = -1;

            comboFuel.SelectedIndex = -1;

            txtPrice.Clear();
        }

        // ================= BACK =================

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();

            d.Show();

            this.Hide();
        }
    }
}