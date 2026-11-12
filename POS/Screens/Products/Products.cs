using POS.DB;
using POS.Screens.Categories;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS.Screens.Products
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            combo_category.DataSource=db.Categories.ToList();
            combo_category.ValueMember = "CategoryID";
            combo_category.DisplayMember = "Name";
        }
        POSEntities db = new POSEntities();
        Product Product=new Product();
        string imagepath="";
        private void btn_productsave_Click(object sender, EventArgs e)
        {
            if(txt_barcode.Text==string.Empty || txt_price.Text==string.Empty
                || txt_productname.Text==string.Empty || txt_quantity.Text==string.Empty
                ||combo_category.SelectedValue ==null)
            {
                MessageBox.Show("أكمل البيانات اولا");
            }
            else
            {
                Product.Name = txt_productname.Text.Trim();
                Product.Code = txt_barcode.Text.Trim();
                Product.Notes = txt_notes.Text.Trim();
                Product.Price = decimal.Parse(txt_price.Text.Trim());
                Product.Quantity = int.Parse(txt_quantity.Text.Trim());
                Product.CategoryID=int.Parse(combo_category.SelectedValue.ToString());
                Product.Image = imagepath;
                db.Products.Add(Product);
                db.SaveChanges();

                if(imagepath !=string.Empty)
                {
                    string newpath = Environment.CurrentDirectory + "\\images\\Products\\" + Product.ProductID + ".jpg";
                    File.Copy(imagepath, newpath);
                    Product.Image = newpath;
                    //db.Users.Add(user);
                    db.SaveChanges();

                }
                MessageBox.Show("تم حفظ المنتج بنجاح");
                //this.Close();
                clear();
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
        void clear()
        {
            txt_barcode.Text = string.Empty;
            txt_price.Text = string.Empty;
            txt_quantity.Text = string.Empty;
            txt_notes.Text = string.Empty;
            txt_productname.Text = string.Empty;
            picbox_productphoto.ImageLocation = string.Empty;
        }

        private void btn_listproducts_Click(object sender, EventArgs e)
        {
            ProductList productlist = new ProductList();
            productlist.Show();
            this.Close();
        }

        private void btn_categoryadd_Click(object sender, EventArgs e)
        {
            CategoryAdd categoryAdd= new CategoryAdd(this);
            categoryAdd.Show();
        }
    }
}
