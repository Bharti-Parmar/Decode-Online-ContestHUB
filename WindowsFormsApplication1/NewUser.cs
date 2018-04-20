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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void btn_cnewuser_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.name = txt_name.Text;
            cDB.city = txt_city.Text;
            cDB.UserName = txt_username.Text;
            if (txt_password.Text == txt_Confirm_Password.Text)
            {
                cDB.Password = txt_password.Text;
            }
            cDB.UserType = txt_usertype.Text;
            if (txt_password.Text == txt_Confirm_Password.Text)
            {
                cDB.createnewuser(cDB);
                MessageBox.Show("New User Created");
            }
            else
            {
                MessageBox.Show("Password Does Not Match");
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Confirm_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
