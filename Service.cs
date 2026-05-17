using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Workshop_Management_System
{
    public partial class Service : Form
    {
        DataTable table = new DataTable();
        bool isAppointmentBooked = false;

        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadVehicleTypes();
            LoadFuelTypes();
        }

        private void SetupGrid()
        {
            table.Columns.Add("Vehicle Type");
            table.Columns.Add("Brand");
            table.Columns.Add("Service");
            table.Columns.Add("Fuel Type");
            table.Columns.Add("Price", typeof(double));

            dataGridView1.DataSource = table;
        }

        private void LoadVehicleTypes()
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Sedan");
            comboBox1.Items.Add("SUV");
            comboBox1.Items.Add("Truck");
            comboBox1.Items.Add("Motorbike");
            comboBox1.Items.Add("Microbus");
            comboBox1.Items.Add("Pickup");
        }

        private void LoadFuelTypes()
        {
            comboBox4.Items.Clear();

            comboBox4.Items.Add("Petrol");
            comboBox4.Items.Add("Diesel");
            comboBox4.Items.Add("Hybrid");
            comboBox4.Items.Add("Electric");
            comboBox4.Items.Add("CNG");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            string vehicle = comboBox1.Text;

            if (vehicle == "Sedan" || vehicle == "SUV")
            {
                comboBox2.Items.Add("Toyota");
                comboBox2.Items.Add("Honda");
                comboBox2.Items.Add("BMW");
                comboBox2.Items.Add("Audi");
            }
            else if (vehicle == "Truck" || vehicle == "Pickup")
            {
                comboBox2.Items.Add("Isuzu");
                comboBox2.Items.Add("Tata");
                comboBox2.Items.Add("Ashok Leyland");
            }
            else if (vehicle == "Motorbike")
            {
                comboBox2.Items.Add("Yamaha");
                comboBox2.Items.Add("Honda");
                comboBox2.Items.Add("Suzuki");
            }
            else
            {
                comboBox2.Items.Add("Hyundai");
                comboBox2.Items.Add("Nissan");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            comboBox3.Items.Add("Oil Change");
            comboBox3.Items.Add("Engine Repair");
            comboBox3.Items.Add("Brake Service");
            comboBox3.Items.Add("Battery Check");
            comboBox3.Items.Add("Car Wash");
            comboBox3.Items.Add("Wheel Alignment");
            comboBox3.Items.Add("AC Repair");
            comboBox3.Items.Add("Tire Replacement");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1 ||
                comboBox3.SelectedIndex == -1 ||
                comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all fields!");
                return;
            }

            string vehicle = comboBox1.Text;
            string brand = comboBox2.Text;
            string service = comboBox3.Text;
            string fuel = comboBox4.Text;

            double price = GetPrice(service);

            table.Rows.Add(vehicle, brand, service, fuel, price);
        }

        private double GetPrice(string service)
        {
            switch (service)
            {
                case "Oil Change":
                    return 1500;

                case "Engine Repair":
                    return 10000;

                case "Brake Service":
                    return 3500;

                case "Battery Check":
                    return 1200;

                case "Car Wash":
                    return 800;

                case "Wheel Alignment":
                    return 2500;

                case "AC Repair":
                    return 4500;

                case "Tire Replacement":
                    return 6000;

                default:
                    return 0;
            }
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Add service first!");
                return;
            }

            isAppointmentBooked = true;

            MessageBox.Show("Appointment booked on: " +
                            dateTimePicker1.Value.ToString());
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            if (!isAppointmentBooked)
            {
                MessageBox.Show("Book appointment first!");
                return;
            }

            Payment p = new Payment(table);
            p.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}