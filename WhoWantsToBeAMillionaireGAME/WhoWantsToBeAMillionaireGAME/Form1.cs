namespace WhoWantsToBeAMillionaireGAME
{
    #region

    using System;
    using System.Windows.Forms;

    using WMPLib;

    #endregion

    public partial class Form1 : Form
    {
        readonly WindowsMediaPlayer player = new WindowsMediaPlayerClass();

        public Form1()
        {
            this.InitializeComponent();
            this.player.URL = "musicMP3.mp3";
            this.player.controls.play();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.newGame2.Visible = false;
            this.score2.Visible = false;
            this.exit2.Visible = false;
            this.volumeOff.Visible = false;
        }

        private void newGame1_MouseHover(object sender, EventArgs e)
        {
            this.newGame1.Visible = false;
            this.newGame2.Visible = true;
        }

        private void newGame2_Click(object sender, EventArgs e)
        {
            this.player.controls.stop();
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void newGame2_MouseLeave(object sender, EventArgs e)
        {
            this.newGame1.Visible = true;
            this.newGame2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
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

        private void volumeOff_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = true;
            this.volumeOff.Visible = false;
            this.player.controls.play();
        }

        private void volumeOn_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = false;
            this.volumeOff.Visible = true;
            this.player.controls.pause();
        }
    }
}