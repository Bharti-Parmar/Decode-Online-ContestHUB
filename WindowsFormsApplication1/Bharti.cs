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
    public partial class Bharti : Form
    {
        public Bharti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Home NU = new Home();
            NU.MdiParent = this;                    //New user form open inside the home page
            NU.Show();*/
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
