﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            meatUserControl.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            meatUserControl.Hide();
        }
    }
}
