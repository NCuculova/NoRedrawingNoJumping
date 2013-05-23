using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoRedrawingNoJumping
{
   public partial class Play : Form
    {
        public Game newGame;
  
        public Play()
        {
            InitializeComponent();
            newGame = new Game();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           
        }

        private void Play_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i <newGame.levels.Count; i++)
            {
                if (i == (newGame.isLoad-1)) {

                    newGame.levels[i].DrawGraph(e.Graphics, newGame.levels[i].nodes, newGame.levels[i].edges);
                }
            }
            
            

        }

    }
}
