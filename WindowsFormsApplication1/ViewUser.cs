﻿using System;
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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            dataGridView1.AutoGenerateColumns=true;
            cDB.FillGrid(dataGridView1);
        }
    }
}
