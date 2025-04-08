using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFractal02
{
    public partial class FrmFractal2 : Form
    {
        private const int Iterations = 300;
        private const double Zoom = 1.5;
        private const double MoveX = -0.5;
        private const double MoveY = -0.5;
        public FrmFractal2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawBurningShipSet();
        }

        private void DrawBurningShipSet()
        {
            int width = PictureBoxFractal002.Width;
            int height = PictureBoxFractal002.Height;
            Bitmap bmp = new Bitmap(width, height);
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        double zx = 0, zy = 0;
                        double cx = 1.5 * (x - width / 2) / (0.5 * Zoom * width) + MoveX;
                        double cy = (y - height / 2) / (0.5 * Zoom * height) + MoveY;
                        int i = Iterations;

                        while (zx * zx + zy * zy < 4 && i > 0)
                        {
                            double temp = zx * zx - zy * zy + cx;
                            zy = Math.Abs(2.0 * zx * zy) + cy;
                            zx = Math.Abs(temp);
                            i--;
                        }
                        int r = (i * 9) % 256;
                        int g = (i * 7) % 256;
                        int b = (i * 5) % 256;
                        bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                PictureBoxFractal002.Image = bmp;
                PictureBoxFractal002.Refresh();
            }
        }
    }
}


   