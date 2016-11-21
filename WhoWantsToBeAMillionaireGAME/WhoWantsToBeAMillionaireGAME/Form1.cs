namespace WhoWantsToBeAMillionaireGAME
{
    #region

    using System;
    using System.Media;
    using System.Windows.Forms;

    #endregion

    public partial class Form1 : Form
    {
        private SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            this.player.SoundLocation = "../../Resources/musicMP3.wav";
            this.player.Play();
            this.InitializeComponent();
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
            this.player.Stop();
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

       private void volumeOff_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = true;
            this.volumeOff.Visible = false;
            this.player.Play();
        }

        private void volumeOn_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = false;
            this.volumeOff.Visible = true;
            this.player.Stop();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}