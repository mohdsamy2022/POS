using POS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        POSEntities db = new POSEntities();
        //User user = new User();

        private void btn_userlogin_Click(object sender, EventArgs e)
        {
            var result=db.Users.Where(x=>x.userName==txt_username.Text && x.Password==txt_password.Text).FirstOrDefault();
            if(result != null)
            {
                this.Close();
                Thread th = new Thread(openform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                cuser.cuserID = result.userID;
                cuser.cuserName=result.userName;
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة سر غير صحيحة");
            }
            
        }

        void openform()
        {
            Application.Run(new MainForm());
        }
    }

    static class cuser
    {
        static public int cuserID { get; set; }
        static public string cuserName { get; set; }
    }
}
