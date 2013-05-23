using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;
using NoRedrawingNoJumping.Properties;


namespace NoRedrawingNoJumping
{
    public partial class Start : Form
    {
        SoundPlayer Sound1;
        SoundPlayer Sound2;
        SoundPlayer Sound3;
        SoundPlayer Sound4;
       
        public Start()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = Properties.Resources.prva;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Sound2 = new SoundPlayer(Properties.Resources.song1);
            Sound2.Play();
            Sound3 = new SoundPlayer(Properties.Resources.Windows_Logoff_Sound);
            Sound1 = new SoundPlayer(Properties.Resources.Windows_Logon_Sound);
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Levels nov = new Levels(this);
            nov.Visible = true;
           Sound1.Play();
            Sound4 = new SoundPlayer(Properties.Resources.song2);
            Sound4.Play();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Sound3.Play();
            timer1.Interval = 800;
            if (MessageBox.Show("Are you sure that you want to leave this game?", " Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                timer1.Enabled = true;
            }
            else 
            {
                Sound2.Play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) {
                Sound2.Play();
            }
        }
        
       

       

        
        }
        

    }

