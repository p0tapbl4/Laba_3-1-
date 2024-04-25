using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Laba_3_1_
{
    using System.Drawing.Drawing2D;

    public partial class qustion2Form : Form
    {
        private static PointF SegmentSegment(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            // Координаты направления 1 вектора
            double v = x2 - x1;
            double w = y2 - y1;

            // Координаты направления 2 вектора
            double v2 = x4 - x3;
            double w2 = y4 - y3;

            // ===== Частные случаи не пересечения =====

            // Отрезки должны быть определены
            if (v == 0 && w == 0 && v2 == 0 && w2 == 0)
            {
                Console.WriteLine("Отрезки неопределенны");
                return PointF.Empty;
            }
            if (v == 0 && w == 0 || v2 == 0 && w2 == 0)
            {
                Console.WriteLine("Один из отрезков неопределён");
                return PointF.Empty;
            }

            // Для вычисления параллельности отрезка
            // необходимо сравнить направления их векторов.

            // Вычисляем длины векторов
            double len1 = Math.Sqrt(v * v + w * w);
            double len2 = Math.Sqrt(v2 * v2 + w2 * w2);

            // Нормализация векторов - создание единичного вектора направления
            double Xvec = v / len1;
            double Yvec = w / len1;
            double Xvec2 = v2 / len2;
            double Yvec2 = w2 / len2;

            // Точность совпадения величин double
            double epsilon = 0.000001;

            // Проверка на совпадение
            if (x1 == x3 && y1 == x3 && x2 == x4 && y2 == y4)
            {
                Console.WriteLine("Отрезки совпадают");
                return PointF.Empty;
            }

            // Проверка на параллельность с определенной точностью.
            if (Math.Abs(Xvec - Xvec2) < epsilon && Math.Abs(Yvec - Yvec2) < epsilon)
            {
                Console.WriteLine("отрезки параллельны");
                return PointF.Empty;
            }

            double t2 = (-w * x3 + w * x1 + v * y3 - v * y1) / (w * v2 - v * w2);

            double t = (x3 - x1 + v2 * t2) / v;

            // Если один из параметров меньше 0 и больше 1, значит пересечения нет.
            if (t < 0 || t > 1 || t2 < 0 || t2 > 1)
            {
                Console.WriteLine("Пересечения нет");
                return PointF.Empty;
            }

            // Координаты точки пересечения
            double CrossX = x3 + v2 * t2;
            double CrossY = y3 + w2 * t2;

            //Console.WriteLine($"{CrossX.ToString()},  {CrossY.ToString()}");
            return new PointF((float)CrossX, (float)CrossY);
        }

        private Graphics g;

        public qustion2Form()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        /// <summary>
        /// Отрисовывает граф и точку на плоскости
        /// </summary>
        /// <param name="edges">Множество пар точек задающих ребра</param>
        /// <param name="points">Множество точек графа</param>
        /// <param name="A">Точка</param>
        public void draw(List<Edge> edges, PointF[] points, PointF A)
        {
            Pen edPen = new Pen(Color.Black, 3);
            Brush poBrush = new SolidBrush(Color.Red);
            foreach (var edge in edges)
                g.DrawLine(edPen, points[edge.s], points[edge.e]);
            foreach (var point in points)
                g.FillEllipse(poBrush, point.X - 5, point.Y - 5, 10, 10);
            g.FillEllipse(poBrush, A.X - 5, A.Y - 5, 10, 10);
        }

        public List<PointF[]> create(PointF[] points)
        {
            List<PointF[]> a = new List<PointF[]>();
            Pen dashPen = new Pen(Color.Gray, 3);
            dashPen.DashStyle = DashStyle.Dash;
            foreach (var point in points)
            {
                PointF[] b = { new PointF(150, point.Y), new PointF(1300, point.Y) };
                a.Add(b);
                g.DrawLine(dashPen, b[0], b[1]);
            }
            return a;
        }

        /// <summary>
        /// Сортирует множество в порядке возрастания
        /// </summary>
        /// <param name="a">Множество горизонтальных прямых не отсортированное</param>
        /// <returns></returns>
        public List<PointF[]> sortY(List<PointF[]> a)
        {
            List<PointF[]> b = new List<PointF[]>();

            b.Add(a[0]);
            bool flag = false;
            for (int i = 1; i < a.Count; i++)
            {
                flag = false;
                for (int j = 0; j < b.Count; j++)
                {
                    if (a[i][0].Y < b[j][0].Y)
                    {
                        b.Insert(j, a[i]);
                        flag = true;
                        break;
                    }

                    if (a[i][0].Y == b[j][0].Y)
                    {
                        flag = true; break;
                    }
                }
                if (!flag)
                    b.Add(a[i]);
            }
            return b;
        }

        /// <summary>
        /// Ищет коридор в котором находиться точка
        /// </summary>
        /// <param name="edges">Множество горизонтальных прямых отсортированных по возрастанию</param>
        /// <param name="A">Точка</param>
        /// <returns></returns>
        public List<PointF[]> find(List<PointF[]> edges, PointF A)
        {
            List<PointF[]> a = new List<PointF[]>();

            for (int i = 0; i < edges.Count; i++)
            {
                if (A.Y < edges[i][0].Y)
                {
                    a.Add(edges[i - 1]);
                    a.Add(edges[i]);
                    break;
                }
            }
            return a;
        }

        /// <summary>
        /// Поиск трапеции в которой находиться точка
        /// </summary>
        /// <param name="edges">Множество пар точек задающее ребра графа</param>
        /// <param name="finder">Пара горизонтальных прямых между которыми лежит точка</param>
        /// <param name="points">Множество вершин графа</param>
        /// <param name="A">Точка</param>
        /// <returns></returns>
        public List<PointF> ansver(List<Edge> edges, List<PointF[]> finder, PointF[] points, PointF A)
        {
            ///<param name="sortedX">Множество ппрямых пересекающих найденную полосу </param>>
            List<Edge> sortedX = new List<Edge>();
            bool flag;
            ///<summary>Нахождение пересечения и сортировка прямых</summary>
            foreach (var edge in edges)
            {
                if (Math.Min(points[edge.s].Y, points[edge.e].Y) <= finder[0][0].Y
                    & Math.Max(points[edge.s].Y, points[edge.e].Y) >= finder[1][0].Y)
                {
                    if (sortedX.Count == 0)
                        sortedX.Add(edge);
                    else
                    {
                        flag = false;
                        for (int i = 0; i < sortedX.Count; i++)
                        {
                            if (Math.Min(points[edge.s].X, points[edge.e].X) < 
                                Math.Min(points[sortedX[i].s].X, points[sortedX[i].e].X))
                            {
                                sortedX.Insert(i, edge);
                                flag = true;
                                break;
                            }
                            if (Math.Min(points[edge.s].X, points[edge.e].X) == 
                                Math.Min(points[sortedX[i].s].X, points[sortedX[i].e].X))
                            {
                                if (Math.Max(points[edge.s].X, points[edge.e].X) < 
                                    Math.Max(points[sortedX[i].s].X, points[sortedX[i].e].X))
                                {
                                    sortedX.Insert(i, edge);
                                    flag = true;
                                    break;
                                }
                                if (sortedX.Count > i + 1)
                                {
                                    sortedX.Insert(i, edge);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                        if (!flag)
                            sortedX.Add(edge);
                    }
                }
            }
            ///<param name="ans">Пара прямых ограничивающих трапецию слева и справа</param>
            List<Edge> ans = new List<Edge>();
            for (int i = 0; i < sortedX.Count; i++)
            {
                if (A.X < Math.Min(points[sortedX[i].s].X, points[sortedX[i].e].X))
                {
                    ans.Add(sortedX[i - 1]);
                    ans.Add(sortedX[i]);
                    break;
                }
            }

            ///<param name="a,b,c,d">Точки определяющие угла трапеции</param>
            PointF a, b, c, d;
            a = SegmentSegment(
                finder[0][0].X,
                finder[0][0].Y,
                finder[0][1].X,
                finder[0][1].Y,
                points[ans[0].s].X,
                points[ans[0].s].Y,
                points[ans[0].e].X,
                points[ans[0].e].Y);
            b = SegmentSegment(
                finder[0][0].X,
                finder[0][0].Y,
                finder[0][1].X,
                finder[0][1].Y,
                points[ans[1].s].X,
                points[ans[1].s].Y,
                points[ans[1].e].X,
                points[ans[1].e].Y);
            c = SegmentSegment(
                finder[1][0].X,
                finder[1][0].Y,
                finder[1][1].X,
                finder[1][1].Y,
                points[ans[1].s].X,
                points[ans[1].s].Y,
                points[ans[1].e].X,
                points[ans[1].e].Y);
            d = SegmentSegment(
                finder[1][0].X,
                finder[1][0].Y,
                finder[1][1].X,
                finder[1][1].Y,
                points[ans[0].s].X,
                points[ans[0].s].Y,
                points[ans[0].e].X,
                points[ans[0].e].Y);
            return new List<PointF>() { a, b, c, d };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF[] points;
            PointF A;
            List<Edge> edges = new List<Edge>();
            using (TextReader reader = File.OpenText("test.txt"))
            {
                string[] text = reader.ReadLine().Split(' ');
                A = new PointF(int.Parse(text[0]), int.Parse(text[0]));
                int n = int.Parse(reader.ReadLine());
                points = new PointF[n];
                for (int i = 0; i < n; i++)
                {
                    text = reader.ReadLine().Split(' ');
                    points[i] = new PointF(float.Parse(text[0]), float.Parse(text[1]));
                }
                n = int.Parse(reader.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    text = reader.ReadLine().Split(' ');
                    edges.Add(new Edge(int.Parse(text[0]), int.Parse(text[1])));
                }
            }
            draw(edges, points, A);
            List<PointF[]> dashLine = create(points);
            dashLine = sortY(dashLine);
            List<PointF[]> finder = find(dashLine, A);
            List<PointF> result = ansver(edges, finder, points, A);
            g.DrawLine(new Pen(Color.Green, 3), result[0], result[1]);
            g.DrawLine(new Pen(Color.Green, 3), result[2], result[1]);
            g.DrawLine(new Pen(Color.Green, 3), result[2], result[3]);
            g.DrawLine(new Pen(Color.Green, 3), result[0], result[3]);
            this.label1.Text = $"({result[0].X};{result[0].Y})";
            this.label2.Text = $"({result[1].X};{result[1].Y})";
            this.label3.Text = $"({result[2].X};{result[2].Y})";
            this.label4.Text = $"({result[3].X};{result[3].Y})";
        }
    }
}