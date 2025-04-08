using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFractal03
{
    public partial class FrmFractal03 : Form
    {
        private const int Iterations = 5;
        private readonly Color[] Colors = { Color.Red, Color.Green, Color.Blue, Color.Purple, Color.Orange, Color.Cyan };


        public FrmFractal03()
        {
            InitializeComponent();
        }

        private void FrmFractal03_Load_1(object sender, EventArgs e)
        {
            DrawKochSnowflake();
        }

        private void DrawKochSnowflake()
        {
            Bitmap bmp = new Bitmap(PictureBoxFractal3.Width, PictureBoxFractal3.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            PointF p1 = new PointF(100, 300);
            PointF p2 = new PointF(400, 300);
            PointF p3 = new PointF(250, 100);

            DrawKoch(g, p1, p2, Iterations);
            DrawKoch(g, p2, p3, Iterations);
            DrawKoch(g, p3, p1, Iterations);
            PictureBoxFractal3.Image = bmp;
        }

        private void DrawKoch(Graphics g, PointF p1, PointF p2, int iter)
        {
            if (iter == 0)
            {
                using (Pen pen = new Pen(GetGradientColor(p1), 2))
                {
                    g.DrawLine(pen, p1, p2);
                }
            }
            else
            {
                PointF pA = new PointF((2 * p1.X + p2.X) / 3, (2 * p1.Y + p2.Y) / 3);
                PointF pB = new PointF((p1.X + 2 * p2.X) / 3, (p1.Y + 2 * p2.Y) / 3);

                float dx = pB.X - pA.X;
                float dy = pB.Y - pA.Y;
                PointF pC = new PointF(
                    (float)(pA.X + dx * Math.Cos(Math.PI / 3) - dy * Math.Sin(Math.PI / 3)),
                    (float)(pA.Y + dx * Math.Sin(Math.PI / 3) + dy * Math.Cos(Math.PI / 3))
                );

                DrawKoch(g, p1, pA, iter - 1);
                DrawKoch(g, pA, pC, iter - 1);
                DrawKoch(g, pC, pB, iter - 1);
                DrawKoch(g, pB, p2, iter - 1);
            }
        }

        private Color GetGradientColor(PointF point)
        {
            int index = (int)(Math.Abs(point.X + point.Y)) % Colors.Length;
            return Colors[index];
        }
    }
}
