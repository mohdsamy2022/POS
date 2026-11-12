namespace POS.Screens.Suppliers
{
    partial class SuppliersManage
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_supplieradd = new System.Windows.Forms.Button();
            this.txt_supplieraddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_isactivesupplier = new System.Windows.Forms.CheckBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_companyname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picbox_supplierphoto = new System.Windows.Forms.PictureBox();
            this.txt_suppliername = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_supplierdelete = new System.Windows.Forms.Button();
            this.btn_supplieredit = new System.Windows.Forms.Button();
            this.btn_suppliersearch = new System.Windows.Forms.Button();
            this.txt_suppliersearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_supplierphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Image = global::POS.Properties.Resources.Clear_Symbol;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(526, 8);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 38);
            this.btn_clear.TabIndex = 85;
            this.btn_clear.Text = "تراجع";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_supplieradd
            // 
            this.btn_supplieradd.Image = global::POS.Properties.Resources.Save;
            this.btn_supplieradd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_supplieradd.Location = new System.Drawing.Point(439, 8);
            this.btn_supplieradd.Name = "btn_supplieradd";
            this.btn_supplieradd.Size = new System.Drawing.Size(81, 38);
            this.btn_supplieradd.TabIndex = 84;
            this.btn_supplieradd.Text = "إضافة";
            this.btn_supplieradd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supplieradd.UseVisualStyleBackColor = true;
            this.btn_supplieradd.Click += new System.EventHandler(this.btn_supplieradd_Click);
            // 
            // txt_supplieraddress
            // 
            this.txt_supplieraddress.Location = new System.Drawing.Point(440, 95);
            this.txt_supplieraddress.Name = "txt_supplieraddress";
            this.txt_supplieraddress.Size = new System.Drawing.Size(188, 37);
            this.txt_supplieraddress.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(681, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.TabIndex = 82;
            this.label8.Text = "العنوان";
            // 
            // checkBox_isactivesupplier
            // 
            this.checkBox_isactivesupplier.AutoSize = true;
            this.checkBox_isactivesupplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_isactivesupplier.Location = new System.Drawing.Point(671, 309);
            this.checkBox_isactivesupplier.Name = "checkBox_isactivesupplier";
            this.checkBox_isactivesupplier.Size = new System.Drawing.Size(70, 34);
            this.checkBox_isactivesupplier.TabIndex = 81;
            this.checkBox_isactivesupplier.Text = "نشط؟";
            this.checkBox_isactivesupplier.UseVisualStyleBackColor = true;
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(564, 276);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(64, 37);
            this.txt_notes.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(668, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 30);
            this.label7.TabIndex = 79;
            this.label7.Text = "ملاحظات";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(440, 233);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(188, 37);
            this.txt_email.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(626, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 77;
            this.label6.Text = "البريد الإلكتروني";
            // 
            // txt_companyname
            // 
            this.txt_companyname.Location = new System.Drawing.Point(440, 186);
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.Size = new System.Drawing.Size(188, 37);
            this.txt_companyname.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(651, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 75;
            this.label5.Text = "اسم الشركة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(650, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 74;
            this.label3.Text = "صورة العميل";
            // 
            // picbox_supplierphoto
            // 
            this.picbox_supplierphoto.BackColor = System.Drawing.Color.Honeydew;
            this.picbox_supplierphoto.Location = new System.Drawing.Point(443, 276);
            this.picbox_supplierphoto.Name = "picbox_supplierphoto";
            this.picbox_supplierphoto.Size = new System.Drawing.Size(115, 97);
            this.picbox_supplierphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_supplierphoto.TabIndex = 73;
            this.picbox_supplierphoto.TabStop = false;
            this.picbox_supplierphoto.Click += new System.EventHandler(this.picbox_supplierphoto_Click);
            // 
            // txt_suppliername
            // 
            this.txt_suppliername.Location = new System.Drawing.Point(440, 51);
            this.txt_suppliername.Name = "txt_suppliername";
            this.txt_suppliername.Size = new System.Drawing.Size(188, 37);
            this.txt_suppliername.TabIndex = 72;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.Window;
            this.txt_phone.Location = new System.Drawing.Point(440, 139);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(188, 37);
            this.txt_phone.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(656, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 70;
            this.label2.Text = "اسم المورد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(654, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 69;
            this.label4.Text = "رقم الهاتف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(666, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 68;
            this.label1.Text = "الموردون";
            // 
            // btn_supplierdelete
            // 
            this.btn_supplierdelete.Image = global::POS.Properties.Resources.Delete;
            this.btn_supplierdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_supplierdelete.Location = new System.Drawing.Point(265, 8);
            this.btn_supplierdelete.Name = "btn_supplierdelete";
            this.btn_supplierdelete.Size = new System.Drawing.Size(81, 38);
            this.btn_supplierdelete.TabIndex = 67;
            this.btn_supplierdelete.Text = "حذف";
            this.btn_supplierdelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supplierdelete.UseVisualStyleBackColor = true;
            this.btn_supplierdelete.Click += new System.EventHandler(this.btn_supplierdelete_Click);
            // 
            // btn_supplieredit
            // 
            this.btn_supplieredit.Image = global::POS.Properties.Resources.Edit;
            this.btn_supplieredit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_supplieredit.Location = new System.Drawing.Point(352, 8);
            this.btn_supplieredit.Name = "btn_supplieredit";
            this.btn_supplieredit.Size = new System.Drawing.Size(81, 38);
            this.btn_supplieredit.TabIndex = 66;
            this.btn_supplieredit.Text = "تعديل";
            this.btn_supplieredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supplieredit.UseVisualStyleBackColor = true;
            this.btn_supplieredit.Click += new System.EventHandler(this.btn_supplieredit_Click);
            // 
            // btn_suppliersearch
            // 
            this.btn_suppliersearch.Image = global::POS.Properties.Resources.Search;
            this.btn_suppliersearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suppliersearch.Location = new System.Drawing.Point(12, 7);
            this.btn_suppliersearch.Name = "btn_suppliersearch";
            this.btn_suppliersearch.Size = new System.Drawing.Size(69, 38);
            this.btn_suppliersearch.TabIndex = 65;
            this.btn_suppliersearch.Text = "بحث";
            this.btn_suppliersearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suppliersearch.UseVisualStyleBackColor = true;
            this.btn_suppliersearch.Click += new System.EventHandler(this.btn_suppliersearch_Click);
            // 
            // txt_suppliersearch
            // 
            this.txt_suppliersearch.Location = new System.Drawing.Point(87, 8);
            this.txt_suppliersearch.Name = "txt_suppliersearch";
            this.txt_suppliersearch.Size = new System.Drawing.Size(172, 37);
            this.txt_suppliersearch.TabIndex = 64;
            this.txt_suppliersearch.TextChanged += new System.EventHandler(this.txt_suppliersearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 322);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // SuppliersManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(747, 380);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_supplieradd);
            this.Controls.Add(this.txt_supplieraddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_isactivesupplier);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_companyname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_supplierphoto);
            this.Controls.Add(this.txt_suppliername);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_supplierdelete);
            this.Controls.Add(this.btn_supplieredit);
            this.Controls.Add(this.btn_suppliersearch);
            this.Controls.Add(this.txt_suppliersearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "SuppliersManage";
            this.Text = "قائمة الموردين";
            this.Load += new System.EventHandler(this.SuppliersManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_supplierphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_supplieradd;
        private System.Windows.Forms.TextBox txt_supplieraddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_isactivesupplier;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_companyname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picbox_supplierphoto;
        private System.Windows.Forms.TextBox txt_suppliername;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_supplierdelete;
        private System.Windows.Forms.Button btn_supplieredit;
        private System.Windows.Forms.Button btn_suppliersearch;
        private System.Windows.Forms.TextBox txt_suppliersearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}