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
using System.Threading;

namespace smartproperty
{
    public partial class Board : MetroFramework.Forms.MetroForm
    {
        public List<Panel> __sidemenus;
        public List<Panel> __sideicons;
        public List<Panel> __pages;
        public Board()
        {
            InitializeComponent();
            home.BringToFront();
            sidemenu.BringToFront();
            __sidemenus = new List<Panel>();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile2_MouseDown(object sender, MouseEventArgs e)
        {
            for (int _i = 59; _i <= 274; _i+=9) 
            {
                sidemenu.Width = _i;
                sidemenu.Update();
            }
            sidelogo.Visible ^= true;
            collapsed.Visible ^= true;

        }

        private void uncollapsed_MouseDown(object sender, MouseEventArgs e)
        {
            if (!collapsed.Visible) 
            {
                for (int _i = 250; _i >= 55; _i -= 9)
                {
                    sidemenu.Width = _i;
                    sidemenu.Update();
                }
                sidelogo.Visible ^= true;
                collapsed.Visible ^= true;
            }
        }

        private void Cart_MouseLeave(object sender, EventArgs e)
        {
            if (Cursor.Position.Y > 50)
            {
                for (int _i = sidemenu.BackColor.R; _i > 17; _i--)
                {
                    sidemenu.BackColor = Color.FromArgb(_i, _i, _i);
                    sidemenu.Update();
                }
            }
        }

        private void Cart_MouseEnter(object sender, EventArgs e)
        {
            if (collapsed.Visible)
            {
                if (Cursor.Position.X < sidemenu.Width && Cursor.Position.Y > 50)
                {
                    for (int _i = sidemenu.BackColor.R; _i < 50; _i++)
                    {
                        sidemenu.BackColor = Color.FromArgb(_i, _i, _i);
                        sidemenu.Update();
                    }
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

        private void Cart_Load(object sender, EventArgs e)
        {
            __sidemenus.Add(hometab);
            __sidemenus.Add(markettab);
            __sidemenus.Add(studiotab);
            __sidemenus.Add(exittab);

            hometab.Select();
        }

        private void S_MouseEnter(object sender, EventArgs e)
        {
            this.Update();
        }

        private void hometab_MouseHover(object sender, EventArgs e)
        {
            var _temp = sender as Panel;
            int _r, _g, _b;
            _r = _g = _b = 18;
            for (int _i = 0; _i < 170; _i+=4) 
            {
                _r = _r < 1 ? 0 : _r - 2; 
                _g = _g < 172 ? _g + 5: 171;
                _b = _b < 170 ? _b + 5 : 169;
                _temp.BackColor = Color.FromArgb(_r, _g, _b);
                _temp.Update();
                System.Threading.Thread.Sleep(10);
            }
            
        }

        private void collapsed_Click(object sender, EventArgs e)
        {

        }

        private void hometab_MouseLeave(object sender, EventArgs e)
        {
            foreach (Panel _menu in __sidemenus) _menu.BackColor = Color.FromArgb(18, 18, 18);
        }

        private void WW(object sender, EventArgs e)
        {

        }
    }
}
