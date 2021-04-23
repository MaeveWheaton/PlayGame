using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //sounds setup
            SoundPlayer playSound = new SoundPlayer(Properties.Resources.arcade_heal);
            SoundPlayer countdownSound = new SoundPlayer(Properties.Resources.start_countdown);
            SoundPlayer gameSound = new SoundPlayer(Properties.Resources.laserattack);

            //play sound, remove start button 
            playSound.Play();
            Thread.Sleep(1500);
            playButton.Visible = false;

            //display changes and pause
            Refresh();
            Thread.Sleep(1000);

            //countdown beep, begin countdown at 3
            countdownSound.Play();
            countdownLabel.Text = $"Game starts in: 3";
            Refresh();            
            
            //1 sec pause           
            Thread.Sleep(1000);

            //countdown beep, count change to 2
            countdownSound.Play();
            countdownLabel.Text = $"Game starts in: 2";
            Refresh();           

            //1 sec pause           
            Thread.Sleep(1000);

            //countdown beep, count change to 1
            countdownSound.Play();
            countdownLabel.Text = $"Game starts in: 1";
            Refresh();            

            //1 sec pause           
            Thread.Sleep(1000);

            //play game sound 
            gameSound.Play();

            //change bg and font colours
            this.BackColor = Color.Black;
            countdownLabel.BackColor = Color.Black;
            countdownLabel.ForeColor = Color.White;

            //display "Go"
            countdownLabel.Text = "GO";
            Refresh();            
        }
    }
}
