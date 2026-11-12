namespace POS
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أضافةمستخدمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.العملاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التحكمفيالمنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالمنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.العملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةعميلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التحكمفيالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أضافةموردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التحكمفيالموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فاتورةمشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فاتورةمبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigbtn_report = new System.Windows.Forms.Button();
            this.bigbtn_saleinvoice = new System.Windows.Forms.Button();
            this.bigbtn_purchaseinvoice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bigbtn_clients = new System.Windows.Forms.Button();
            this.bigbtn_products = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.المستخدمينToolStripMenuItem,
            this.العملاToolStripMenuItem,
            this.العملاءToolStripMenuItem,
            this.الموردينToolStripMenuItem,
            this.الفاتورةToolStripMenuItem,
            this.تقاريرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إغلاقToolStripMenuItem});
            this.ملفToolStripMenuItem.Image = global::POS.Properties.Resources.File_2;
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // إغلاقToolStripMenuItem
            // 
            this.إغلاقToolStripMenuItem.Image = global::POS.Properties.Resources.Close_1;
            this.إغلاقToolStripMenuItem.Name = "إغلاقToolStripMenuItem";
            this.إغلاقToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.إغلاقToolStripMenuItem.Text = "إغلاق";
            this.إغلاقToolStripMenuItem.Click += new System.EventHandler(this.إغلاقToolStripMenuItem_Click);
            // 
            // المستخدمينToolStripMenuItem
            // 
            this.المستخدمينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.أضافةمستخدمToolStripMenuItem});
            this.المستخدمينToolStripMenuItem.Image = global::POS.Properties.Resources.Users;
            this.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem";
            this.المستخدمينToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.المستخدمينToolStripMenuItem.Text = "المستخدمين";
            // 
            // أضافةمستخدمToolStripMenuItem
            // 
            this.أضافةمستخدمToolStripMenuItem.Image = global::POS.Properties.Resources.User_2;
            this.أضافةمستخدمToolStripMenuItem.Name = "أضافةمستخدمToolStripMenuItem";
            this.أضافةمستخدمToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.أضافةمستخدمToolStripMenuItem.Text = "أضافة مستخدم";
            this.أضافةمستخدمToolStripMenuItem.Click += new System.EventHandler(this.أضافةمستخدمToolStripMenuItem_Click);
            // 
            // العملاToolStripMenuItem
            // 
            this.العملاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةمنتجToolStripMenuItem,
            this.التحكمفيالمنتجاتToolStripMenuItem,
            this.عرضالمنتجاتToolStripMenuItem});
            this.العملاToolStripMenuItem.Image = global::POS.Properties.Resources.Shopping_Cart_2;
            this.العملاToolStripMenuItem.Name = "العملاToolStripMenuItem";
            this.العملاToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.العملاToolStripMenuItem.Text = "المنتجات";
            // 
            // إضافةمنتجToolStripMenuItem
            // 
            this.إضافةمنتجToolStripMenuItem.Image = global::POS.Properties.Resources.Product;
            this.إضافةمنتجToolStripMenuItem.Name = "إضافةمنتجToolStripMenuItem";
            this.إضافةمنتجToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.إضافةمنتجToolStripMenuItem.Text = "إضافة منتج";
            this.إضافةمنتجToolStripMenuItem.Click += new System.EventHandler(this.إضافةمنتجToolStripMenuItem_Click);
            // 
            // التحكمفيالمنتجاتToolStripMenuItem
            // 
            this.التحكمفيالمنتجاتToolStripMenuItem.Image = global::POS.Properties.Resources.Control;
            this.التحكمفيالمنتجاتToolStripMenuItem.Name = "التحكمفيالمنتجاتToolStripMenuItem";
            this.التحكمفيالمنتجاتToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.التحكمفيالمنتجاتToolStripMenuItem.Text = "التحكم في المنتجات";
            // 
            // عرضالمنتجاتToolStripMenuItem
            // 
            this.عرضالمنتجاتToolStripMenuItem.Image = global::POS.Properties.Resources.List;
            this.عرضالمنتجاتToolStripMenuItem.Name = "عرضالمنتجاتToolStripMenuItem";
            this.عرضالمنتجاتToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.عرضالمنتجاتToolStripMenuItem.Text = "عرض المنتجات";
            this.عرضالمنتجاتToolStripMenuItem.Click += new System.EventHandler(this.عرضالمنتجاتToolStripMenuItem_Click);
            // 
            // العملاءToolStripMenuItem
            // 
            this.العملاءToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةعميلToolStripMenuItem,
            this.التحكمفيالعملاءToolStripMenuItem,
            this.عرضالعملاءToolStripMenuItem});
            this.العملاءToolStripMenuItem.Image = global::POS.Properties.Resources.Group_2;
            this.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            this.العملاءToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.العملاءToolStripMenuItem.Text = "العملاء";
            // 
            // إضافةعميلToolStripMenuItem
            // 
            this.إضافةعميلToolStripMenuItem.Image = global::POS.Properties.Resources.Client_Management_2;
            this.إضافةعميلToolStripMenuItem.Name = "إضافةعميلToolStripMenuItem";
            this.إضافةعميلToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.إضافةعميلToolStripMenuItem.Text = "إضافة عميل";
            this.إضافةعميلToolStripMenuItem.Click += new System.EventHandler(this.إضافةعميلToolStripMenuItem_Click);
            // 
            // التحكمفيالعملاءToolStripMenuItem
            // 
            this.التحكمفيالعملاءToolStripMenuItem.Image = global::POS.Properties.Resources.Control;
            this.التحكمفيالعملاءToolStripMenuItem.Name = "التحكمفيالعملاءToolStripMenuItem";
            this.التحكمفيالعملاءToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.التحكمفيالعملاءToolStripMenuItem.Text = "التحكم في العملاء";
            // 
            // عرضالعملاءToolStripMenuItem
            // 
            this.عرضالعملاءToolStripMenuItem.Image = global::POS.Properties.Resources.List;
            this.عرضالعملاءToolStripMenuItem.Name = "عرضالعملاءToolStripMenuItem";
            this.عرضالعملاءToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.عرضالعملاءToolStripMenuItem.Text = "عرض العملاء";
            // 
            // الموردينToolStripMenuItem
            // 
            this.الموردينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.أضافةموردToolStripMenuItem,
            this.التحكمفيالموردينToolStripMenuItem,
            this.عرضالموردينToolStripMenuItem});
            this.الموردينToolStripMenuItem.Image = global::POS.Properties.Resources.Supplier_2;
            this.الموردينToolStripMenuItem.Name = "الموردينToolStripMenuItem";
            this.الموردينToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.الموردينToolStripMenuItem.Text = "الموردين";
            // 
            // أضافةموردToolStripMenuItem
            // 
            this.أضافةموردToolStripMenuItem.Image = global::POS.Properties.Resources.Supplier_3;
            this.أضافةموردToolStripMenuItem.Name = "أضافةموردToolStripMenuItem";
            this.أضافةموردToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.أضافةموردToolStripMenuItem.Text = "أضافة مورد";
            // 
            // التحكمفيالموردينToolStripMenuItem
            // 
            this.التحكمفيالموردينToolStripMenuItem.Image = global::POS.Properties.Resources.Control;
            this.التحكمفيالموردينToolStripMenuItem.Name = "التحكمفيالموردينToolStripMenuItem";
            this.التحكمفيالموردينToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.التحكمفيالموردينToolStripMenuItem.Text = "التحكم في الموردين";
            // 
            // عرضالموردينToolStripMenuItem
            // 
            this.عرضالموردينToolStripMenuItem.Image = global::POS.Properties.Resources.List;
            this.عرضالموردينToolStripMenuItem.Name = "عرضالموردينToolStripMenuItem";
            this.عرضالموردينToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.عرضالموردينToolStripMenuItem.Text = "عرض الموردين";
            this.عرضالموردينToolStripMenuItem.Click += new System.EventHandler(this.عرضالموردينToolStripMenuItem_Click);
            // 
            // الفاتورةToolStripMenuItem
            // 
            this.الفاتورةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فاتورةمشترياتToolStripMenuItem,
            this.فاتورةمبيعاتToolStripMenuItem});
            this.الفاتورةToolStripMenuItem.Image = global::POS.Properties.Resources.Invoice_2;
            this.الفاتورةToolStripMenuItem.Name = "الفاتورةToolStripMenuItem";
            this.الفاتورةToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.الفاتورةToolStripMenuItem.Text = "الفاتورة";
            // 
            // فاتورةمشترياتToolStripMenuItem
            // 
            this.فاتورةمشترياتToolStripMenuItem.Image = global::POS.Properties.Resources.Invoice_3;
            this.فاتورةمشترياتToolStripMenuItem.Name = "فاتورةمشترياتToolStripMenuItem";
            this.فاتورةمشترياتToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.فاتورةمشترياتToolStripMenuItem.Text = "فاتورة مشتريات";
            // 
            // فاتورةمبيعاتToolStripMenuItem
            // 
            this.فاتورةمبيعاتToolStripMenuItem.Image = global::POS.Properties.Resources.Invoice_4;
            this.فاتورةمبيعاتToolStripMenuItem.Name = "فاتورةمبيعاتToolStripMenuItem";
            this.فاتورةمبيعاتToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.فاتورةمبيعاتToolStripMenuItem.Text = "فاتورة مبيعات";
            // 
            // تقاريرToolStripMenuItem
            // 
            this.تقاريرToolStripMenuItem.Image = global::POS.Properties.Resources.Graph_Report_1;
            this.تقاريرToolStripMenuItem.Name = "تقاريرToolStripMenuItem";
            this.تقاريرToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.تقاريرToolStripMenuItem.Text = "تقارير";
            // 
            // bigbtn_report
            // 
            this.bigbtn_report.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bigbtn_report.BackgroundImage = global::POS.Properties.Resources.delivery_report;
            this.bigbtn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigbtn_report.FlatAppearance.BorderSize = 0;
            this.bigbtn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigbtn_report.ForeColor = System.Drawing.SystemColors.Info;
            this.bigbtn_report.Location = new System.Drawing.Point(43, 180);
            this.bigbtn_report.Name = "bigbtn_report";
            this.bigbtn_report.Size = new System.Drawing.Size(132, 86);
            this.bigbtn_report.TabIndex = 6;
            this.bigbtn_report.Text = "تقارير";
            this.bigbtn_report.UseVisualStyleBackColor = false;
            // 
            // bigbtn_saleinvoice
            // 
            this.bigbtn_saleinvoice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bigbtn_saleinvoice.BackgroundImage = global::POS.Properties.Resources.receipt;
            this.bigbtn_saleinvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigbtn_saleinvoice.FlatAppearance.BorderSize = 0;
            this.bigbtn_saleinvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigbtn_saleinvoice.ForeColor = System.Drawing.SystemColors.Info;
            this.bigbtn_saleinvoice.Location = new System.Drawing.Point(229, 180);
            this.bigbtn_saleinvoice.Name = "bigbtn_saleinvoice";
            this.bigbtn_saleinvoice.Size = new System.Drawing.Size(132, 86);
            this.bigbtn_saleinvoice.TabIndex = 5;
            this.bigbtn_saleinvoice.Text = "فواتير مبيعات";
            this.bigbtn_saleinvoice.UseVisualStyleBackColor = false;
            this.bigbtn_saleinvoice.Click += new System.EventHandler(this.bigbtn_saleinvoice_Click);
            // 
            // bigbtn_purchaseinvoice
            // 
            this.bigbtn_purchaseinvoice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bigbtn_purchaseinvoice.BackgroundImage = global::POS.Properties.Resources.Invoice_5;
            this.bigbtn_purchaseinvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigbtn_purchaseinvoice.FlatAppearance.BorderSize = 0;
            this.bigbtn_purchaseinvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigbtn_purchaseinvoice.ForeColor = System.Drawing.SystemColors.Info;
            this.bigbtn_purchaseinvoice.Location = new System.Drawing.Point(412, 180);
            this.bigbtn_purchaseinvoice.Name = "bigbtn_purchaseinvoice";
            this.bigbtn_purchaseinvoice.Size = new System.Drawing.Size(132, 86);
            this.bigbtn_purchaseinvoice.TabIndex = 4;
            this.bigbtn_purchaseinvoice.Text = "فواتير مشتريات";
            this.bigbtn_purchaseinvoice.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.BackgroundImage = global::POS.Properties.Resources.supplier_4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(43, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "الموردين";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bigbtn_clients
            // 
            this.bigbtn_clients.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bigbtn_clients.BackgroundImage = global::POS.Properties.Resources.Woman_walking_with_a_shopping_cart;
            this.bigbtn_clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigbtn_clients.FlatAppearance.BorderSize = 0;
            this.bigbtn_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigbtn_clients.ForeColor = System.Drawing.SystemColors.Info;
            this.bigbtn_clients.Location = new System.Drawing.Point(229, 58);
            this.bigbtn_clients.Name = "bigbtn_clients";
            this.bigbtn_clients.Size = new System.Drawing.Size(132, 86);
            this.bigbtn_clients.TabIndex = 2;
            this.bigbtn_clients.Text = "العملاء";
            this.bigbtn_clients.UseVisualStyleBackColor = false;
            this.bigbtn_clients.Click += new System.EventHandler(this.bigbtn_clients_Click);
            // 
            // bigbtn_products
            // 
            this.bigbtn_products.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bigbtn_products.BackgroundImage = global::POS.Properties.Resources.package_with_products;
            this.bigbtn_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigbtn_products.FlatAppearance.BorderSize = 0;
            this.bigbtn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigbtn_products.Location = new System.Drawing.Point(412, 58);
            this.bigbtn_products.Name = "bigbtn_products";
            this.bigbtn_products.Size = new System.Drawing.Size(132, 86);
            this.bigbtn_products.TabIndex = 1;
            this.bigbtn_products.Text = "المنتجات";
            this.bigbtn_products.UseVisualStyleBackColor = false;
            this.bigbtn_products.Click += new System.EventHandler(this.bigbtn_products_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_user.Location = new System.Drawing.Point(13, 28);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(44, 24);
            this.lbl_user.TabIndex = 7;
            this.lbl_user.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(594, 305);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.bigbtn_report);
            this.Controls.Add(this.bigbtn_saleinvoice);
            this.Controls.Add(this.bigbtn_purchaseinvoice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bigbtn_clients);
            this.Controls.Add(this.bigbtn_products);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القائمة الرئيسية";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem العملاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem العملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أضافةمستخدمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةمنتجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التحكمفيالمنتجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالمنتجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةعميلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التحكمفيالعملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالعملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أضافةموردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التحكمفيالموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فاتورةمشترياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فاتورةمبيعاتToolStripMenuItem;
        private System.Windows.Forms.Button bigbtn_products;
        private System.Windows.Forms.Button bigbtn_clients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bigbtn_purchaseinvoice;
        private System.Windows.Forms.Button bigbtn_saleinvoice;
        private System.Windows.Forms.Button bigbtn_report;
        private System.Windows.Forms.Label lbl_user;
    }
}