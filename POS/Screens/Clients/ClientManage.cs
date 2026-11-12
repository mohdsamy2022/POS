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

namespace POS.Screens.Clients
{
    public partial class ClientManage : Form
    {
        public ClientManage()
        {
            InitializeComponent();
        }
        POSEntities db = new POSEntities();
        Customer customer=new Customer();
        string imagepath = "";
        int id = 0;
        private void ClientManage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=db.Customers.ToList();
            checkBox_isactiveclient.Checked=false;
            btn_clientedit.Enabled=false;
        }

        private void txt_clientsearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_clientsearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Customers.Where(x => x.Name.Contains(txt_clientsearch.Text) || x.Phone.Contains(txt_clientsearch.Text)).ToList();
                clear();
            }
            else
            {
                dataGridView1.DataSource = db.Customers.ToList();
            }
        }

        private void btn_clientsearch_Click(object sender, EventArgs e)
        {
            if (txt_clientsearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Customers.Where(x => x.Name.Contains(txt_clientsearch.Text) || x.Phone.Contains(txt_clientsearch.Text)).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Customers.ToList();
            }
        }

        private void btn_clientedit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (id > 0)
            {
                customer = db.Customers.Where(x => x.clientID == id).FirstOrDefault();
                customer.Name = txt_clientname.Text.Trim();
                customer.Phone = txt_phone.Text.Trim();
                customer.Notes = txt_notes.Text.Trim();
                customer.Company = txt_companyname.Text.Trim();
                customer.email = txt_email.Text.Trim();
                customer.Address=txt_clientaddress.Text.Trim();
                customer.isActive = checkBox_isactiveclient.Checked;

                if (imagepath != string.Empty)
                {
                    string newpath = Environment.CurrentDirectory + "\\images\\Clients\\" + customer.clientID + ".jpg";
                    File.Copy(imagepath, newpath, true);
                    customer.Image = newpath;

                    //db.SaveChanges();

                }
                db.SaveChanges();

                MessageBox.Show("تم تعديل العميل بنجاح");
                dataGridView1.DataSource = db.Customers.ToList();
                //this.Close();
                clear();
                //customer.clientID = 0;

            }
        }

        private void picbox_clientphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                picbox_clientphoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btn_clientadd_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                if (txt_clientname.Text == string.Empty || txt_phone.Text == string.Empty)
                {
                    MessageBox.Show("أكمل البيانات اولا");
                }
                else
                {
                    customer.Name = txt_clientname.Text.Trim();
                    customer.Phone = txt_phone.Text.Trim();
                    customer.Notes = txt_notes.Text.Trim();
                    customer.Company = txt_companyname.Text.Trim();
                    customer.email = txt_email.Text.Trim();
                    customer.Address = txt_clientaddress.Text.Trim();
                    customer.isActive = checkBox_isactiveclient.Checked;
                    customer.Image = imagepath;
                    db.Customers.Add(customer);
                    db.SaveChanges();

                    if (imagepath != string.Empty)
                    {
                        string newpath = Environment.CurrentDirectory + "\\images\\Clients\\" + customer.clientID + ".jpg";
                        File.Copy(imagepath, newpath);
                        customer.Image = newpath;
                        //db.Users.Add(user);
                        db.SaveChanges();

                    }
                    MessageBox.Show("تم حفظ العميل بنجاح");
                    dataGridView1.DataSource = db.Customers.ToList();
                    //this.Close();
                    clear();
                }
            }

        }

        void clear()
        {
            txt_clientname.Text=string.Empty;
            txt_phone.Text = string.Empty;
            txt_notes.Text = string.Empty;
            txt_companyname.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_clientaddress.Text = string.Empty;
            picbox_clientphoto.ImageLocation = string.Empty;
            imagepath = string.Empty;
            checkBox_isactiveclient.Checked = false;
            id = 0;
            btn_clientadd.Enabled = true;
            btn_clientedit.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btn_clientdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("عملية حذف", "هل أنت متأكد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (id > 0)
                {
                    customer = db.Customers.Where(x => x.clientID == id).FirstOrDefault();
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    MessageBox.Show("تم حذف العميل بنجاح");
                    clear();

                    dataGridView1.DataSource = db.Customers.ToList();

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
                    btn_clientadd.Enabled = false;
                    btn_clientedit.Enabled = true;
                    customer = db.Customers.Where(x => x.clientID == id).FirstOrDefault();
                    txt_clientname.Text = customer.Name;
                    txt_phone.Text = customer.Phone;
                    txt_notes.Text = customer.Notes;
                    txt_companyname.Text = customer.Company;
                    txt_email.Text = customer.email;
                    txt_clientaddress.Text = customer.Address;
                    if (customer.isActive == null)
                    {
                        customer.isActive = false;
                    }
                    checkBox_isactiveclient.Checked = (bool)customer.isActive;
                    picbox_clientphoto.ImageLocation = customer.Image;

                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();

        }
    }
}
