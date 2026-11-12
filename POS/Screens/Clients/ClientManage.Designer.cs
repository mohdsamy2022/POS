namespace POS.Screens.Clients
{
    partial class ClientManage
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
            this.txt_clientsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_companyname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clientname = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_isactiveclient = new System.Windows.Forms.CheckBox();
            this.txt_clientaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_clientadd = new System.Windows.Forms.Button();
            this.picbox_clientphoto = new System.Windows.Forms.PictureBox();
            this.btn_clientdelete = new System.Windows.Forms.Button();
            this.btn_clientedit = new System.Windows.Forms.Button();
            this.btn_clientsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_clientphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_clientsearch
            // 
            this.txt_clientsearch.Location = new System.Drawing.Point(87, 8);
            this.txt_clientsearch.Name = "txt_clientsearch";
            this.txt_clientsearch.Size = new System.Drawing.Size(172, 37);
            this.txt_clientsearch.TabIndex = 41;
            this.txt_clientsearch.TextChanged += new System.EventHandler(this.txt_clientsearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 322);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(564, 276);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(64, 37);
            this.txt_notes.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(668, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 30);
            this.label7.TabIndex = 56;
            this.label7.Text = "ملاحظات";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(440, 233);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(188, 37);
            this.txt_email.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(626, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 54;
            this.label6.Text = "البريد الإلكتروني";
            // 
            // txt_companyname
            // 
            this.txt_companyname.Location = new System.Drawing.Point(440, 186);
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.Size = new System.Drawing.Size(188, 37);
            this.txt_companyname.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(651, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 52;
            this.label5.Text = "اسم الشركة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(650, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "صورة العميل";
            // 
            // txt_clientname
            // 
            this.txt_clientname.Location = new System.Drawing.Point(440, 51);
            this.txt_clientname.Name = "txt_clientname";
            this.txt_clientname.Size = new System.Drawing.Size(188, 37);
            this.txt_clientname.TabIndex = 49;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.Window;
            this.txt_phone.Location = new System.Drawing.Point(440, 139);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(188, 37);
            this.txt_phone.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(651, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "اسم العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(654, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "رقم الهاتف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(679, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 45;
            this.label1.Text = "العملاء";
            // 
            // checkBox_isactiveclient
            // 
            this.checkBox_isactiveclient.AutoSize = true;
            this.checkBox_isactiveclient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_isactiveclient.Location = new System.Drawing.Point(671, 309);
            this.checkBox_isactiveclient.Name = "checkBox_isactiveclient";
            this.checkBox_isactiveclient.Size = new System.Drawing.Size(70, 34);
            this.checkBox_isactiveclient.TabIndex = 58;
            this.checkBox_isactiveclient.Text = "نشط؟";
            this.checkBox_isactiveclient.UseVisualStyleBackColor = true;
            // 
            // txt_clientaddress
            // 
            this.txt_clientaddress.Location = new System.Drawing.Point(440, 95);
            this.txt_clientaddress.Name = "txt_clientaddress";
            this.txt_clientaddress.Size = new System.Drawing.Size(188, 37);
            this.txt_clientaddress.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(681, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.TabIndex = 59;
            this.label8.Text = "العنوان";
            // 
            // btn_clear
            // 
            this.btn_clear.Image = global::POS.Properties.Resources.Clear_Symbol;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(526, 8);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 38);
            this.btn_clear.TabIndex = 62;
            this.btn_clear.Text = "تراجع";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_clientadd
            // 
            this.btn_clientadd.Image = global::POS.Properties.Resources.Save;
            this.btn_clientadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clientadd.Location = new System.Drawing.Point(439, 8);
            this.btn_clientadd.Name = "btn_clientadd";
            this.btn_clientadd.Size = new System.Drawing.Size(81, 38);
            this.btn_clientadd.TabIndex = 61;
            this.btn_clientadd.Text = "إضافة";
            this.btn_clientadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientadd.UseVisualStyleBackColor = true;
            this.btn_clientadd.Click += new System.EventHandler(this.btn_clientadd_Click);
            // 
            // picbox_clientphoto
            // 
            this.picbox_clientphoto.BackColor = System.Drawing.Color.Honeydew;
            this.picbox_clientphoto.Location = new System.Drawing.Point(443, 276);
            this.picbox_clientphoto.Name = "picbox_clientphoto";
            this.picbox_clientphoto.Size = new System.Drawing.Size(115, 97);
            this.picbox_clientphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_clientphoto.TabIndex = 50;
            this.picbox_clientphoto.TabStop = false;
            this.picbox_clientphoto.Click += new System.EventHandler(this.picbox_clientphoto_Click);
            // 
            // btn_clientdelete
            // 
            this.btn_clientdelete.Image = global::POS.Properties.Resources.Delete;
            this.btn_clientdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clientdelete.Location = new System.Drawing.Point(265, 8);
            this.btn_clientdelete.Name = "btn_clientdelete";
            this.btn_clientdelete.Size = new System.Drawing.Size(81, 38);
            this.btn_clientdelete.TabIndex = 44;
            this.btn_clientdelete.Text = "حذف";
            this.btn_clientdelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientdelete.UseVisualStyleBackColor = true;
            this.btn_clientdelete.Click += new System.EventHandler(this.btn_clientdelete_Click);
            // 
            // btn_clientedit
            // 
            this.btn_clientedit.Image = global::POS.Properties.Resources.Edit;
            this.btn_clientedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clientedit.Location = new System.Drawing.Point(352, 8);
            this.btn_clientedit.Name = "btn_clientedit";
            this.btn_clientedit.Size = new System.Drawing.Size(81, 38);
            this.btn_clientedit.TabIndex = 43;
            this.btn_clientedit.Text = "تعديل";
            this.btn_clientedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientedit.UseVisualStyleBackColor = true;
            this.btn_clientedit.Click += new System.EventHandler(this.btn_clientedit_Click);
            // 
            // btn_clientsearch
            // 
            this.btn_clientsearch.Image = global::POS.Properties.Resources.Search;
            this.btn_clientsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clientsearch.Location = new System.Drawing.Point(12, 7);
            this.btn_clientsearch.Name = "btn_clientsearch";
            this.btn_clientsearch.Size = new System.Drawing.Size(69, 38);
            this.btn_clientsearch.TabIndex = 42;
            this.btn_clientsearch.Text = "بحث";
            this.btn_clientsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientsearch.UseVisualStyleBackColor = true;
            this.btn_clientsearch.Click += new System.EventHandler(this.btn_clientsearch_Click);
            // 
            // ClientManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(753, 382);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_clientadd);
            this.Controls.Add(this.txt_clientaddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_isactiveclient);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_companyname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_clientphoto);
            this.Controls.Add(this.txt_clientname);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clientdelete);
            this.Controls.Add(this.btn_clientedit);
            this.Controls.Add(this.btn_clientsearch);
            this.Controls.Add(this.txt_clientsearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ClientManage";
            this.Text = "قائمة العملاء";
            this.Load += new System.EventHandler(this.ClientManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_clientphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clientdelete;
        private System.Windows.Forms.Button btn_clientedit;
        private System.Windows.Forms.Button btn_clientsearch;
        private System.Windows.Forms.TextBox txt_clientsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_companyname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picbox_clientphoto;
        private System.Windows.Forms.TextBox txt_clientname;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_isactiveclient;
        private System.Windows.Forms.TextBox txt_clientaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_clientadd;
        private System.Windows.Forms.Button btn_clear;
    }
}