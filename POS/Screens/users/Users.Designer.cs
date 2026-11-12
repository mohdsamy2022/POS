namespace POS.Screens.users
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_addpassword = new System.Windows.Forms.TextBox();
            this.txt_addusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picbox_userphoto = new System.Windows.Forms.PictureBox();
            this.btn_usersave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_userphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_addpassword
            // 
            this.txt_addpassword.Location = new System.Drawing.Point(64, 98);
            this.txt_addpassword.Name = "txt_addpassword";
            this.txt_addpassword.PasswordChar = '*';
            this.txt_addpassword.Size = new System.Drawing.Size(288, 37);
            this.txt_addpassword.TabIndex = 8;
            // 
            // txt_addusername
            // 
            this.txt_addusername.BackColor = System.Drawing.SystemColors.Window;
            this.txt_addusername.Location = new System.Drawing.Point(64, 28);
            this.txt_addusername.Name = "txt_addusername";
            this.txt_addusername.Size = new System.Drawing.Size(288, 37);
            this.txt_addusername.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(402, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "كلمة السر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(368, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(432, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "صورة";
            // 
            // picbox_userphoto
            // 
            this.picbox_userphoto.BackColor = System.Drawing.Color.Honeydew;
            this.picbox_userphoto.Location = new System.Drawing.Point(237, 155);
            this.picbox_userphoto.Name = "picbox_userphoto";
            this.picbox_userphoto.Size = new System.Drawing.Size(115, 97);
            this.picbox_userphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_userphoto.TabIndex = 10;
            this.picbox_userphoto.TabStop = false;
            this.picbox_userphoto.Click += new System.EventHandler(this.picbox_userphoto_Click);
            // 
            // btn_usersave
            // 
            this.btn_usersave.Image = global::POS.Properties.Resources.Save;
            this.btn_usersave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_usersave.Location = new System.Drawing.Point(271, 258);
            this.btn_usersave.Name = "btn_usersave";
            this.btn_usersave.Size = new System.Drawing.Size(81, 38);
            this.btn_usersave.TabIndex = 9;
            this.btn_usersave.Text = "حفظ";
            this.btn_usersave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usersave.UseVisualStyleBackColor = true;
            this.btn_usersave.Click += new System.EventHandler(this.btn_usersave_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(545, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_userphoto);
            this.Controls.Add(this.btn_usersave);
            this.Controls.Add(this.txt_addpassword);
            this.Controls.Add(this.txt_addusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستخدم";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_userphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_usersave;
        private System.Windows.Forms.TextBox txt_addpassword;
        private System.Windows.Forms.TextBox txt_addusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_userphoto;
        private System.Windows.Forms.Label label3;
    }
}