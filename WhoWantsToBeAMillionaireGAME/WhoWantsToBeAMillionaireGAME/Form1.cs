using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaireGAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.newGame2.Visible = false;
            this.score2.Visible = false;
            this.exit2.Visible = false;
            this.volumeOff.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void newGame1_MouseHover(object sender, EventArgs e)
        {
            this.newGame1.Visible = false;
            this.newGame2.Visible = true;
        }

        private void newGame2_MouseLeave(object sender, EventArgs e)
        {
            this.newGame1.Visible = true;
            this.newGame2.Visible = false;
        }

        private void score1_MouseHover(object sender, EventArgs e)
        {
            this.score1.Visible = false;
            this.score2.Visible = true;
        }

        private void score2_MouseLeave(object sender, EventArgs e)
        {
            this.score1.Visible = true;
            this.score2.Visible = false;
        }

        private void exit1_MouseHover(object sender, EventArgs e)
        {
            this.exit1.Visible = false;
            this.exit2.Visible = true;
        }

        private void exit2_MouseLeave(object sender, EventArgs e)
        {
            this.exit1.Visible = true;
            this.exit2.Visible = false;
        }

        private void volumeOn_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = false;
            this.volumeOff.Visible = true;
        }

        private void volumeOff_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = true;
            this.volumeOff.Visible = false;
        }
    }
}
