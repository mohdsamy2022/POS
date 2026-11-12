using POS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS.Screens.SalesBill
{
    public partial class SalesBillForm : Form
    {
        public SalesBillForm()
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
        int qty = 0;
        decimal sumtotal = 0;
        decimal finaltotal = 0;
        decimal discount = 0;
        private void SalesBillForm_Load(object sender, EventArgs e)
        {
            combo_client.DataSource = db.Customers.Where(x=>x.isActive==true).ToList();
            combo_client.ValueMember = "clientID";
            combo_client.DisplayMember = "Name";
            combo_client.SelectedIndex = -1;
            dataGridView2.DataSource = db.Products.ToList();
            //dataGridView1.DataSource = db.InvoiceDetails.Where(x=>x.ProductID==null).ToList();
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("كود المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("سعر المنتج");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("الإجمالي");
            //txt_discount.Text = 0.ToString();
            //txt_sum.Text = 0.ToString();
            //txt_total.Text = 0.ToString();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ProductID"].Value);
                if (id > 0)
                {
                    //MessageBox.Show(product.ProductID.ToString());
                    
                    product = db.Products.Where(x => x.ProductID == id).FirstOrDefault();
                    int nRowIndex = dataGridView1.Rows.Count - 2;
                    //MessageBox.Show(flag+" rowis "+nRowIndex);
                    /*if(nRowIndex >= 0)
                    {
                        for(int i=0; i < dataGridView1.Rows.Count;i++)
                        {
                            if (Convert.ToString(dataGridView1.Rows[i].Cells["اسم المنتج"].Value) == product.Name.ToString())
                            {
                                //MessageBox.Show(product.Name.ToString());
                                //MessageBox.Show(Convert.ToString(dataGridView1.Rows[i].Cells["اسم المنتج"].Value));
                                //qty = qty + 1;
                                dataGridView1.Rows[i].Cells["الكمية"].Value = int.Parse(dataGridView1.Rows[i].Cells["الكمية"].Value.ToString()) + 1;
                                decimal total2 = (decimal)(int.Parse(dataGridView1.Rows[i].Cells["الكمية"].Value.ToString()) * product.Price);
                                dataGridView1.Rows[i].Cells["الإجمالي"].Value = total2;
                            }
                            else
                            {
                                qty = 1;
                                decimal total = (decimal)(qty * product.Price);
                                dt.Rows.Add(product.Code, product.Name, product.Price, qty, total);
                            }
                        }

                    }*/

                    /*if (nRowIndex>=0)
                    {
                        if (Convert.ToString(dataGridView1.Rows[nRowIndex].Cells["اسم المنتج"].Value) == product.Name.ToString() && nRowIndex >= 0)
                        {
                            dataGridView1.Rows[nRowIndex].Cells["الكمية"].Value = int.Parse(dataGridView1.Rows[nRowIndex].Cells["الكمية"].Value.ToString()) + 1;
                            decimal total2 = (decimal)(int.Parse(dataGridView1.Rows[nRowIndex].Cells["الكمية"].Value.ToString()) * product.Price);
                            dataGridView1.Rows[nRowIndex].Cells["الإجمالي"].Value = total2;
                        }

                    }

                    else if(nRowIndex<=-2 || Convert.ToString(dataGridView1.Rows[nRowIndex].Cells["اسم المنتج"].Value) == product.Name.ToString())
                    {
                        qty = 1;
                        decimal total = (decimal)(qty * product.Price);
                        dt.Rows.Add(product.Code, product.Name, product.Price, qty, total);
                    }*/
                    int tqty= dt.AsEnumerable().Where(x => x.Field<string>("اسم المنتج") == product.Name.ToString()).Sum(x => Convert.ToInt32(x["الكمية"]));
                    if (product.Quantity>0)
                    {
                        //MessageBox.Show(tqty.ToString());
                        qty = 1;
                        decimal total = (decimal)(qty * product.Price);
                        product.Quantity -= 1;
                        dt.Rows.Add(product.ProductID,product.Code, product.Name, product.Price, qty, total);
                        dataGridView2.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("نفذت كمية النتج");
                    }


                    sumtotal = dt.AsEnumerable().Sum(x => Convert.ToDecimal(x["الإجمالي"]));   //Where(x => x.Field<string>("اسم المنتج") == "شيبسي")
                    if (txt_discount.Text ==string.Empty)
                    {
                        discount = 0;
                    }
                    else
                    {
                        discount = decimal.Parse(txt_discount.Text);
                    }
                    finaltotal=sumtotal * (1 - discount);
                    txt_sum.Text = sumtotal.ToString();
                    txt_total.Text = finaltotal.ToString();
                    dataGridView1.DataSource = dt;
                    //MessageBox.Show(dataGridView1.Rows.Count.ToString());
                }
            }
        }



        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !dataGridView1.SelectedRows[0].IsNewRow)
            {
                //dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["معرف المنتج"].Value);
                product = db.Products.Where(x => x.ProductID == id).FirstOrDefault();
                product.Quantity += 1;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                dataGridView2.Refresh();
                sumtotal = dt.AsEnumerable().Sum(x => Convert.ToDecimal(x["الإجمالي"]));
                txt_sum.Text =sumtotal.ToString();
                txt_discount.Text = 0.ToString();
                discount = decimal.Parse(txt_discount.Text);
                finaltotal = sumtotal * (1 - discount);
                txt_total.Text = finaltotal.ToString();
            }
        }

        private void btn_invoiceadd_Click(object sender, EventArgs e)
        {
            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (sumtotal > 0 && dataGridView1.Rows.Count > 0)
                    {
                        MessageBox.Show(combo_client.SelectedValue.ToString());
                        MessageBox.Show(combo_client.Text);
                        MessageBox.Show(sumtotal.ToString());
                        MessageBox.Show(finaltotal.ToString());
                        MessageBox.Show(discount.ToString());
                        invoice.ClientID = (int?)combo_client.SelectedValue;
                        invoice.ClientName = combo_client.Text;
                        invoice.InvoiceDate = dateTimePicker1.Value;
                        invoice.InvoiceNotes = txt_notes.Text;
                        invoice.GrandTotal = sumtotal;
                        invoice.Discount = discount;
                        invoice.FinalTotal = finaltotal;
                        db.Invoices.Add(invoice);
                        db.SaveChanges();

                        List<InvoiceDetail> list = new List<InvoiceDetail>();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            string productName = (string)dataGridView1.Rows[i].Cells["اسم المنتج"].Value;
                            product = db.Products.Where(x => x.Name == productName.ToString()).FirstOrDefault();
                            list.Add(new InvoiceDetail
                            {
                                InvoiceID = invoice.InvoiceID,
                                ClientName = invoice.ClientName,
                                InvoiceDate = invoice.InvoiceDate,
                                ProductName = (string)dataGridView1.Rows[i].Cells["اسم المنتج"].Value,
                                ProductID = int.Parse(dataGridView1.Rows[i].Cells["معرف المنتج"].Value.ToString()),
                                //ProductID = product.ProductID,
                                ProductPrice = decimal.Parse(dataGridView1.Rows[i].Cells["سعر المنتج"].Value.ToString()),
                                ProductQuantity = int.Parse(dataGridView1.Rows[i].Cells["الكمية"].Value.ToString()),
                                ProductTotal = decimal.Parse(dataGridView1.Rows[i].Cells["الإجمالي"].Value.ToString())
                            });


                        }
                        db.InvoiceDetails.AddRange(list);
                        db.SaveChanges();
                        transaction.Commit();
                        MessageBox.Show("تم حفظ الفاتورة بنجاح");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("ادخل المنتجات اولا");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خظأ أثناء حفظ البيانات : Message - {ex.Message}");
                    transaction.Rollback();
                }
            }



        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            //txt_total.Text = (decimal.Parse(txt_discount.Text) * decimal.Parse(txt_sum.Text)).ToString();
            if (txt_discount.Text == string.Empty)
            {
                discount = 0;
            }
            else
            {
                discount = decimal.Parse(txt_discount.Text);
            }
            txt_total.Text = ((1-discount) * sumtotal).ToString();
            finaltotal = decimal.Parse(txt_total.Text);
        }

        void clear()
        {
            dt.Rows.Clear();
            combo_client.SelectedIndex = -1;
            txt_discount.Text = string.Empty;
            txt_sum.Text = string.Empty;
            txt_notes.Text = string.Empty;
            txt_total.Text = string.Empty;
        }

        private void btn_invoices_Click(object sender, EventArgs e)
        {
            frmInvoices invoices = new frmInvoices();
            invoices.Show();
        }
    }
}
