using POS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Screens.SalesBill
{
    public partial class frmInvoices : Form
    {
        public frmInvoices()
        {
            InitializeComponent();
        }
        POSEntities db = new POSEntities();
        Customer customer = new Customer();
        Product product = new Product();
        Invoice invoice = new Invoice();
        InvoiceDetail invoiceDetail = new InvoiceDetail();
        DataTable dt = new DataTable();
        int id = 0;
        private void frmInvoices_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Invoices.OrderByDescending(x=>x.InvoiceDate).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["InvoiceID"].Value);
            dataGridView2.DataSource = db.InvoiceDetails.Where(x=>x.InvoiceID==id).ToList();
        }
    }
}
