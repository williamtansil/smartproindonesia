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
using MaterialSkin.Controls;

namespace smartproperty
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile2_MouseDown(object sender, MouseEventArgs e)
        {
            for (int _i = 59; _i <= 259; _i+=8) 
            {
                sidemenu.Width = _i;
                sidemenu.Update();
            }
            sidelogo.Visible ^= true;
            collapsed.Visible ^= true;
        }

        private void uncollapsed_MouseDown(object sender, MouseEventArgs e)
        {
            for (int _i = 250; _i >= 59; _i-=2)
            {
                sidemenu.Width = _i;
                sidemenu.Update();
            }
            sidelogo.Visible ^= true; 
            collapsed.Visible ^= true;
        }

        private void Cart_MouseLeave(object sender, EventArgs e)
        {
            if (Cursor.Position.Y > panel2.Height)
            {
                for (int _i = sidemenu.BackColor.R; _i > 32; _i--)
                {
                    sidemenu.BackColor = Color.FromArgb(_i, _i, _i);
                    sidemenu.Update();
                }
            }
        }

        private void Cart_MouseEnter(object sender, EventArgs e)
        {
            if (Cursor.Position.X > sidemenu.Width + 100)
            {
                for (int _i = sidemenu.BackColor.R; _i < 50; _i++)
                {
                    sidemenu.BackColor = Color.FromArgb(_i, _i, _i);
                    sidemenu.Update();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
