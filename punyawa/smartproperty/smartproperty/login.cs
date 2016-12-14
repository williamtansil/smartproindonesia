using System;
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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        bool placeholdercontain;
        register Register;
        public login()
        {
            Register = new register();
            Register.Login = this;
            placeholdercontain = true;
            InitializeComponent();
        }

        private void userid_Enter(object sender, EventArgs e)
        {
            if(username.Text == "username")
            {
                username.Text = "";
            }
        }

        private void userid_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "username";
            }
        }

        private void userpass_Enter(object sender, EventArgs e)
        {
            if (placeholdercontain) 
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
            }
        }

        private void userpass_Leave(object sender, EventArgs e)
        {
            if (password.Text == "") 
            {
                password.UseSystemPasswordChar = false;
                password.Text = "password";
                placeholdercontain = true;
            }
        }

        private void notregistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register.Show();
            this.Hide();
        }

        private void userpass_KeyDown(object sender, KeyEventArgs e)
        {
            placeholdercontain = false;
        }
    }
}
