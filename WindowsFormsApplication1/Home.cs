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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

       

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.label4.Text = lbl_GetIDhere.Text;
            cp.label5.Text = lbl_getusertype.Text;
            cp.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_getusertype.Text == "Admin")
            {
                DeleteUser DU = new DeleteUser();
                DU.MdiParent = this;
                DU.Show();
            }
            else
            {
                MessageBox.Show("Admin rights required to do this operation");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser VU = new ViewUser();
            VU.MdiParent = this;
            VU.Show();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void teamMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Team NU = new Team();
            NU.MdiParent = this;                    
            NU.Show();
        }

        private void lbl_GetIDhere_Click(object sender, EventArgs e)
        {

        }

        private void lbl_getusertype_Click(object sender, EventArgs e)
        {

        }

        private void contestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contest NU = new Contest();
            NU.MdiParent = this;
            NU.Show();
        }
    }
}
