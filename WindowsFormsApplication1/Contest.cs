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
    public partial class Contest : Form
    {
        public Contest()
        {
            InitializeComponent();
        }

        private void btn_beginer_Click(object sender, EventArgs e)
        {
            Beginer b = new Beginer();
                           
            b.Show();
        }

        private void btn_hackerrank_Click(object sender, EventArgs e)
        {
            Hackerrank b = new Hackerrank();
                            
            b.Show();
        }

        private void btn_Codechef_Click(object sender, EventArgs e)
        {
           Codechef b = new Codechef();
                             
            b.Show();
        }
    }
}
