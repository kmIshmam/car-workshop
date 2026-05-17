namespace Car_Workshop_Management_System
{
    partial class Payment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.buttonApplyDiscount = new System.Windows.Forms.Button();
            this.labelMethod = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.labelDiscount);
            this.panel1.Controls.Add(this.textBoxDiscount);
            this.panel1.Controls.Add(this.buttonApplyDiscount);
            this.panel1.Controls.Add(this.labelMethod);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonPay);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 430);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitle.Font = new System.Drawing.Font("Wide Latin", 11F, System.Drawing.FontStyle.Italic);
            this.labelTitle.Location = new System.Drawing.Point(30, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(690, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "WORKSHOP PAYMENT";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Location = new System.Drawing.Point(30, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.Size = new System.Drawing.Size(690, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.Pink;
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(30, 260);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(690, 35);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "TOTAL BILL : 0 BDT";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscount
            // 
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiscount.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.labelDiscount.Location = new System.Drawing.Point(170, 320);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(160, 25);
            this.labelDiscount.TabIndex = 3;
            this.labelDiscount.Text = "VOUCHER CODE";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(340, 322);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(150, 29);
            this.textBoxDiscount.TabIndex = 4;
            // 
            // buttonApplyDiscount
            // 
            this.buttonApplyDiscount.BackColor = System.Drawing.Color.Wheat;
            this.buttonApplyDiscount.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold);
            this.buttonApplyDiscount.Location = new System.Drawing.Point(510, 319);
            this.buttonApplyDiscount.Name = "buttonApplyDiscount";
            this.buttonApplyDiscount.Size = new System.Drawing.Size(110, 28);
            this.buttonApplyDiscount.TabIndex = 5;
            this.buttonApplyDiscount.Text = "Apply";
            this.buttonApplyDiscount.UseVisualStyleBackColor = false;
            this.buttonApplyDiscount.Click += new System.EventHandler(this.buttonApplyDiscount_Click);
            // 
            // labelMethod
            // 
            this.labelMethod.BackColor = System.Drawing.Color.Transparent;
            this.labelMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMethod.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold);
            this.labelMethod.Location = new System.Drawing.Point(170, 365);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(160, 25);
            this.labelMethod.TabIndex = 6;
            this.labelMethod.Text = "PAYMENT METHOD";
            this.labelMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 367);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 29);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPay.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPay.Location = new System.Drawing.Point(600, 365);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(120, 30);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "PAY NOW";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBack.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(30, 365);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 30);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Button buttonApplyDiscount;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonBack;
    }
}