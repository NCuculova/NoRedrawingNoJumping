using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NoRedrawingNoJumping
{
    public class Node
    {
        public Point Position { get; set; }
        public int X { get { return Position.X; } }
        public int Y { get { return Position.Y; } }
        public int radius;
        public Color color { get; set; }
        public Node(Point p) { Position = p; }
        public Node(int x, int y)
        {
            Position = new Point(x, y);
            radius = 7;
            color = Color.Black;
        }
        public void DrawNode(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.FillEllipse(br, X - radius, Y - radius, radius * 2, radius * 2);
            br.Dispose();
        }
        public bool IsHit(int x, int y)
        {
            double d = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
            return d <= radius;
        }
    }
}
