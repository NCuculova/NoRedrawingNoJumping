using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NoRedrawingNoJumping
{
   public  class Graph
    {
        public List<Node> nodes;
        public List<Edge> edges;
        public int numNodes { get; set; }
        public Graph()
        {
        }
        public Graph(List<Edge> lstEdges, int n, List<Node> lstNodes)
        {
            edges = lstEdges;
            numNodes = n;
            nodes = lstNodes;
        }
       
        public void DrawGraph(Graphics g, List<Node> lst, List<Edge> lste)
        {
            foreach (Node n in lst)
            {
                n.DrawNode(g);
            }
            foreach (Edge e in lste)
            {
                e.DrawEdge(g);
            }
        }
    }
}
