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
        public Node(Point p) { Position = p; }
        public Node(int x, int y)
        {
            Position = new Point(x, y);
            radius = 5;
        }
        public void DrawNode(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.Black);
            g.FillEllipse(br, X - radius, Y - radius, radius * 2, radius * 2);
            br.Dispose();
        }
    }
}
