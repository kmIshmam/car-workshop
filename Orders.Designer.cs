namespace Car_Workshop_Management_System
{
    partial class Orders
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewOrders;

        private System.Windows.Forms.DataGridView dataGridViewDetails;

        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblOrders;

        private System.Windows.Forms.Label lblDetails;

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
            this.dataGridViewOrders =
                new System.Windows.Forms.DataGridView();

            this.dataGridViewDetails =
                new System.Windows.Forms.DataGridView();

            this.btnBack =
                new System.Windows.Forms.Button();

            this.lblTitle =
                new System.Windows.Forms.Label();

            this.lblOrders =
                new System.Windows.Forms.Label();

            this.lblDetails =
                new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();

            this.SuspendLayout();

            // ================= FORM =================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.Linen;

            this.ClientSize =
                new System.Drawing.Size(900, 560);

            this.Name =
                "Orders";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Orders Management";

            this.Load +=
                new System.EventHandler(this.Orders_Load);

            // ================= TITLE =================

            this.lblTitle.BackColor =
                System.Drawing.Color.BurlyWood;

            this.lblTitle.BorderStyle =
                System.Windows.Forms.BorderStyle.Fixed3D;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI Black",
                    16F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(20, 15);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(850, 45);

            this.lblTitle.Text =
                "CUSTOMER ORDERS";

            this.lblTitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ================= ORDERS LABEL =================

            this.lblOrders.BackColor =
                System.Drawing.Color.Wheat;

            this.lblOrders.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblOrders.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblOrders.Location =
                new System.Drawing.Point(20, 80);

            this.lblOrders.Name =
                "lblOrders";

            this.lblOrders.Size =
                new System.Drawing.Size(850, 30);

            this.lblOrders.Text =
                "ORDER HISTORY";

            this.lblOrders.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ================= ORDERS GRID =================

            this.dataGridViewOrders.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewOrders.BackgroundColor =
                System.Drawing.Color.WhiteSmoke;

            this.dataGridViewOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridViewOrders.Location =
                new System.Drawing.Point(20, 120);

            this.dataGridViewOrders.Name =
                "dataGridViewOrders";

            this.dataGridViewOrders.RowHeadersWidth =
                51;

            this.dataGridViewOrders.RowTemplate.Height =
                24;

            this.dataGridViewOrders.Size =
                new System.Drawing.Size(850, 170);

            this.dataGridViewOrders.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dataGridViewOrders_CellClick);

            // ================= DETAILS LABEL =================

            this.lblDetails.BackColor =
                System.Drawing.Color.Wheat;

            this.lblDetails.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblDetails.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblDetails.Location =
                new System.Drawing.Point(20, 315);

            this.lblDetails.Name =
                "lblDetails";

            this.lblDetails.Size =
                new System.Drawing.Size(850, 30);

            this.lblDetails.Text =
                "ORDER DETAILS";

            this.lblDetails.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ================= DETAILS GRID =================

            this.dataGridViewDetails.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewDetails.BackgroundColor =
                System.Drawing.Color.WhiteSmoke;

            this.dataGridViewDetails.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridViewDetails.Location =
                new System.Drawing.Point(20, 355);

            this.dataGridViewDetails.Name =
                "dataGridViewDetails";

            this.dataGridViewDetails.RowHeadersWidth =
                51;

            this.dataGridViewDetails.RowTemplate.Height =
                24;

            this.dataGridViewDetails.Size =
                new System.Drawing.Size(850, 140);

            // ================= BACK BUTTON =================

            this.btnBack.BackColor =
                System.Drawing.Color.Salmon;

            this.btnBack.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnBack.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnBack.Location =
                new System.Drawing.Point(20, 510);

            this.btnBack.Name =
                "btnBack";

            this.btnBack.Size =
                new System.Drawing.Size(100, 35);

            this.btnBack.Text =
                "BACK";

            this.btnBack.UseVisualStyleBackColor =
                false;

            this.btnBack.Click +=
                new System.EventHandler(this.btnBack_Click);

            // ================= ADD CONTROLS =================

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblOrders);

            this.Controls.Add(this.dataGridViewOrders);

            this.Controls.Add(this.lblDetails);

            this.Controls.Add(this.dataGridViewDetails);

            this.Controls.Add(this.btnBack);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();

            this.ResumeLayout(false);
        }
    }
}