namespace WhoWantsToBeAMillionaireGAME
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Threading;

    #endregion

    public partial class Form2 : Form
    {
        private int count = 0;
        private List<QuestionClass> data = ProgramMain.Data();
        public Form2()
        {
            this.InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Run();
        }

        private void answerLabel1_Click(object sender, EventArgs e)
        {
            var answer = this.answerLabel1.Text;
            var currectAnswer = this.data[this.count].Answer;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBox1.BackColor = Color.LimeGreen;
                this.answerLabel1.BackColor = Color.LimeGreen;
                this.nextButton.Visible = true;
            }
            else
            {
                this.answerBox1.BackColor = Color.Red;
                this.answerLabel1.BackColor = Color.Red;
            }
        }

        public void Run()
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
            this.answerLabel1.BackColor = this.answerBox1.BackColor;
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

            this.answerLabel3.MaximumSize = new Size(200, 0);
            this.answerLabel3.BackColor = this.answerBox2.BackColor;
            this.answerLabel3.AutoSize = true;
            this.answerLabel3.Text = currentQuestion.Answers[1];

            if (this.answerLabel3.Size.Height > this.answerBox2.Size.Height)
            {
                while (this.answerLabel3.Size.Height > this.answerBox2.Size.Height - 8)
                {
                    var size = this.answerLabel3.Font.Size;
                    size -= 2;
                    this.answerLabel3.Font = new Font(currentQuestion.Answers[1], size);
                }
            }

            this.answerLabel2.MaximumSize = new Size(200, 0);
            this.answerLabel2.BackColor = this.answerBox3.BackColor;
            this.answerLabel2.AutoSize = true;
            this.answerLabel2.Text = currentQuestion.Answers[2];

            if (this.answerLabel2.Size.Height > this.answerBox3.Size.Height)
            {
                while (this.answerLabel2.Size.Height > this.answerBox3.Size.Height - 8)
                {
                    var size = this.answerLabel2.Font.Size;
                    size -= 2;
                    this.answerLabel2.Font = new Font(currentQuestion.Answers[2], size);
                }
            }

            this.answerLabel4.MaximumSize = new Size(200, 0);
            this.answerLabel4.BackColor = this.answerBox4.BackColor;
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.nextButton.Visible = false;
            this.answerBox1.BackColor = Color.White;
            this.Run();
        }
    }
}