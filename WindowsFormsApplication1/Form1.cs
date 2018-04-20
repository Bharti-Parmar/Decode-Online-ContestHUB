using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.UserName = txt_username.Text;
            cDB.Password = txt_password.Text;
            if (rbtn_admin.Checked)
            {
                cDB.UserType = "Admin";
            }
            else if (rbtn_user.Checked)
            {
                cDB.UserType = "User";
            }
            if (cDB.Authenticate(cDB))
            {
                Home hform = new Home();
                hform.lbl_GetIDhere.Text = txt_username.Text;
                hform.lbl_getusertype.Text = cDB.UserType;
                txt_password.Text = "";
                hform.Show();
                //MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            rbtn_admin.Checked = false;
            rbtn_user.Checked = false;
        }

        private void rbtn_user_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
