using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        // ================= LOAD =================

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        // ================= LOAD ORDERS =================

        private void LoadOrders()
        {
            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        @"SELECT 
                            OrderId,
                            OrderDate,
                            TotalAmount,
                            PaymentMethod
                          FROM Orders
                          ORDER BY OrderId DESC",
                        conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridViewOrders.DataSource = dt;
            }
        }

        // ================= LOAD ORDER DETAILS =================

        private void LoadOrderDetails(int orderId)
        {
            using (SqlConnection conn = DBconnect.Connect())
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        @"SELECT 
                            ServiceName,
                            Price
                          FROM OrderDetails
                          WHERE OrderId=@id",
                        conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@id",
                    orderId);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridViewDetails.DataSource = dt;
            }
        }

        // ================= ORDER CLICK =================

        private void dataGridViewOrders_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId =
                    Convert.ToInt32(
                        dataGridViewOrders.Rows[e.RowIndex]
                        .Cells["OrderId"]
                        .Value);

                LoadOrderDetails(orderId);
            }
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