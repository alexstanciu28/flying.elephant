using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x=50, y=50;
        int dx=5,dy=5;
        int x2= 100, y2= 100;
        int dx2 = 10, dy2 = -10;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x + dx;
            y = y + dy;
            if (x >= this.Width - 150 || x < 0)
                dx = -dx;
            if (y >= this.Height - 150 || y < 0)
                dy = -dy;
            x2 = x2 + dx2;
            y2 = y2 + dy2;
            if (x2 >= this.Width - 150 || x2 < 0)
                dx2 = -dx2;
            if (y2 >= this.Height - 150 || y2< 0)
                dy2 = -dy2;

            this.Refresh();
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'l' && x < this.Width - 150) x += 5;
            else if (e.KeyChar == 'h' && x > 0) x -= 5;
            if (e.KeyChar == 'k' && y < this.Height - 150) y += 5;
            else if (e.KeyChar == 'j' && y > 0) y -= 5;
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap img = new Bitmap("Imagine.jpg");
            g.DrawImage(img, new Rectangle(x, y, 50, 150));
            Bitmap img2 = new Bitmap("Imagine2.png");
            g.DrawImage(img2, new Rectangle(x2, y2, 100, 200));
           

        }
    }
}
