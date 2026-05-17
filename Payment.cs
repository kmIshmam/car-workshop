using Salon_management_system;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Workshop_Management_System
{
    public partial class Payment : Form
    {
        private DataTable cartTable;
        private double totalAmount = 0;
        private double discountAmount = 0;

        public Payment(DataTable table)
        {
            InitializeComponent();
            cartTable = table;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (cartTable == null || cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Service cart is empty!");
                this.Close();
                return;
            }

            LoadCart();
            LoadPaymentMethods();
        }

        // ================= LOAD CART =================
        private void LoadCart()
        {
            dataGridView1.DataSource = cartTable;

            totalAmount = 0;

            foreach (DataRow row in cartTable.Rows)
            {
                string priceText = row["Price"].ToString()
                    .Replace("BDT", "")
                    .Trim();

                if (double.TryParse(priceText, out double price))
                {
                    totalAmount += price;
                }
            }

            UpdateTotal();
        }

        // ================= PAYMENT METHODS =================
        private void LoadPaymentMethods()
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("bKash");
            comboBox1.Items.Add("Nagad");
            comboBox1.Items.Add("Credit Card");
        }

        // ================= APPLY DISCOUNT =================
        private void buttonApplyDiscount_Click(object sender, EventArgs e)
        {
            if (cartTable == null || cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            string code = textBoxDiscount.Text.Trim().ToUpper();

            discountAmount = 0;

            if (code == "CAR10")
            {
                discountAmount = totalAmount * 0.10;
            }
            else if (code == "ENGINE15")
            {
                discountAmount = totalAmount * 0.15;
            }
            else if (code == "WORKSHOP20")
            {
                discountAmount = totalAmount * 0.20;
            }
            else if (!string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Invalid Voucher Code!");
            }

            UpdateTotal();
        }

        // ================= UPDATE TOTAL =================
        private void UpdateTotal()
        {
            double finalTotal = totalAmount - discountAmount;

            if (finalTotal < 0)
                finalTotal = 0;

            labelTotal.Text = "TOTAL BILL : " + finalTotal + " BDT";
        }

        // ================= PAYMENT =================
        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (cartTable == null || cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select payment method!");
                return;
            }

            double finalTotal = totalAmount - discountAmount;

            if (finalTotal < 0)
                finalTotal = 0;

            int orderId = 0;

            try
            {
                using (SqlConnection conn = DBconnect.Connect())
                {
                    conn.Open();

                    // ================= ORDERS =================
                    SqlCommand cmdOrder = new SqlCommand(
                    @"INSERT INTO Orders
                    (OrderDate, TotalAmount, PaymentMethod)
                    OUTPUT INSERTED.OrderId
                    VALUES (@date,@total,@method)", conn);

                    cmdOrder.Parameters.AddWithValue("@date", DateTime.Now);
                    cmdOrder.Parameters.AddWithValue("@total", finalTotal);
                    cmdOrder.Parameters.AddWithValue("@method", comboBox1.Text);

                    orderId = (int)cmdOrder.ExecuteScalar();

                    // ================= ORDER DETAILS =================
                    foreach (DataRow row in cartTable.Rows)
                    {
                        SqlCommand cmdDetails = new SqlCommand(
                        @"INSERT INTO OrderDetails
                        (OrderId, ServiceName, Price)
                        VALUES (@oid,@name,@price)", conn);

                        cmdDetails.Parameters.AddWithValue("@oid", orderId);
                        cmdDetails.Parameters.AddWithValue("@name",
                            row["Service"].ToString());

                        cmdDetails.Parameters.AddWithValue("@price",
                            row["Price"].ToString());

                        cmdDetails.ExecuteNonQuery();
                    }
                }

                // ================= INVOICE =================
                string invoice =
                "============= CAR WORKSHOP INVOICE =============\n\n" +
                "Order ID : " + orderId + "\n" +
                "Date : " + DateTime.Now + "\n\n" +

                "---------------- SERVICES ----------------\n";

                foreach (DataRow row in cartTable.Rows)
                {
                    invoice +=
                    "• " +
                    row["Service"].ToString() +
                    " - " +
                    row["Price"].ToString() +
                    " BDT\n";
                }

                invoice +=
                "\n-------------------------------------------\n" +
                "Subtotal : " + totalAmount + " BDT\n" +
                "Discount : " + discountAmount + " BDT\n" +
                "Final Bill : " + finalTotal + " BDT\n\n" +
                "Payment : " + comboBox1.Text + "\n\n" +

                "✔ PAYMENT SUCCESSFUL!\n" +
                "THANK YOU FOR VISITING OUR WORKSHOP!\n" +

                "===========================================";

                MessageBox.Show(invoice, "Workshop Invoice");

                // ================= RESET =================
                cartTable.Clear();

                dataGridView1.DataSource = null;

                totalAmount = 0;
                discountAmount = 0;

                textBoxDiscount.Clear();

                comboBox1.SelectedIndex = -1;

                labelTotal.Text = "TOTAL BILL : 0 BDT";

                this.Hide();

                new Review().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment Failed : " + ex.Message);
            }
        }

        // ================= BACK =================
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Service().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}