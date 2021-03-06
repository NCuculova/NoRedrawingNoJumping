﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NoRedrawingNoJumping
{
    public class Edge
    {
        public Node Node1 { get; set; }
        public Node Node2 { get; set; }
        public Color color { get; set; }
        public Edge(Node n1, Node n2)
        {
            Node1 = n1;
            Node2 = n2;
            color = Color.Black;
        }
        public void DrawEdge(Graphics g)
        {
            Pen pen = new Pen(color, 3);
            g.DrawLine(pen, Node1.Position, Node2.Position);
            pen.Dispose();

        }
    }
}
