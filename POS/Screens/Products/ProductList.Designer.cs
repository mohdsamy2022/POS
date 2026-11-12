namespace POS.Screens.Products
{
    partial class ProductList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_productsearch = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_productdelete = new System.Windows.Forms.Button();
            this.picbox_productphoto = new System.Windows.Forms.PictureBox();
            this.btn_productedit = new System.Windows.Forms.Button();
            this.btn_productsearch = new System.Windows.Forms.Button();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_productphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt_productsearch
            // 
            this.txt_productsearch.Location = new System.Drawing.Point(87, 6);
            this.txt_productsearch.Name = "txt_productsearch";
            this.txt_productsearch.Size = new System.Drawing.Size(172, 37);
            this.txt_productsearch.TabIndex = 1;
            this.txt_productsearch.TextChanged += new System.EventHandler(this.txt_productsearch_TextChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(560, 270);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(64, 37);
            this.txt_quantity.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(658, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "الكمية";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(436, 227);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(188, 37);
            this.txt_notes.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(642, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "ملاحظات";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(436, 139);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(188, 37);
            this.txt_price.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(665, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "السعر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(624, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "صورة المنتج";
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(436, 49);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(188, 37);
            this.txt_productname.TabIndex = 29;
            // 
            // txt_barcode
            // 
            this.txt_barcode.BackColor = System.Drawing.SystemColors.Window;
            this.txt_barcode.Location = new System.Drawing.Point(436, 94);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(188, 37);
            this.txt_barcode.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(631, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "اسم المنتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(653, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "الباركود";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(545, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "تعديل منتج";
            // 
            // btn_productdelete
            // 
            this.btn_productdelete.Image = global::POS.Properties.Resources.Delete;
            this.btn_productdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_productdelete.Location = new System.Drawing.Point(265, 6);
            this.btn_productdelete.Name = "btn_productdelete";
            this.btn_productdelete.Size = new System.Drawing.Size(81, 38);
            this.btn_productdelete.TabIndex = 39;
            this.btn_productdelete.Text = "حذف";
            this.btn_productdelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productdelete.UseVisualStyleBackColor = true;
            this.btn_productdelete.Click += new System.EventHandler(this.btn_productdelete_Click);
            // 
            // picbox_productphoto
            // 
            this.picbox_productphoto.BackColor = System.Drawing.Color.Honeydew;
            this.picbox_productphoto.Location = new System.Drawing.Point(439, 270);
            this.picbox_productphoto.Name = "picbox_productphoto";
            this.picbox_productphoto.Size = new System.Drawing.Size(115, 97);
            this.picbox_productphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_productphoto.TabIndex = 31;
            this.picbox_productphoto.TabStop = false;
            this.picbox_productphoto.Click += new System.EventHandler(this.picbox_productphoto_Click);
            // 
            // btn_productedit
            // 
            this.btn_productedit.Image = global::POS.Properties.Resources.Edit;
            this.btn_productedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_productedit.Location = new System.Drawing.Point(352, 6);
            this.btn_productedit.Name = "btn_productedit";
            this.btn_productedit.Size = new System.Drawing.Size(81, 38);
            this.btn_productedit.TabIndex = 30;
            this.btn_productedit.Text = "تعديل";
            this.btn_productedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productedit.UseVisualStyleBackColor = true;
            this.btn_productedit.Click += new System.EventHandler(this.btn_productedit_Click);
            // 
            // btn_productsearch
            // 
            this.btn_productsearch.Image = global::POS.Properties.Resources.Search;
            this.btn_productsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_productsearch.Location = new System.Drawing.Point(12, 5);
            this.btn_productsearch.Name = "btn_productsearch";
            this.btn_productsearch.Size = new System.Drawing.Size(69, 38);
            this.btn_productsearch.TabIndex = 17;
            this.btn_productsearch.Text = "بحث";
            this.btn_productsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productsearch.UseVisualStyleBackColor = true;
            this.btn_productsearch.Click += new System.EventHandler(this.btn_productsave_Click);
            // 
            // combo_category
            // 
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(436, 182);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(188, 38);
            this.combo_category.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(658, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "الصنف";
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(727, 370);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.btn_productdelete);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_productphoto);
            this.Controls.Add(this.btn_productedit);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_productsearch);
            this.Controls.Add(this.txt_productsearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض المنتجات";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_productphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_productsearch;
        private System.Windows.Forms.Button btn_productsearch;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picbox_productphoto;
        private System.Windows.Forms.Button btn_productedit;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_productdelete;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.Label label8;
    }
}