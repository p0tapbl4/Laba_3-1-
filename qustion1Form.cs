using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba_3_1_
{
    public partial class qustion1Form : Form
    {
        public qustion1Form()
        {
            InitializeComponent();
        }

        private Polygon polygon;

        private List<Point> points;

        private void apply_Click(object sender, EventArgs e)
        {
            Main();

            List<PointF> CountPointsInsideRectangle(List<Point> points, Polygon polygon)
            {
                double Ax = polygon.X, Bx = polygon.X, Cx = polygon.X + polygon.width, Dx = polygon.X + polygon.width;
                double Ay = polygon.Y, By = polygon.Y + polygon.height, Cy = polygon.Y + polygon.height, Dy = polygon.Y;

                List<PointF> p = new List<PointF>();
                foreach (var point in points)
                    if (Ax <= point.x && point.x <= Dx && Ay <= point.y && point.y <= By)
                    {
                        p.Add(new PointF((float)point.x, (float)point.y));
                    }

                return p;
            }

            void Main()
            {
                Random rnd = new Random();
                /*List<Point>*/
                points = new List<Point>();
                for (int i = 0; i < this.Ninsert.Value; i++)
                    points.Add(
                        new Point(
                            Math.Round(rnd.NextDouble() * (1000 - (-1000)) - 1000, 5),
                            Math.Round(rnd.NextDouble() * (1000 - (-1000)) - 1000, 5)));

                polygon = new Polygon(int.Parse(x.Text), int.Parse(y.Text), int.Parse(width.Text), int.Parse(height.Text));
                List<PointF> p = CountPointsInsideRectangle(points, polygon);
                label5.Text = p.Count.ToString();

                Graphics g = this.CreateGraphics();
                g.Clear(BackColor);
                g.DrawRectangle(new Pen(Color.Blue, 3), new Rectangle(this.polygon.X + 570, this.polygon.Y + 50, this.polygon.width, this.polygon.height));
                foreach (var point in p)
                {
                    g.DrawEllipse(new Pen(Color.Red, 3), point.X + 570, point.Y + 50, 1, 1);
                }
            }
        }
    }
}