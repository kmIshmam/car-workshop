using System;
using System.Windows.Forms;

namespace Car_Workshop_Management_System
{
    partial class Users
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ComboBox comboRole;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.comboGender = new System.Windows.Forms.ComboBox();
            this.comboRole = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            this.SuspendLayout();

            // FORM

            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.Users_Load);

            // TITLE

            this.lblTitle.Text = "CAR WORKSHOP USERS MANAGEMENT";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.BackColor = System.Drawing.Color.Peru;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(1150, 50);

            // LABELS

            this.lblID.Text = "ID";
            this.lblID.Location = new System.Drawing.Point(20, 100);

            this.lblUsername.Text = "Username";
            this.lblUsername.Location = new System.Drawing.Point(20, 145);

            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(20, 190);

            this.lblPhone.Text = "Phone";
            this.lblPhone.Location = new System.Drawing.Point(20, 235);

            this.lblAge.Text = "Age";
            this.lblAge.Location = new System.Drawing.Point(20, 280);

            this.lblGender.Text = "Gender";
            this.lblGender.Location = new System.Drawing.Point(20, 325);

            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(20, 370);

            this.lblRole.Text = "Role";
            this.lblRole.Location = new System.Drawing.Point(20, 415);

            // TEXTBOXES

            this.txtID.Location = new System.Drawing.Point(150, 100);
            this.txtID.Size = new System.Drawing.Size(220, 22);
            this.txtID.ReadOnly = true;

            this.txtUsername.Location = new System.Drawing.Point(150, 145);
            this.txtUsername.Size = new System.Drawing.Size(220, 22);

            this.txtEmail.Location = new System.Drawing.Point(150, 190);
            this.txtEmail.Size = new System.Drawing.Size(220, 22);

            this.txtPhone.Location = new System.Drawing.Point(150, 235);
            this.txtPhone.Size = new System.Drawing.Size(220, 22);

            this.txtAge.Location = new System.Drawing.Point(150, 280);
            this.txtAge.Size = new System.Drawing.Size(220, 22);

            this.txtPassword.Location = new System.Drawing.Point(150, 370);
            this.txtPassword.Size = new System.Drawing.Size(220, 22);

            // COMBOBOX

            this.comboGender.Location = new System.Drawing.Point(150, 325);
            this.comboGender.Size = new System.Drawing.Size(220, 24);
            this.comboGender.Items.AddRange(new object[]
            {
                "Male",
                "Female"
            });

            this.comboRole.Location = new System.Drawing.Point(150, 415);
            this.comboRole.Size = new System.Drawing.Size(220, 24);
            this.comboRole.Items.AddRange(new object[]
            {
                "Admin",
                "Staff"
            });

            // BUTTONS

            this.btnAdd.Text = "ADD";
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(20, 500);
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdate.Location = new System.Drawing.Point(140, 500);
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);

            this.btnDelete.Text = "DELETE";
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(260, 500);
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.btnClear.Text = "CLEAR";
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Location = new System.Drawing.Point(20, 560);
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            this.btnBack.Text = "BACK";
            this.btnBack.BackColor = System.Drawing.Color.Bisque;
            this.btnBack.Location = new System.Drawing.Point(140, 560);
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            // GRID

            this.dataGridView1.Location = new System.Drawing.Point(400, 100);
            this.dataGridView1.Size = new System.Drawing.Size(770, 500);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView1.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.DataGridView1_CellClick);

            // CONTROLS

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);

            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPassword);

            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.comboRole);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);

            this.Controls.Add(this.dataGridView1);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}