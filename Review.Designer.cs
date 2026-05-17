namespace Salon_management_system
{
    partial class Review
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER REVIEW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label2
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // comboBox1
            this.comboBox1.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 2;

            // label3
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(70, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comment:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // textBoxComment
            this.textBoxComment.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.textBoxComment.Location = new System.Drawing.Point(220, 145);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(220, 90);
            this.textBoxComment.TabIndex = 4;

            // buttonSubmit
            this.buttonSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.Location = new System.Drawing.Point(120, 270);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(120, 35);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);

            // buttonSkip
            this.buttonSkip.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSkip.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSkip.Location = new System.Drawing.Point(280, 270);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(120, 35);
            this.buttonSkip.TabIndex = 6;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);

            // Review
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(520, 340);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Review";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonSkip;
    }
}