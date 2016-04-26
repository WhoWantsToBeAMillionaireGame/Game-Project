namespace WhoWantsToBeAMillionaireGAME
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using WMPLib;

    #endregion

    public partial class Form2 : Form
    {
        private int count;

        WindowsMediaPlayerClass player = new WindowsMediaPlayerClass();

        private readonly List<QuestionClass> data = ProgramMain.Data();

        public Form2()
        {
            this.InitializeComponent();
            this.player.URL = "MusicMP3.mp3";
        }

        private void answerBox1_Click(object sender, EventArgs e)
        {
            this.AnswerOne();
        }

        private void answerBox2_Click(object sender, EventArgs e)
        {
            this.AnswerTwo();
        }

        private void answerBox3_Click(object sender, EventArgs e)
        {
            this.AnswerThree();
        }

        private void answerBox4_Click(object sender, EventArgs e)
        {
            this.AnswerFour();
        }

        private void AnswerFour()
        {
            var answer = this.answerLabel4.Text;
            var currectAnswer = this.data[this.count].Answer;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen4.Visible = true;
                this.answerBox4.Visible = false;
                this.answerLabel4.BackColor = Color.LawnGreen;
                this.answerLabel4.ForeColor = Color.Black;
                this.nextButton.Visible = true;
            }
            else
            {
                this.answerBox4.Visible = false;
                this.answerBoxRed4.Visible = true;
                this.answerLabel4.BackColor = Color.Red;
            }
        }

        private void answerLabel1_Click(object sender, EventArgs e)
        {
            this.AnswerOne();
        }

        private void answerLabel2_Click(object sender, EventArgs e)
        {
            this.AnswerTwo();
        }

        private void answerLabel3_Click(object sender, EventArgs e)
        {
            this.AnswerThree();
        }

        private void answerLabel4_Click(object sender, EventArgs e)
        {
            this.AnswerFour();
        }

        private void AnswerOne()
        {
            var answer = this.answerLabel1.Text;
            var currectAnswer = this.data[this.count].Answer;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen1.Visible = true;
                this.answerBox1.Visible = false;
                this.answerLabel1.BackColor = Color.LawnGreen;
                this.answerLabel1.ForeColor = Color.Black;
                this.nextButton.Visible = true;
            }
            else
            {
                this.answerBox1.Visible = false;
                this.answerBoxRed1.Visible = true;
                this.answerLabel1.BackColor = Color.Red;
            }
        }

        private void AnswerThree()
        {
            var answer = this.answerLabel3.Text;
            var currectAnswer = this.data[this.count].Answer;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen3.Visible = true;
                this.answerBox3.Visible = false;
                this.answerLabel3.BackColor = Color.LawnGreen;
                this.answerLabel3.ForeColor = Color.Black;
                this.nextButton.Visible = true;
            }
            else
            {
                this.answerBox3.Visible = false;
                this.answerBoxRed3.Visible = true;
                this.answerLabel3.BackColor = Color.Red;
            }
        }

        private void AnswerTwo()
        {
            var answer = this.answerLabel2.Text;
            var currectAnswer = this.data[this.count].Answer;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen2.Visible = true;
                this.answerBox2.Visible = false;
                this.answerLabel2.BackColor = Color.LawnGreen;
                this.answerLabel2.ForeColor = Color.Black;
                this.nextButton.Visible = true;
            }
            else
            {
                this.answerBox2.Visible = false;
                this.answerBoxRed2.Visible = true;
                this.answerLabel2.BackColor = Color.Red;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Run();
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            this.nextButton.Visible = false;

            this.answerBoxGreen1.Visible = false;
            this.answerBox1.Visible = true;
            this.answerLabel1.BackColor = Color.Transparent;
            this.answerLabel1.ForeColor = Color.White;
            this.answerBox1.BackColor = Color.Transparent;

            this.answerBoxGreen2.Visible = false;
            this.answerBox2.Visible = true;
            this.answerLabel2.BackColor = Color.Transparent;
            this.answerLabel2.ForeColor = Color.White;
            this.answerBox2.BackColor = Color.Transparent;

            this.answerBoxGreen3.Visible = false;
            this.answerBox3.Visible = true;
            this.answerLabel3.BackColor = Color.Transparent;
            this.answerLabel3.ForeColor = Color.White;
            this.answerBox3.BackColor = Color.Transparent;

            this.answerBoxGreen4.Visible = false;
            this.answerBox4.Visible = true;
            this.answerLabel4.BackColor = Color.Transparent;
            this.answerLabel4.ForeColor = Color.White;
            this.answerBox4.BackColor = Color.Transparent;

            this.Run();
        }

        private void Run()
        {
            var currentQuestion = this.data[this.count];

            this.questionLabel.MaximumSize = new Size(500, 0);
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = this.questionBox.BackColor;
            this.questionLabel.Text = currentQuestion.Question;

            if (this.questionLabel.Size.Height > this.questionBox.Size.Height)
            {
                while (this.questionLabel.Size.Height > this.questionBox.Size.Height - 8)
                {
                    var size = this.questionLabel.Font.Size;
                    size -= 2;
                    this.questionLabel.Font = new Font(currentQuestion.Question, size);
                }
            }

            this.answerLabel1.MaximumSize = new Size(200, 0);
            this.answerLabel1.AutoSize = true;
            this.answerLabel1.Text = currentQuestion.Answers[0];

            if (this.answerLabel1.Size.Height > this.answerBox1.Size.Height)
            {
                while (this.answerLabel1.Size.Height > this.answerBox1.Size.Height - 8)
                {
                    var size = this.answerLabel1.Font.Size;
                    size -= 2;
                    this.answerLabel1.Font = new Font(currentQuestion.Answers[0], size);
                }
            }

            this.answerLabel2.MaximumSize = new Size(200, 0);
            this.answerLabel2.AutoSize = true;
            this.answerLabel2.Text = currentQuestion.Answers[1];

            if (this.answerLabel2.Size.Height > this.answerBox2.Size.Height)
            {
                while (this.answerLabel2.Size.Height > this.answerBox2.Size.Height - 8)
                {
                    var size = this.answerLabel2.Font.Size;
                    size -= 2;
                    this.answerLabel2.Font = new Font(currentQuestion.Answers[1], size);
                }
            }

            this.answerLabel3.MaximumSize = new Size(200, 0);
            this.answerLabel3.AutoSize = true;
            this.answerLabel3.Text = currentQuestion.Answers[2];

            if (this.answerLabel3.Size.Height > this.answerBox3.Size.Height)
            {
                while (this.answerLabel3.Size.Height > this.answerBox3.Size.Height - 8)
                {
                    var size = this.answerLabel3.Font.Size;
                    size -= 2;
                    this.answerLabel3.Font = new Font(currentQuestion.Answers[2], size);
                }
            }

            this.answerLabel4.MaximumSize = new Size(200, 0);
            this.answerLabel4.AutoSize = true;
            this.answerLabel4.Text = currentQuestion.Answers[3];

            if (this.answerLabel4.Size.Height > this.answerBox4.Size.Height)
            {
                while (this.answerLabel4.Size.Height > this.answerBox4.Size.Height - 8)
                {
                    var size = this.answerLabel4.Font.Size;
                    size -= 2;
                    this.answerLabel4.Font = new Font(currentQuestion.Answers[3], size);
                }
            }
        }

        private void volumeOn_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = false;
            this.volumeOff.Visible = true;
            this.player.controls.pause();
        }

        private void volumeOff_Click(object sender, EventArgs e)
        {
            this.volumeOn.Visible = true;
            this.volumeOff.Visible = false;
            this.player.controls.play();
        }
    }
}