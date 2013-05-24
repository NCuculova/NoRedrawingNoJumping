using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace NoRedrawingNoJumping
{
   public partial class Play : Form
    {
        public Game newGame;
        public Point previusPoint;
        public Point currentPoint;
        public int numEdges { get; set; }
        public int numEdges1 { get; set; }
  
        public Play()
        {
            InitializeComponent();
            newGame = new Game();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackgroundImage = Properties.Resources.bezime;
            numEdges = 0;
           
        }

        private void Play_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i <newGame.levels.Count; i++)
            {
                if (i == (newGame.isLoad-1)) {

                    newGame.levels[i].DrawGraph(e.Graphics, newGame.levels[i].nodes, newGame.levels[i].edges);
                    numEdges1 = newGame.levels[i].edges.Count;
                }
            }
             if (numEdges == numEdges1)
            {
                if(MessageBox.Show("Great Job"," ",MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK);
                {
                    this.Close();
                }
            }
            
            

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            foreach (Node node in newGame.levels[newGame.isLoad - 1].nodes)
            {
                node.color = Color.Black;
            }
            foreach (Edge edge in newGame.levels[newGame.isLoad - 1].edges)
            {
                edge.color = Color.Black;
            }
            previusPoint = new Point();
            numEdges = 0;
            Invalidate();
        }

        private void Play_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Node node in newGame.levels[newGame.isLoad - 1].nodes)
            {

                {
                    if (previusPoint.IsEmpty)
                    {
                        if (node.IsHit(e.X, e.Y))
                        {
                            previusPoint = node.Position;
                            node.color = Color.Pink;
                            Invalidate();
                        }

                    }
                    else
                    {
                        if (node.IsHit(e.X, e.Y))
                        {

                            currentPoint = node.Position;
                            foreach (Edge edge in newGame.levels[newGame.isLoad - 1].edges)
                            {
                                if (edge.color == Color.Black)
                                {
                                    if ((edge.Node1.Position == previusPoint && edge.Node2.Position == currentPoint) || (edge.Node2.Position == previusPoint && edge.Node1.Position == currentPoint))
                                    {
                                        node.color = Color.Pink;
                                        edge.color = Color.White;
                                        numEdges++;
                                        previusPoint = currentPoint;
                                        Invalidate();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Play_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Node node in newGame.levels[newGame.isLoad - 1].nodes)
            {
                node.color = Color.Black;
            }
            foreach (Edge edge in newGame.levels[newGame.isLoad - 1].edges)
            {
                edge.color = Color.Black;
            }
            previusPoint = new Point();
            numEdges = 0;
            Invalidate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        

       

    }
}
