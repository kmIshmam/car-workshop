namespace Car_Workshop_Management_System
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cardServices = new System.Windows.Forms.Panel();
            this.labelServices = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.cardOrders = new System.Windows.Forms.Panel();
            this.labelOrders = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.cardSales = new System.Windows.Forms.Panel();
            this.labelSales = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.cardUsers = new System.Windows.Forms.Panel();
            this.labelUsers = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.labelReviews = new System.Windows.Forms.Label();
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.cardServices.SuspendLayout();
            this.cardOrders.SuspendLayout();
            this.cardSales.SuspendLayout();
            this.cardUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.labelDate);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.cardServices);
            this.panelMain.Controls.Add(this.cardOrders);
            this.panelMain.Controls.Add(this.cardSales);
            this.panelMain.Controls.Add(this.cardUsers);
            this.panelMain.Controls.Add(this.labelReviews);
            this.panelMain.Controls.Add(this.dataGridViewReviews);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1238, 650);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Plum;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(22, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(855, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "CAR WORKSHOP MANAGEMENT DASHBOARD";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.Honeydew;
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(900, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(304, 50);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "DATE";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Plum;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.btnInventory);
            this.panelMenu.Controls.Add(this.btnCategory);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnRefresh);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Location = new System.Drawing.Point(22, 90);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(247, 530);
            this.panelMenu.TabIndex = 2;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.SeaShell;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnInventory.Location = new System.Drawing.Point(28, 25);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(180, 45);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.SeaShell;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnCategory.Location = new System.Drawing.Point(28, 95);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(180, 45);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "CATEGORIES";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.SeaShell;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrders.Location = new System.Drawing.Point(28, 165);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(180, 45);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "ORDERS";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.SeaShell;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnUsers.Location = new System.Drawing.Point(28, 235);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(180, 45);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "CUSTOMERS";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(28, 305);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 45);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(28, 445);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cardServices
            // 
            this.cardServices.BackColor = System.Drawing.Color.MistyRose;
            this.cardServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardServices.Controls.Add(this.labelServices);
            this.cardServices.Controls.Add(this.lblServices);
            this.cardServices.Location = new System.Drawing.Point(304, 90);
            this.cardServices.Name = "cardServices";
            this.cardServices.Size = new System.Drawing.Size(202, 150);
            this.cardServices.TabIndex = 3;
            // 
            // labelServices
            // 
            this.labelServices.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelServices.Location = new System.Drawing.Point(22, 20);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(146, 30);
            this.labelServices.TabIndex = 0;
            this.labelServices.Text = "SERVICES: ";
            // 
            // lblServices
            // 
            this.lblServices.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblServices.Location = new System.Drawing.Point(22, 70);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(158, 50);
            this.lblServices.TabIndex = 1;
            this.lblServices.Text = "0";
            // 
            // cardOrders
            // 
            this.cardOrders.BackColor = System.Drawing.Color.LemonChiffon;
            this.cardOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardOrders.Controls.Add(this.labelOrders);
            this.cardOrders.Controls.Add(this.lblOrders);
            this.cardOrders.Location = new System.Drawing.Point(540, 90);
            this.cardOrders.Name = "cardOrders";
            this.cardOrders.Size = new System.Drawing.Size(202, 150);
            this.cardOrders.TabIndex = 4;
            // 
            // labelOrders
            // 
            this.labelOrders.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelOrders.Location = new System.Drawing.Point(34, 20);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(135, 30);
            this.labelOrders.TabIndex = 0;
            this.labelOrders.Text = "ORDERS: ";
            // 
            // lblOrders
            // 
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOrders.Location = new System.Drawing.Point(22, 70);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(158, 50);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "0";
            // 
            // cardSales
            // 
            this.cardSales.BackColor = System.Drawing.Color.Honeydew;
            this.cardSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSales.Controls.Add(this.labelSales);
            this.cardSales.Controls.Add(this.lblSales);
            this.cardSales.Location = new System.Drawing.Point(776, 90);
            this.cardSales.Name = "cardSales";
            this.cardSales.Size = new System.Drawing.Size(202, 150);
            this.cardSales.TabIndex = 5;
            // 
            // labelSales
            // 
            this.labelSales.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelSales.Location = new System.Drawing.Point(45, 20);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(112, 30);
            this.labelSales.TabIndex = 0;
            this.labelSales.Text = "SALES: ";
            // 
            // lblSales
            // 
            this.lblSales.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(11, 70);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(180, 71);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "0 BDT";
            // 
            // cardUsers
            // 
            this.cardUsers.BackColor = System.Drawing.Color.Lavender;
            this.cardUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardUsers.Controls.Add(this.labelUsers);
            this.cardUsers.Controls.Add(this.lblUsers);
            this.cardUsers.Location = new System.Drawing.Point(1001, 90);
            this.cardUsers.Name = "cardUsers";
            this.cardUsers.Size = new System.Drawing.Size(202, 150);
            this.cardUsers.TabIndex = 6;
            // 
            // labelUsers
            // 
            this.labelUsers.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsers.Location = new System.Drawing.Point(28, 20);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(135, 30);
            this.labelUsers.TabIndex = 0;
            this.labelUsers.Text = "USERS: ";
            // 
            // lblUsers
            // 
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblUsers.Location = new System.Drawing.Point(22, 70);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(158, 50);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "0";
            // 
            // labelReviews
            // 
            this.labelReviews.BackColor = System.Drawing.Color.Plum;
            this.labelReviews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReviews.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelReviews.Location = new System.Drawing.Point(304, 270);
            this.labelReviews.Name = "labelReviews";
            this.labelReviews.Size = new System.Drawing.Size(900, 40);
            this.labelReviews.TabIndex = 20;
            this.labelReviews.Text = "CUSTOMER REVIEWS";
            this.labelReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewReviews.ColumnHeadersHeight = 34;
            this.dataGridViewReviews.Location = new System.Drawing.Point(304, 325);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.RowHeadersWidth = 62;
            this.dataGridViewReviews.Size = new System.Drawing.Size(900, 295);
            this.dataGridViewReviews.TabIndex = 21;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 650);
            this.Controls.Add(this.panelMain);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Workshop Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.cardServices.ResumeLayout(false);
            this.cardOrders.ResumeLayout(false);
            this.cardSales.ResumeLayout(false);
            this.cardUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;

        private System.Windows.Forms.Panel panelMenu;

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel cardServices;
        private System.Windows.Forms.Panel cardOrders;
        private System.Windows.Forms.Panel cardSales;
        private System.Windows.Forms.Panel cardUsers;

        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblUsers;

        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Label labelUsers;

        private System.Windows.Forms.Label labelReviews;

        private System.Windows.Forms.DataGridView dataGridViewReviews;
    }
}