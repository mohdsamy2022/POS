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

namespace POS.Screens.users
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            MessageBox.Show(Environment.CurrentDirectory);
        }
        POSEntities db = new POSEntities();
        User user = new User();
        string imagepath="";
        private void btn_usersave_Click(object sender, EventArgs e)
        {
            user.userName=txt_addusername.Text.Trim();
            user.Password=txt_addpassword.Text;
            user.userImage= imagepath;
            db.Users.Add(user);
            db.SaveChanges();

            if(imagepath !=string.Empty)
            {
                string newpath = Environment.CurrentDirectory + "\\images\\Users\\" + user.userID + ".jpg";
                File.Copy(imagepath, newpath);
                user.userImage = newpath;
                //db.Users.Add(user);
                db.SaveChanges();

            }
            MessageBox.Show("تم الحفظ بنجاح");
            this.Close();
        }

        private void picbox_userphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                imagepath=openFileDialog.FileName;
                picbox_userphoto.ImageLocation=openFileDialog.FileName;
            }
        }
    }
}
