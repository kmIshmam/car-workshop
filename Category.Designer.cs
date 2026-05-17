namespace Car_Workshop_Management_System
{
    partial class Category
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCategoryName;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.Label labelName;

        private System.Windows.Forms.Panel panelButtons;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnClear;

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
            this.txtCategoryName =
                new System.Windows.Forms.TextBox();

            this.dataGridView1 =
                new System.Windows.Forms.DataGridView();

            this.btnBack =
                new System.Windows.Forms.Button();

            this.labelTitle =
                new System.Windows.Forms.Label();

            this.labelName =
                new System.Windows.Forms.Label();

            this.panelButtons =
                new System.Windows.Forms.Panel();

            this.btnAdd =
                new System.Windows.Forms.Button();

            this.btnUpdate =
                new System.Windows.Forms.Button();

            this.btnDelete =
                new System.Windows.Forms.Button();

            this.btnClear =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            this.panelButtons.SuspendLayout();

            this.SuspendLayout();

            // ================= FORM =================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.Linen;

            this.ClientSize =
                new System.Drawing.Size(700, 450);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Category Management";

            this.Load +=
                new System.EventHandler(this.Category_Load);

            // ================= TITLE =================

            this.labelTitle.BackColor =
                System.Drawing.Color.BurlyWood;

            this.labelTitle.BorderStyle =
                System.Windows.Forms.BorderStyle.Fixed3D;

            this.labelTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI Black",
                    16F,
                    System.Drawing.FontStyle.Bold);

            this.labelTitle.Location =
                new System.Drawing.Point(20, 15);

            this.labelTitle.Name =
                "labelTitle";

            this.labelTitle.Size =
                new System.Drawing.Size(650, 45);

            this.labelTitle.Text =
                "CATEGORY MANAGEMENT";

            this.labelTitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ================= LABEL =================

            this.labelName.AutoSize =
                true;

            this.labelName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.labelName.Location =
                new System.Drawing.Point(70, 95);

            this.labelName.Name =
                "labelName";

            this.labelName.Size =
                new System.Drawing.Size(132, 19);

            this.labelName.Text =
                "Category Name";

            // ================= TEXTBOX =================

            this.txtCategoryName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtCategoryName.Location =
                new System.Drawing.Point(220, 92);

            this.txtCategoryName.Name =
                "txtCategoryName";

            this.txtCategoryName.Size =
                new System.Drawing.Size(250, 25);

            // ================= BUTTON PANEL =================

            this.panelButtons.BackColor =
                System.Drawing.Color.RosyBrown;

            this.panelButtons.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.panelButtons.Location =
                new System.Drawing.Point(70, 140);

            this.panelButtons.Name =
                "panelButtons";

            this.panelButtons.Size =
                new System.Drawing.Size(560, 60);

            // ================= ADD BUTTON =================

            this.btnAdd.BackColor =
                System.Drawing.Color.Honeydew;

            this.btnAdd.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnAdd.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnAdd.Location =
                new System.Drawing.Point(15, 15);

            this.btnAdd.Name =
                "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(110, 30);

            this.btnAdd.Text =
                "ADD";

            this.btnAdd.UseVisualStyleBackColor =
                false;

            this.btnAdd.Click +=
                new System.EventHandler(this.btnAdd_Click);

            // ================= UPDATE BUTTON =================

            this.btnUpdate.BackColor =
                System.Drawing.Color.Khaki;

            this.btnUpdate.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnUpdate.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnUpdate.Location =
                new System.Drawing.Point(150, 15);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(110, 30);

            this.btnUpdate.Text =
                "UPDATE";

            this.btnUpdate.UseVisualStyleBackColor =
                false;

            this.btnUpdate.Click +=
                new System.EventHandler(this.btnUpdate_Click);

            // ================= DELETE BUTTON =================

            this.btnDelete.BackColor =
                System.Drawing.Color.LightCoral;

            this.btnDelete.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnDelete.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnDelete.Location =
                new System.Drawing.Point(285, 15);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(110, 30);

            this.btnDelete.Text =
                "DELETE";

            this.btnDelete.UseVisualStyleBackColor =
                false;

            this.btnDelete.Click +=
                new System.EventHandler(this.btnDelete_Click);

            // ================= CLEAR BUTTON =================

            this.btnClear.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.btnClear.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnClear.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnClear.Location =
                new System.Drawing.Point(420, 15);

            this.btnClear.Name =
                "btnClear";

            this.btnClear.Size =
                new System.Drawing.Size(110, 30);

            this.btnClear.Text =
                "CLEAR";

            this.btnClear.UseVisualStyleBackColor =
                false;

            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            // ================= DATAGRIDVIEW =================

            this.dataGridView1.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView1.BackgroundColor =
                System.Drawing.Color.WhiteSmoke;

            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView1.Location =
                new System.Drawing.Point(70, 225);

            this.dataGridView1.Name =
                "dataGridView1";

            this.dataGridView1.RowHeadersWidth =
                51;

            this.dataGridView1.RowTemplate.Height =
                24;

            this.dataGridView1.Size =
                new System.Drawing.Size(560, 160);

            this.dataGridView1.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dataGridView1_CellClick);

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
                new System.Drawing.Point(20, 400);

            this.btnBack.Name =
                "btnBack";

            this.btnBack.Size =
                new System.Drawing.Size(90, 32);

            this.btnBack.Text =
                "BACK";

            this.btnBack.UseVisualStyleBackColor =
                false;

            this.btnBack.Click +=
                new System.EventHandler(this.btnBack_Click);

            // ================= PANEL CONTROLS =================

            this.panelButtons.Controls.Add(this.btnAdd);

            this.panelButtons.Controls.Add(this.btnUpdate);

            this.panelButtons.Controls.Add(this.btnDelete);

            this.panelButtons.Controls.Add(this.btnClear);

            // ================= FORM CONTROLS =================

            this.Controls.Add(this.labelTitle);

            this.Controls.Add(this.labelName);

            this.Controls.Add(this.txtCategoryName);

            this.Controls.Add(this.panelButtons);

            this.Controls.Add(this.dataGridView1);

            this.Controls.Add(this.btnBack);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.panelButtons.ResumeLayout(false);

            this.ResumeLayout(false);

            this.PerformLayout();
        }
    }
}