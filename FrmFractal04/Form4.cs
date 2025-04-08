using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFractal04
{
    public partial class Form4: Form
    {
        private const int Iterations = 300;
        private const double Zoom = 1.5;
        private const double MoveX = 0;
        private const double MoveY = 0;
        private readonly Complex C = new Complex(-0.7, 0.27015);

        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawJuliaSet();
        }

        private void DrawJuliaSet()
        {
            int width = PictureBoxMandelbrot4.Width;
            int height = PictureBoxMandelbrot4.Height;
            Bitmap bmp = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double zx = 1.5 * (x - width / 2) / (0.5 * Zoom * width) + MoveX;
                    double zy = (y - height / 2) / (0.5 * Zoom * height) + MoveY;
                    int i = Iterations;

                    while (zx * zx + zy * zy < 4 && i > 0)
                    {
                        double temp = zx * zx - zy * zy + C.Real;
                        zy = 2.0 * zx * zy + C.Imaginary;
                        zx = temp;
                        i--;
                    }

                    int color = (int)(255 * i / Iterations);
                    bmp.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }
            PictureBoxMandelbrot4.Image = bmp;
            PictureBoxMandelbrot4.Refresh();
        }
    }

    public struct Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
    }
}
