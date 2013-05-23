using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NoRedrawingNoJumping.Properties;
using System.Media;

namespace NoRedrawingNoJumping
{
    public partial class Levels : Form
    {
        Form forma;
        SoundPlayer Sound4;
        Play play;
        
        public Levels(Form f)
        {
            InitializeComponent();
            Sound4 = new SoundPlayer(Properties.Resources.song2);
            Sound4.Play();
            pictureBox1.BackgroundImage = Properties.Resources.vtora; 
            forma = f;
            play = new Play();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Visible = true;
            if (this.Visible)
            {
                Sound4.Play();
            }
           
        }

        private void Levels_FormClosed(object sender, FormClosedEventArgs e)
        {
            forma.Visible = true;
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            forma.Visible = true;
            this.Close();
        }

        private void Levels_VisibleChanged(object sender, EventArgs e)
        {
            this.Visible = true;
            if (this.Visible)
            {
                Sound4.Play();
            }
            
        }
        private void btnLevel2_Click(object sender, EventArgs e)
        {
           play.newGame.isLoad = 2;
           play.ShowDialog();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 1;
            play.ShowDialog();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 3;
            play.ShowDialog();

        }

        private void btnLevel4_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 4;
            play.ShowDialog();
        }

        private void btnLevel5_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 5;
            play.ShowDialog();
        }

        private void btnLevel6_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 6;
            play.ShowDialog();
        }

        private void btnLevel7_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 7;
            play.ShowDialog();
        }

        private void btnLevel8_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 8;
            play.ShowDialog();
        }

        private void btnLevel9_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 9;
            play.ShowDialog();
        }

        private void btnLevel10_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 10;
            play.ShowDialog();
        }

        private void btnLevel11_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 11;
            play.ShowDialog();
        }

        private void btnLevel12_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 12;
            play.ShowDialog();
        }

        

       
       

         

        

       

      

        
        
    }
}
