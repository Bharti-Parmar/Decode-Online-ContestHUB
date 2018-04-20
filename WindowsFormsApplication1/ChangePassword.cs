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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
          //Home hobj = new Home();
            cDB.UserName = label4.Text;
            cDB.UserType = label5.Text;
            cDB.Password = txt_oldpassword.Text;
           // cDB.txt_newpassword = txt_cnewpassword.Text;
            if (cDB.Authenticate(cDB))
            {
                if (txt_newpassword.Text == txt_cnewpassword.Text)
                {
                    cDB.Password = txt_newpassword.Text;
                    cDB.changemypassword(cDB);
                    MessageBox.Show("Password Changed");
                }
                else
                {
                    MessageBox.Show("Password Does Not Match");
                } 
            }
            else
            {
                MessageBox.Show("Old Password is incorrect");
            }
      
        }
    }
}
