using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace smartproperty
{
    public partial class Designer : Form
    {
        int lastX, lastY;
        Bitmap bmp;
        Graphics g;
        bool mousedown;
        int mouseX, mouseY;
        int posX, posY;
        public Designer()
        {
            mousedown = false;
            mouseX = 0;
            mouseY = 0;
            lastX = lastY = 90;
            posX = posY = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(label1.Width, label1.Height);
            g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            ShowGrid(40, posX, posY);
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            bmp = new Bitmap(label1.Width, label1.Height);
            g = Graphics.FromImage(bmp);
            label1.Location = new Point(lastX - vScrollBar1.Value, lastY - vScrollBar1.Value);
            ShowGrid(vScrollBar1.Value, posX, posY);
            label1.Refresh();
        }

        public void ShowGrid(int _range, int _posX, int _posY)
        {
            bmp = new Bitmap(label1.Width, label1.Height);
            g = Graphics.FromImage(bmp);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (i == 1 && j == 1) g.DrawRectangle(new Pen(Brushes.Red, 4f), i * _range + posX, j * _range + posY, _range, _range);
                    else g.DrawRectangle(new Pen(Brushes.Black, 1f), i * _range + posX, j * _range + posY, _range, _range);
                }
            }
            label1.Image = bmp;
            g.Dispose();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) mousedown = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 200;
                posX = mouseX;
                posY = mouseY;
                ShowGrid(vScrollBar1.Value, posX, posY);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mousedown) mousedown = false;
        }
    }
}
