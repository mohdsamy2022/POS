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

namespace POS.Screens.Categories
{
    public partial class CategoryAdd : Form
    {
        public CategoryAdd(POS.Screens.Products.Products productsform)
        {
            InitializeComponent();
            this.productsform = productsform;
        }
        POSEntities db = new POSEntities();
        Category category = new Category();
        int id = 0;
        private readonly Products.Products productsform;

        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();
            btn_categoryedit.Enabled = false;
        }

        private void txt_categorysearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_categorysearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Categories.Where(x => x.Name.Contains(txt_categorysearch.Text) ).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Categories.ToList();
            }
        }

        private void btn_categorysearch_Click(object sender, EventArgs e)
        {
            if (txt_categorysearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Categories.Where(x => x.Name.Contains(txt_categorysearch.Text)).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Categories.ToList();
            }
        }

        private void btn_categoryedit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (id > 0)
            {
                category = db.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
                category.Name = txt_categoryname.Text.Trim();



                db.SaveChanges();

                MessageBox.Show("تم تعديل الصنف بنجاح");
                dataGridView1.DataSource = db.Categories.ToList();
                //this.Close();
                clear();
                //customer.customerID = 0;

            }
        }

        private void btn_categoryadd_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (txt_categoryname.Text == string.Empty )
                {
                    MessageBox.Show("أكمل البيانات اولا");
                }
                else
                {
                    category.Name = txt_categoryname.Text.Trim();

                    db.Categories.Add(category);
                    db.SaveChanges();


                    MessageBox.Show("تم حفظ الصنف بنجاح");
                    dataGridView1.DataSource = db.Categories.ToList();
                    //this.Close();
                    clear();
                }
            }
        }

        void clear()
        {
            txt_categoryname.Text = string.Empty;
            txt_notes.Text = string.Empty;
            id = 0;
            btn_categoryadd.Enabled = true;
            btn_categoryedit.Enabled = false;
        }

        private void btn_categorydelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("عملية حذف", "هل أنت متأكد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (id > 0)
                {
                    category = db.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
                    db.Categories.Remove(category);
                    db.SaveChanges();
                    MessageBox.Show("تم حذف الصنف بنجاح");
                    clear();

                    dataGridView1.DataSource = db.Categories.ToList();

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
                    btn_categoryadd.Enabled = false;
                    btn_categoryedit.Enabled = true;
                    category = db.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
                    txt_categoryname.Text = category.Name;



                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void CategoryAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            productsform.combo_category.DataSource = db.Categories.ToList();
        }
    }
}
