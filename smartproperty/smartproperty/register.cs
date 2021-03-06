﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;


namespace smartproperty
{
    public partial class register : MetroFramework.Forms.MetroForm
    {
        public login Login { get; set; }
        public register()
        {
            InitializeComponent();
        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Login.BringToFront();
            this.Login.Show();
        }
    }
}
