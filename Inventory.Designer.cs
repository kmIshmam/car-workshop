using System;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    partial class Inventory
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridView1;

        private TextBox txtID;
        private ComboBox comboCategory;
        private TextBox txtService;
        private ComboBox comboVehicle;
        private ComboBox comboFuel;
        private TextBox txtPrice;

        private Label lblTitle;
        private Label lblID;
        private Label lblCategory;
        private Label lblService;
        private Label lblVehicle;
        private Label lblFuel;
        private Label lblPrice;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new DataGridView();

            this.txtID = new TextBox();
            this.comboCategory = new ComboBox();
            this.txtService = new TextBox();
            this.comboVehicle = new ComboBox();
            this.comboFuel = new ComboBox();
            this.txtPrice = new TextBox();

            this.lblTitle = new Label();
            this.lblID = new Label();
            this.lblCategory = new Label();
            this.lblService = new Label();
            this.lblVehicle = new Label();
            this.lblFuel = new Label();
            this.lblPrice = new Label();

            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            this.SuspendLayout();

            // ================= FORM =================

            this.AutoScaleMode = AutoScaleMode.Font;

            this.BackColor = Color.Linen;

            this.ClientSize = new Size(980, 560);

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = "Inventory";

            this.Load += new EventHandler(this.Inventory_Load);

            // ================= TITLE =================

            this.lblTitle.BackColor = Color.BurlyWood;

            this.lblTitle.BorderStyle = BorderStyle.Fixed3D;

            this.lblTitle.Font = new Font(
                "Segoe UI Black",
                16F,
                FontStyle.Bold);

            this.lblTitle.Location = new Point(20, 15);

            this.lblTitle.Size = new Size(940, 45);

            this.lblTitle.Text = "CAR WORKSHOP INVENTORY";

            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ================= LABEL ID =================

            this.lblID.BackColor = Color.Wheat;

            this.lblID.BorderStyle = BorderStyle.FixedSingle;

            this.lblID.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            this.lblID.Location = new Point(20, 80);

            this.lblID.Size = new Size(140, 28);

            this.lblID.Text = "SERVICE ID";

            this.lblID.TextAlign = ContentAlignment.MiddleCenter;

            // ================= LABEL CATEGORY =================

            this.lblCategory.BackColor = Color.Wheat;

            this.lblCategory.BorderStyle = BorderStyle.FixedSingle;

            this.lblCategory.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            this.lblCategory.Location = new Point(175, 80);

            this.lblCategory.Size = new Size(140, 28);

            this.lblCategory.Text = "CATEGORY";

            this.lblCategory.TextAlign = ContentAlignment.MiddleCenter;

            // ================= LABEL SERVICE =================

            this.lblService.BackColor = Color.Wheat;

            this.lblService.BorderStyle = BorderStyle.FixedSingle;

            this.lblService.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            this.lblService.Location = new Point(330, 80);

            this.lblService.Size = new Size(140, 28);

            this.lblService.Text = "SERVICE";

            this.lblService.TextAlign = ContentAlignment.MiddleCenter;

            // ================= LABEL VEHICLE =================

            this.lblVehicle.BackColor = Color.Wheat;

            this.lblVehicle.BorderStyle = BorderStyle.FixedSingle;

            this.lblVehicle.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            this.lblVehicle.Location = new Point(485, 80);

            this.lblVehicle.Size = new Size(140, 28);

            this.lblVehicle.Text = "VEHICLE TYPE";

            this.lblVehicle.TextAlign = ContentAlignment.MiddleCenter;

            // ================= LABEL FUEL =================

            this.lblFuel.BackColor = Color.Wheat;

            this.lblFuel.BorderStyle = BorderStyle.FixedSingle;

            this.lblFuel.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            this.lblFuel.Location = new Point(640, 80);

            this.lblFuel.Size = new Size(140, 28);

            this.lblFuel.Text = "FUEL TYPE";

            this.lblFuel.TextAlign = ContentAlignment.MiddleCenter;

            // ================= LABEL PRICE =================

            this.lblPrice.BackColor = Color.Wheat;

            this.lblPrice.BorderStyle = BorderStyle.FixedSingle;

            this.lblPrice.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            this.lblPrice.Location = new Point(795, 80);

            this.lblPrice.Size = new Size(140, 28);

            this.lblPrice.Text = "PRICE";

            this.lblPrice.TextAlign = ContentAlignment.MiddleCenter;

            // ================= TEXTBOX / COMBO =================

            this.txtID.Location = new Point(20, 115);

            this.txtID.Size = new Size(140, 25);

            this.comboCategory.Location = new Point(175, 115);

            this.comboCategory.Size = new Size(140, 25);

            this.txtService.Location = new Point(330, 115);

            this.txtService.Size = new Size(140, 25);

            this.comboVehicle.Location = new Point(485, 115);

            this.comboVehicle.Size = new Size(140, 25);

            this.comboVehicle.Items.AddRange(new object[]
            {
                "Car",
                "Bike",
                "SUV",
                "Truck"
            });

            this.comboFuel.Location = new Point(640, 115);

            this.comboFuel.Size = new Size(140, 25);

            this.comboFuel.Items.AddRange(new object[]
            {
                "Petrol",
                "Diesel",
                "Hybrid",
                "Electric"
            });

            this.txtPrice.Location = new Point(795, 115);

            this.txtPrice.Size = new Size(140, 25);

            // ================= GRID =================

            this.dataGridView1.Location = new Point(20, 170);

            this.dataGridView1.Size = new Size(940, 280);

            this.dataGridView1.BackgroundColor = Color.WhiteSmoke;

            this.dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView1.CellClick +=
                new DataGridViewCellEventHandler(
                    this.dataGridView1_CellClick);

            // ================= BUTTON ADD =================

            this.btnAdd.BackColor = Color.PaleGreen;

            this.btnAdd.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            this.btnAdd.Location = new Point(220, 480);

            this.btnAdd.Size = new Size(120, 40);

            this.btnAdd.Text = "ADD";

            this.btnAdd.UseVisualStyleBackColor = false;

            this.btnAdd.Click +=
                new EventHandler(this.btnAdd_Click);

            // ================= BUTTON UPDATE =================

            this.btnUpdate.BackColor = Color.Khaki;

            this.btnUpdate.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            this.btnUpdate.Location = new Point(360, 480);

            this.btnUpdate.Size = new Size(120, 40);

            this.btnUpdate.Text = "UPDATE";

            this.btnUpdate.UseVisualStyleBackColor = false;

            this.btnUpdate.Click +=
                new EventHandler(this.btnUpdate_Click);

            // ================= BUTTON DELETE =================

            this.btnDelete.BackColor = Color.LightCoral;

            this.btnDelete.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            this.btnDelete.Location = new Point(500, 480);

            this.btnDelete.Size = new Size(120, 40);

            this.btnDelete.Text = "DELETE";

            this.btnDelete.UseVisualStyleBackColor = false;

            this.btnDelete.Click +=
                new EventHandler(this.btnDelete_Click);

            // ================= BUTTON BACK =================

            this.btnBack.BackColor = Color.Salmon;

            this.btnBack.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            this.btnBack.Location = new Point(640, 480);

            this.btnBack.Size = new Size(120, 40);

            this.btnBack.Text = "BACK";

            this.btnBack.UseVisualStyleBackColor = false;

            this.btnBack.Click +=
                new EventHandler(this.btnBack_Click);

            // ================= CONTROLS =================

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblPrice);

            this.Controls.Add(this.txtID);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.comboVehicle);
            this.Controls.Add(this.comboFuel);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.dataGridView1);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }
    }
}