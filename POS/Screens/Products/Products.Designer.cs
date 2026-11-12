namespace POS.Screens.Products
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picbox_productphoto = new System.Windows.Forms.PictureBox();
            this.btn_productsave = new System.Windows.Forms.Button();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.btn_listproducts = new System.Windows.Forms.Button();
            this.btn_categoryadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_productphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "إضافة منتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(173, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "صورة المنتج";
            // 
            // picbox_productphoto
            // 
            this.picbox_productphoto.BackColor = System.Drawing.Color.Honeydew;
            this.picbox_productphoto.Location = new System.Drawing.Point(34, 215);
            this.picbox_productphoto.Name = "picbox_productphoto";
            this.picbox_productphoto.Size = new System.Drawing.Size(115, 97);
            this.picbox_productphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_productphoto.TabIndex = 17;
            this.picbox_productphoto.TabStop = false;
            this.picbox_productphoto.Click += new System.EventHandler(this.picbox_productphoto_Click);
            // 
            // btn_productsave
            // 
            this.btn_productsave.Image = global::POS.Properties.Resources.Save;
            this.btn_productsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_productsave.Location = new System.Drawing.Point(294, 287);
            this.btn_productsave.Name = "btn_productsave";
            this.btn_productsave.Size = new System.Drawing.Size(81, 38);
            this.btn_productsave.TabIndex = 16;
            this.btn_productsave.Text = "حفظ";
            this.btn_productsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productsave.UseVisualStyleBackColor = true;
            this.btn_productsave.Click += new System.EventHandler(this.btn_productsave_Click);
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(190, 54);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(292, 37);
            this.txt_productname.TabIndex = 15;
            // 
            // txt_barcode
            // 
            this.txt_barcode.BackColor = System.Drawing.SystemColors.Window;
            this.txt_barcode.Location = new System.Drawing.Point(294, 107);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(188, 37);
            this.txt_barcode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(489, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "اسم المنتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(500, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "الباركود";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(512, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "السعر";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(294, 163);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(188, 37);
            this.txt_price.TabIndex = 20;
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(294, 227);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(188, 37);
            this.txt_notes.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(489, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 21;
            this.label6.Text = "ملاحظات";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(34, 104);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(115, 37);
            this.txt_quantity.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(207, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "الكمية";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(207, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 30);
            this.label8.TabIndex = 25;
            this.label8.Text = "الصنف";
            // 
            // combo_category
            // 
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(34, 163);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(114, 38);
            this.combo_category.TabIndex = 26;
            // 
            // btn_listproducts
            // 
            this.btn_listproducts.Image = global::POS.Properties.Resources.List;
            this.btn_listproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listproducts.Location = new System.Drawing.Point(381, 287);
            this.btn_listproducts.Name = "btn_listproducts";
            this.btn_listproducts.Size = new System.Drawing.Size(181, 38);
            this.btn_listproducts.TabIndex = 27;
            this.btn_listproducts.Text = "عرض جميع المنتجات";
            this.btn_listproducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listproducts.UseVisualStyleBackColor = true;
            this.btn_listproducts.Click += new System.EventHandler(this.btn_listproducts_Click);
            // 
            // btn_categoryadd
            // 
            this.btn_categoryadd.Image = global::POS.Properties.Resources.Edit;
            this.btn_categoryadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_categoryadd.Location = new System.Drawing.Point(168, 287);
            this.btn_categoryadd.Name = "btn_categoryadd";
            this.btn_categoryadd.Size = new System.Drawing.Size(120, 38);
            this.btn_categoryadd.TabIndex = 28;
            this.btn_categoryadd.Text = "إضافة صنف";
            this.btn_categoryadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoryadd.UseVisualStyleBackColor = true;
            this.btn_categoryadd.Click += new System.EventHandler(this.btn_categoryadd_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(590, 334);
            this.Controls.Add(this.btn_categoryadd);
            this.Controls.Add(this.btn_listproducts);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_productphoto);
            this.Controls.Add(this.btn_productsave);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Products";
            this.Text = "إضافة منتج";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_productphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picbox_productphoto;
        private System.Windows.Forms.Button btn_productsave;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_listproducts;
        private System.Windows.Forms.Button btn_categoryadd;
        public System.Windows.Forms.ComboBox combo_category;
    }
}