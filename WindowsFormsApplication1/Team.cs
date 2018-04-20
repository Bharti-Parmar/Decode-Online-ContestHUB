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
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }

        private void btn_bharti_Click(object sender, EventArgs e)
        {
            Bharti b = new Bharti();
           // b.MdiParent = Home;                    
            b.Show();
        }

        private void btn_atul_Click(object sender, EventArgs e)
        {
            Atul a = new Atul();
           // a.MdiParent = this;                  
            a.Show();
        }

        private void btn_partha_Click(object sender, EventArgs e)
        {
            Partha p = new Partha();
           // p.MdiParent = this;                 
            p.Show();
        }

       
    }
}
