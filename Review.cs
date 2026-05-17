using Car_Workshop_Management_System;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Salon_management_system
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void Review_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select rating!");
                return;
            }

            using (SqlConnection conn = DBconnect.Connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Reviews VALUES (@n,@r,@c,@d)", conn);

                cmd.Parameters.AddWithValue("@n", DBconnect.loggedinusername);
                cmd.Parameters.AddWithValue("@r", comboBox1.Text);
                cmd.Parameters.AddWithValue("@c", textBoxComment.Text);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thank you for your review!");

            this.Hide();
            new Service().Show();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Service().Show();
        }
    }
}