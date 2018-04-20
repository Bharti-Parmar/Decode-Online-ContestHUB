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
    public partial class WebSite : Form
    {
        public WebSite()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Form1 f = new Form1();
            f.MdiParent = this;                   
            f.Show();
        }

        private void signUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewUser NU = new NewUser();
            NU.MdiParent = this;                 
            NU.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WebSite_Load(object sender, EventArgs e)
        {

        }
    }
}
