using POS.DB;
using POS.Screens.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Screens.Products
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }
        POSEntities db= new POSEntities();
        Product product = new Product();
        Category category = new Category();
        string imagepath = "";
        int id = 0;
        int id2 = 0;
        private void ProductList_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.Products.ToList();
            dataGridView1.DataSource = (from d in db.Products
                                        select new 
                                        {
                                            d.ProductID,
                                            d.Name,
                                            d.Code,
                                            d.Price,
                                            d.Quantity,
                                            d.Notes,
                                            d.Image,
                                            d.CategoryID,
                                            CategoryName=d.Category.Name
                                        }).ToList();

            //dataGridView1.Columns.Add("category name", "category Name");
            //category = db.Categories.Where(x=>x.CategoryID==id2).FirstOrDefault();
            //dataGridView1.Columns["category name"].DataPropertyName = product.Category.Name;
            //dataGridView1.Rows[0].Cells["category name"].Value = product.Category.Name;
            //dataGridView1.Rows.Add("category name");
            //dataGridView1.Columns["Category"].Visible = false;
            combo_category.DataSource = db.Categories.ToList();
            combo_category.ValueMember = "CategoryID";
            combo_category.DisplayMember = "Name";
            //combo_category.SelectedIndex=-1;

        }

        private void txt_productsearch_TextChanged(object sender, EventArgs e)
        {
            if(txt_productsearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Products.Where(x=>x.Name.Contains(txt_productsearch.Text) || x.Code.Contains(txt_productsearch.Text)).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Products.ToList();
            }
        }

        private void btn_productsave_Click(object sender, EventArgs e)
        {
            if (txt_productsearch.Text != string.Empty)
            {
                dataGridView1.DataSource = db.Products.Where(x => x.Name.Contains(txt_productsearch.Text) || x.Code.Contains(txt_productsearch.Text)).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Products.ToList();
            }
        }

        private void btn_productedit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
            id2= Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryID"].Value);
            if (id > 0)
            {
                product = db.Products.Where(x => x.ProductID == id).FirstOrDefault();
                product.Name = txt_productname.Text.Trim();
                product.Code = txt_barcode.Text.Trim();
                product.Notes = txt_notes.Text.Trim();
                product.Price = decimal.Parse(txt_price.Text.Trim());
                product.Quantity = int.Parse(txt_quantity.Text.Trim());
                
                //string combovalue= combo_category.SelectedValue.ToString();
                if (combo_category.SelectedIndex>=0)
                {
                    product.CategoryID = int.Parse(combo_category.SelectedValue.ToString());
                }
                //product.CategoryID=int.Parse(combo_category.SelectedValue.ToString());

                if (imagepath != string.Empty)
                {
                    string newpath = Environment.CurrentDirectory + "\\images\\Products\\" + product.ProductID + ".jpg";
                    File.Copy(imagepath, newpath,true);
                    product.Image = newpath;

                    //db.SaveChanges();

                }
                db.SaveChanges();
     
                MessageBox.Show("تم تعديل المنتج بنجاح");
                dataGridView1.DataSource = db.Products.ToList();
                //this.Close();
                //clear();
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

                if (dataGridView1.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                    id2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryID"].Value);
                if (id > 0)
                    {
                        //MessageBox.Show(product.ProductID.ToString());
                        product = db.Products.Where(x => x.ProductID == id).FirstOrDefault();
                        txt_barcode.Text = product.Code;
                        txt_productname.Text = product.Name;
                        txt_price.Text = product.Price.ToString();
                        txt_quantity.Text = product.Quantity.ToString();
                        txt_notes.Text = product.Notes;
                        picbox_productphoto.ImageLocation = product.Image;
                        if(product.CategoryID != null)
                        {
                        combo_category.SelectedValue = product.CategoryID;
                        }
                        else
                        {
                        combo_category.SelectedIndex = -1;
                        }


                    }
                }



        }

        private void picbox_productphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                picbox_productphoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btn_productdelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("عملية حذف","هل أنت متأكد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                id2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryID"].Value);
                if (id > 0)
                {
                    product = db.Products.Where(x => x.ProductID == id).FirstOrDefault();
                    db.Products.Remove(product);
                    db.SaveChanges();
                    MessageBox.Show("تم حذف المنتج بنجاح");
                    product.ProductID = 0;
                    dataGridView1.DataSource = db.Products.ToList();
                }
            }

        }
    }
}
