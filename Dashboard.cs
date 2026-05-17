using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // ================= LOAD =================

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            LoadDashboardData();

            LoadReviews();
        }

        // ================= DASHBOARD DATA =================

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = DBconnect.Connect())
                {
                    conn.Open();

                    // TOTAL SERVICES
                    SqlCommand cmdServices =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Services",
                            conn);

                    lblServices.Text =
                        cmdServices.ExecuteScalar().ToString();

                    // TOTAL ORDERS
                    SqlCommand cmdOrders =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Orders",
                            conn);

                    lblOrders.Text =
                        cmdOrders.ExecuteScalar().ToString();

                    // TOTAL SALES
                    SqlCommand cmdSales =
                           new SqlCommand(
                              "SELECT ISNULL(SUM(TotalAmount),0) FROM Orders",
                                 conn);

                    decimal totalSales =
                        Convert.ToDecimal(cmdSales.ExecuteScalar());

                    lblSales.Text =
                        totalSales.ToString("N0") + " BDT";

                    // TOTAL USERS
                    SqlCommand cmdUsers =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Users",
                            conn);

                    lblUsers.Text =
                        cmdUsers.ExecuteScalar().ToString();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= LOAD REVIEWS =================

        private void LoadReviews()
        {
            try
            {
                using (SqlConnection conn = DBconnect.Connect())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                            "SELECT CustomerName, Rating, Comment, ReviewDate FROM Reviews ORDER BY ReviewId DESC",
                            conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridViewReviews.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= BUTTONS =================

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();
            o.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();

            LoadReviews();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}