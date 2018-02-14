using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
//ethan elliott - februrary 8th


namespace Arcade_Game
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            countdown.Visible = false;
            button1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //create graphic objects
            Graphics Form1 = CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Pen drawPen = new Pen(Color.Red, 10);
            //sound
            SoundPlayer beep = new SoundPlayer(Properties.Resources.Beep);
            SoundPlayer pacman = new SoundPlayer(Properties.Resources.Pacman);

            //changes background
            button1.Visible = false;
            beep.Play();
            Thread.Sleep(1500);
            BackColor = Color.White;
            Thread.Sleep(250);

            //countdown
            countdown.Visible = true;
            beep.Play();
            Refresh();
            Thread.Sleep(1000);

            countdown.Text = "Game Starting in: 2";
            beep.Play();
            Refresh();
            Thread.Sleep(1000);

            countdown.Text = "Game Starting in: 1";
            beep.Play();
            Refresh();
            Thread.Sleep(1000);
            //
            countdown.Visible = false;
            Form1.DrawEllipse(drawPen, 25, 25, 200, 100);
            Form1.FillEllipse(drawBrush, 25, 25, 200, 100);
            //Refresh();
            pacman.Play();
           // Refresh();
        }


    }
}
