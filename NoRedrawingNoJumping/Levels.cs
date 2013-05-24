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
           if (play.levelClear)
           {
               btnLevel3.Enabled = true;
               MessageBox.Show("Level 3 unlocked!");
           }
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 1;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel2.Enabled = true;
                MessageBox.Show("Level 2 unlocked!");
            }
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 3;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel4.Enabled = true;
                MessageBox.Show("Level 4 unlocked!");
            }

        }

        private void btnLevel4_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 4;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel5.Enabled = true;
                MessageBox.Show("Level 5 unlocked!");
            }
        }

        private void btnLevel5_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 5;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel6.Enabled = true;
                MessageBox.Show("Level 6 unlocked!");
            }
        }

        private void btnLevel6_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 6;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel7.Enabled = true;
                MessageBox.Show("Level 7 unlocked!");
            }
        }

        private void btnLevel7_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 7;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel8.Enabled = true;
                MessageBox.Show("Level 8 unlocked!");
            }
        }

        private void btnLevel8_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 8;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel9.Enabled = true;
                MessageBox.Show("Level 9 unlocked!");
            }
        }

        private void btnLevel9_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 9;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel10.Enabled = true;
                MessageBox.Show("Level 10 unlocked!");
            }
        }

        private void btnLevel10_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 10;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel11.Enabled = true;
                MessageBox.Show("Level 11 unlocked!");
            }
        }

        private void btnLevel11_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 11;
            play.ShowDialog();
            if (play.levelClear)
            {
                btnLevel12.Enabled = true;
                MessageBox.Show("Level 12 unlocked!");
            }
        }

        private void btnLevel12_Click(object sender, EventArgs e)
        {
            play.newGame.isLoad = 12;
            play.ShowDialog();
            if (play.levelClear)
            {
                MessageBox.Show("YOU ARE AWESOME!");
            }
        }

        

       
       

         

        

       

      

        
        
    }
}
