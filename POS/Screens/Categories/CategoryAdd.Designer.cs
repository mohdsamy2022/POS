namespace POS.Screens.Categories
{
    partial class CategoryAdd
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
            this.btn_categoryadd = new System.Windows.Forms.Button();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_categoryname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_categorydelete = new System.Windows.Forms.Button();
            this.btn_categoryedit = new System.Windows.Forms.Button();
            this.btn_categorysearch = new System.Windows.Forms.Button();
            this.txt_categorysearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Image = global::POS.Properties.Resources.Clear_Symbol;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(526, 7);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 38);
            this.btn_clear.TabIndex = 101;
            this.btn_clear.Text = "تراجع";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_categoryadd
            // 
            this.btn_categoryadd.Image = global::POS.Properties.Resources.Save;
            this.btn_categoryadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_categoryadd.Location = new System.Drawing.Point(439, 7);
            this.btn_categoryadd.Name = "btn_categoryadd";
            this.btn_categoryadd.Size = new System.Drawing.Size(81, 38);
            this.btn_categoryadd.TabIndex = 100;
            this.btn_categoryadd.Text = "إضافة";
            this.btn_categoryadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoryadd.UseVisualStyleBackColor = true;
            this.btn_categoryadd.Click += new System.EventHandler(this.btn_categoryadd_Click);
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(352, 125);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(188, 37);
            this.txt_notes.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(562, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 30);
            this.label8.TabIndex = 98;
            this.label8.Text = "ملاحظات";
            // 
            // txt_categoryname
            // 
            this.txt_categoryname.Location = new System.Drawing.Point(352, 82);
            this.txt_categoryname.Name = "txt_categoryname";
            this.txt_categoryname.Size = new System.Drawing.Size(188, 37);
            this.txt_categoryname.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(546, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 93;
            this.label2.Text = "اسم الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(453, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 91;
            this.label1.Text = "الأصناف";
            // 
            // btn_categorydelete
            // 
            this.btn_categorydelete.Image = global::POS.Properties.Resources.Delete;
            this.btn_categorydelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_categorydelete.Location = new System.Drawing.Point(265, 7);
            this.btn_categorydelete.Name = "btn_categorydelete";
            this.btn_categorydelete.Size = new System.Drawing.Size(81, 38);
            this.btn_categorydelete.TabIndex = 90;
            this.btn_categorydelete.Text = "حذف";
            this.btn_categorydelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categorydelete.UseVisualStyleBackColor = true;
            this.btn_categorydelete.Click += new System.EventHandler(this.btn_categorydelete_Click);
            // 
            // btn_categoryedit
            // 
            this.btn_categoryedit.Image = global::POS.Properties.Resources.Edit;
            this.btn_categoryedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_categoryedit.Location = new System.Drawing.Point(352, 7);
            this.btn_categoryedit.Name = "btn_categoryedit";
            this.btn_categoryedit.Size = new System.Drawing.Size(81, 38);
            this.btn_categoryedit.TabIndex = 89;
            this.btn_categoryedit.Text = "تعديل";
            this.btn_categoryedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoryedit.UseVisualStyleBackColor = true;
            this.btn_categoryedit.Click += new System.EventHandler(this.btn_categoryedit_Click);
            // 
            // btn_categorysearch
            // 
            this.btn_categorysearch.Image = global::POS.Properties.Resources.Search;
            this.btn_categorysearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_categorysearch.Location = new System.Drawing.Point(12, 6);
            this.btn_categorysearch.Name = "btn_categorysearch";
            this.btn_categorysearch.Size = new System.Drawing.Size(69, 38);
            this.btn_categorysearch.TabIndex = 88;
            this.btn_categorysearch.Text = "بحث";
            this.btn_categorysearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categorysearch.UseVisualStyleBackColor = true;
            this.btn_categorysearch.Click += new System.EventHandler(this.btn_categorysearch_Click);
            // 
            // txt_categorysearch
            // 
            this.txt_categorysearch.Location = new System.Drawing.Point(87, 7);
            this.txt_categorysearch.Name = "txt_categorysearch";
            this.txt_categorysearch.Size = new System.Drawing.Size(172, 37);
            this.txt_categorysearch.TabIndex = 87;
            this.txt_categorysearch.TextChanged += new System.EventHandler(this.txt_categorysearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 322);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // CategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_categoryadd);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_categoryname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_categorydelete);
            this.Controls.Add(this.btn_categoryedit);
            this.Controls.Add(this.btn_categorysearch);
            this.Controls.Add(this.txt_categorysearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "CategoryAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الأصناف";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryAdd_FormClosing);
            this.Load += new System.EventHandler(this.CategoryAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_categoryadd;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_categoryname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_categorydelete;
        private System.Windows.Forms.Button btn_categoryedit;
        private System.Windows.Forms.Button btn_categorysearch;
        private System.Windows.Forms.TextBox txt_categorysearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}