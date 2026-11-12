namespace POS.Screens.SalesBill
{
    partial class SalesBillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_client = new System.Windows.Forms.ComboBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_invoiceadd = new System.Windows.Forms.Button();
            this.btn_invoices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_billno
            // 
            this.txt_billno.Location = new System.Drawing.Point(334, 21);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(200, 37);
            this.txt_billno.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(557, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 77;
            this.label5.Text = "رقم الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(239, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 79;
            this.label1.Text = "العميل";
            // 
            // combo_client
            // 
            this.combo_client.FormattingEnabled = true;
            this.combo_client.Location = new System.Drawing.Point(13, 18);
            this.combo_client.Name = "combo_client";
            this.combo_client.Size = new System.Drawing.Size(188, 38);
            this.combo_client.TabIndex = 81;
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(13, 67);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(188, 37);
            this.txt_notes.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(224, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 82;
            this.label2.Text = "ملاحظات";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 37);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(557, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 30);
            this.label3.TabIndex = 85;
            this.label3.Text = "التاريخ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 200);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(454, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(203, 200);
            this.dataGridView2.TabIndex = 87;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(398, 317);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.ReadOnly = true;
            this.txt_sum.Size = new System.Drawing.Size(90, 37);
            this.txt_sum.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(494, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 88;
            this.label4.Text = "الإجمالي";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(240, 317);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(90, 37);
            this.txt_discount.TabIndex = 91;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(336, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 30);
            this.label6.TabIndex = 90;
            this.label6.Text = "الخصم";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(13, 317);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(90, 37);
            this.txt_total.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(109, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 30);
            this.label7.TabIndex = 92;
            this.label7.Text = "السعر بعد الخصم";
            // 
            // btn_invoiceadd
            // 
            this.btn_invoiceadd.Image = global::POS.Properties.Resources.Save;
            this.btn_invoiceadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_invoiceadd.Location = new System.Drawing.Point(575, 316);
            this.btn_invoiceadd.Name = "btn_invoiceadd";
            this.btn_invoiceadd.Size = new System.Drawing.Size(81, 38);
            this.btn_invoiceadd.TabIndex = 94;
            this.btn_invoiceadd.Text = "حفظ";
            this.btn_invoiceadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_invoiceadd.UseVisualStyleBackColor = true;
            this.btn_invoiceadd.Click += new System.EventHandler(this.btn_invoiceadd_Click);
            // 
            // btn_invoices
            // 
            this.btn_invoices.BackgroundImage = global::POS.Properties.Resources.Invoice_2;
            this.btn_invoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_invoices.Location = new System.Drawing.Point(622, 68);
            this.btn_invoices.Name = "btn_invoices";
            this.btn_invoices.Size = new System.Drawing.Size(34, 37);
            this.btn_invoices.TabIndex = 95;
            this.btn_invoices.UseVisualStyleBackColor = true;
            this.btn_invoices.Click += new System.EventHandler(this.btn_invoices_Click);
            // 
            // SalesBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(668, 375);
            this.Controls.Add(this.btn_invoices);
            this.Controls.Add(this.btn_invoiceadd);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_billno);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "SalesBillForm";
            this.Text = "فاتورة مبيعات";
            this.Load += new System.EventHandler(this.SalesBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_client;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_invoiceadd;
        private System.Windows.Forms.Button btn_invoices;
    }
}