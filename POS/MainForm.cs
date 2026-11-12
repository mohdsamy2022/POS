using POS.Screens.Clients;
using POS.Screens.Products;
using POS.Screens.SalesBill;
using POS.Screens.Suppliers;
using POS.Screens.users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lbl_user.Text = "User: "+ cuser.cuserName;
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void أضافةمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void bigbtn_products_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void إضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void عرضالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.Show();
        }

        private void إضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManage clientManage = new ClientManage();
            clientManage.Show();
        }

        private void bigbtn_clients_Click(object sender, EventArgs e)
        {
            ClientManage clientManage = new ClientManage();
            clientManage.Show();
        }

        private void عرضالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersManage suppliersManage = new SuppliersManage();
            suppliersManage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuppliersManage suppliersManage = new SuppliersManage();
            suppliersManage.Show();
        }

        private void bigbtn_saleinvoice_Click(object sender, EventArgs e)
        {
            SalesBillForm salesbillform = new SalesBillForm();
            salesbillform.Show();
        }
    }
}
