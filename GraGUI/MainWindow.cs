﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraGUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var f2 = new ComputerForm();
            f2.ShowDialog();
        }
    }
}
