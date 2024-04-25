namespace Laba_3_1_
{
    public class Polygon
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public Polygon(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            width = w;
            height = h;
        }
    }
}