namespace Laba_3_1_
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point(double X, double Y)
        {
            this.x = X; this.y = Y;
        }

        public Point()
        {
            this.x = 0; this.y = 0;
        }
    }

    public class Edge
    {
        public int s { get; set; }
        public int e { get; set; }

        public Edge(int S, int E)
        {
            this.s = S; this.e = E;
        }
    }
}