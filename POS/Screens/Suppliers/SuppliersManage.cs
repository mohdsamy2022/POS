using POS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Screens.Suppliers
{
    public partial class SuppliersManage : Form
    {
        public SuppliersManage()
        {
            InitializeComponent();
        }
        POSEntities db = new POSEntities();
        Supplier supplier = new Supplier();
        string imagepath = "";
        int id = 0;
        private void SuppliersManage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Suppliers.ToList();
            checkBox_isactivesupplier.Checked = false;
            btn_supplieredit.Enabled = false;
        }

        private void txt_suppliersearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_suppliersearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Suppliers.Where(x => x.Name.Contains(txt_suppliersearch.Text) || x.Phone.Contains(txt_suppliersearch.Text)).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Suppliers.ToList();
            }
        }

        private void btn_suppliersearch_Click(object sender, EventArgs e)
        {
            if (txt_suppliersearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Suppliers.Where(x => x.Name.Contains(txt_suppliersearch.Text) || x.Phone.Contains(txt_suppliersearch.Text)).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Suppliers.ToList();
            }
        }

        private void btn_supplieredit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (id > 0)
            {
                supplier = db.Suppliers.Where(x => x.SupplierID == id).FirstOrDefault();
                supplier.Name = txt_suppliername.Text.Trim();
                supplier.Phone = txt_phone.Text.Trim();
                supplier.Notes = txt_notes.Text.Trim();
                supplier.Company = txt_companyname.Text.Trim();
                supplier.email = txt_email.Text.Trim();
                supplier.Address = txt_supplieraddress.Text.Trim();
                supplier.isActive = checkBox_isactivesupplier.Checked;

                if (imagepath != string.Empty)
                {
                    string newpath = Environment.CurrentDirectory + "\\images\\Suppliers\\" + supplier.SupplierID + ".jpg";
                    File.Copy(imagepath, newpath, true);
                    supplier.Image = newpath;

                    //db.SaveChanges();

                }
                db.SaveChanges();

                MessageBox.Show("تم تعديل المورد بنجاح");
                dataGridView1.DataSource = db.Suppliers.ToList();
                //this.Close();
                clear();
                //customer.customerID = 0;

            }
        }

        private void picbox_supplierphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                picbox_supplierphoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btn_supplieradd_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (txt_suppliername.Text == string.Empty || txt_phone.Text == string.Empty)
                {
                    MessageBox.Show("أكمل البيانات اولا");
                }
                else
                {
                    supplier.Name = txt_suppliername.Text.Trim();
                    supplier.Phone = txt_phone.Text.Trim();
                    supplier.Notes = txt_notes.Text.Trim();
                    supplier.Company = txt_companyname.Text.Trim();
                    supplier.email = txt_email.Text.Trim();
                    supplier.Address = txt_supplieraddress.Text.Trim();
                    supplier.isActive = checkBox_isactivesupplier.Checked;
                    supplier.Image = imagepath;
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();

                    if (imagepath != string.Empty)
                    {
                        string newpath = Environment.CurrentDirectory + "\\images\\Suppliers\\" + supplier.SupplierID + ".jpg";
                        File.Copy(imagepath, newpath);
                        supplier.Image = newpath;
                        //db.Users.Add(user);
                        db.SaveChanges();

                    }
                    MessageBox.Show("تم حفظ المورد بنجاح");
                    dataGridView1.DataSource = db.Suppliers.ToList();
                    //this.Close();
                    clear();
                }
            }
        }

        void clear()
        {
            txt_suppliername.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_notes.Text = string.Empty;
            txt_companyname.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_supplieraddress.Text = string.Empty;
            picbox_supplierphoto.ImageLocation = string.Empty;
            imagepath = string.Empty;
            checkBox_isactivesupplier.Checked = false;
            id = 0;
            btn_supplieradd.Enabled = true;
            btn_supplieredit.Enabled = false;
        }

        private void btn_supplierdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("عملية حذف", "هل أنت متأكد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (id > 0)
                {
                    supplier = db.Suppliers.Where(x => x.SupplierID == id).FirstOrDefault();
                    db.Suppliers.Remove(supplier);
                    db.SaveChanges();
                    MessageBox.Show("تم حذف العميل بنجاح");
                    clear();

                    dataGridView1.DataSource = db.Suppliers.ToList();

                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (id > 0)
                {
                    //MessageBox.Show(product.ProductID.ToString());
                    btn_supplieradd.Enabled = false;
                    btn_supplieredit.Enabled = true;
                    supplier = db.Suppliers.Where(x => x.SupplierID == id).FirstOrDefault();
                    txt_suppliername.Text = supplier.Name;
                    txt_phone.Text = supplier.Phone;
                    txt_notes.Text = supplier.Notes;
                    txt_companyname.Text = supplier.Company;
                    txt_email.Text = supplier.email;
                    txt_supplieraddress.Text = supplier.Address;
                    if (supplier.isActive == null)
                    {
                        supplier.isActive = false;
                    }
                    checkBox_isactivesupplier.Checked = (bool)supplier.isActive;
                    picbox_supplierphoto.ImageLocation = supplier.Image;

                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();

        }
    
    }
}
