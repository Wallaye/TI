﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_Lab1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnterPlainText_Click(object sender, EventArgs e)
        {
            lblTest.Text = txtPlainText.Text;
        }

        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
