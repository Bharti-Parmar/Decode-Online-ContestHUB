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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.fillcombobox(cBox_selectuser);
        }

        private void cBox_selectuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_message.Text="You selected"+cBox_selectuser.Text;   //selected username show
        
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.UserName = cBox_selectuser.Text;
            cDB.deleteuser(cDB);
            lbl_message.Text = "User Deleted";
        }
    }
}
