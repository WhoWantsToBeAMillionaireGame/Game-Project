namespace WhoWantsToBeAMillionaireGAME
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Media;
    using System.Windows.Forms;

    using WhoWantsToBeACodeWizard.Models.Models;

    #endregion

    public partial class Form2 : Form
    {
        private const int CurrectAnswertoWin = 15;
        
        private static readonly Random Random = new Random();

        private readonly List<Question> Questions = ProgramMain.Data();

        private SoundPlayer player = new SoundPlayer();

        private int count = 0;

        private float startSizeQuestion = 0;

        private float startSizeAnswer = 0;

        public Form2()
        {
            this.player.SoundLocation = "../../Resources/musicMP3.wav";
            this.player.Play();
            this.InitializeComponent();
        }

        // Region for input handlers.
        #region
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

        private void newGame2_Click(object sender, EventArgs e)
        {
            //this.count = 0;
            //this.ResetAllValues();

            //this.Lose1.Visible = false;
            //this.win50.Visible = false;
            //this.win100.Visible = false;
            //this.win150.Visible = false;
            //this.win200.Visible = false;
            //this.Lose2.Visible = false;
            //this.win500.Visible = false;
            //this.win1000.Visible = false;
            //this.win1500.Visible = false;
            //this.win2000.Visible = false;
            //this.Lose3.Visible = false;
            //this.win5000.Visible = false;
            //this.win10000.Visible = false;
            //this.win25000.Visible = false;
            //this.win50000.Visible = false;
            //this.winnerBox.Visible = false;

            //this.Run();

            this.player.Stop();
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Run();
        }

        private void getYourMoney_Click(object sender, EventArgs e)
        {
            if (this.count == 0)
            {
                this.Lose1.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                return;
            }
            if (this.count == 1)
            {
                this.win50.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
                return;
            }
            if (this.count == 2)
            {
                this.win100.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
                return;
            }
            if (this.count == 3)
            {
                this.win150.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
                return;
            }
            if (this.count == 4)
            {
                this.win200.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
                return;
            }
            if (this.count == 5)
            {
                this.Lose2.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
                return;
            }
            if (this.count == 6)
            {
                this.win500.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
                return;
            }
            if (this.count == 7)
            {
                this.win1000.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
                return;
            }
            if (this.count == 8)
            {
                this.win1500.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                return;
            }
            if (this.count == 9)
            {
                this.win2000.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                return;
            }
            if (this.count == 10)
            {
                this.Lose3.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                return;
            }
            if (this.count == 11)
            {
                this.win5000.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                return;
            }
            if (this.count == 12)
            {
                this.win10000.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                return;
            }
            if (this.count == 13)
            {
                this.win25000.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                return;
            }
            if (this.count == 14)
            {
                this.win50000.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;
            }
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            this.ResetAllValues();

            this.Run();
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


        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Run()
        {
            var currentQuestion = this.Questions[this.count];
            MarkQuestionAsUsed(this.Questions[this.count]);

            this.AwardGenerator();

            startSizeQuestion = this.questionLabel.Font.Size;
            startSizeAnswer = this.answerLabel1.Font.Size;

            this.questionLabel.MaximumSize = new Size(513, 0);
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = this.questionBox.BackColor;
            this.questionLabel.Text = currentQuestion.QuestionDescription;
            var shuffledAnswers = this.Shuffle(currentQuestion.Answers);

            if (this.questionLabel.Size.Height > this.questionBox.Size.Height)
            {
                while (this.questionLabel.Size.Height > this.questionBox.Size.Height - 8)
                {
                    var size = this.questionLabel.Font.Size;
                    size -= 3;
                    this.questionLabel.Font = new Font(currentQuestion.QuestionDescription, size);
                }
            }

            this.answerLabel1.MaximumSize = new Size(177, 0);
            this.answerLabel1.AutoSize = true;
            this.answerLabel1.Text = shuffledAnswers[0].AnswerDescription;

            if (this.answerLabel1.Size.Height > this.answerBox1.Size.Height)
            {
                while (this.answerLabel1.Size.Height > this.answerBox1.Size.Height - 8)
                {
                    var size = this.answerLabel1.Font.Size;
                    size -= 3;
                    this.answerLabel1.Font = new Font(shuffledAnswers[0].AnswerDescription, size);
                }
            }

            this.answerLabel2.MaximumSize = new Size(177, 0);
            this.answerLabel2.AutoSize = true;
            this.answerLabel2.Text = shuffledAnswers[1].AnswerDescription;

            if (this.answerLabel2.Size.Height > this.answerBox2.Size.Height)
            {
                while (this.answerLabel2.Size.Height > this.answerBox2.Size.Height - 8)
                {
                    var size = this.answerLabel2.Font.Size;
                    size -= 3;
                    this.answerLabel2.Font = new Font(shuffledAnswers[1].AnswerDescription, size);
                }
            }

            this.answerLabel3.MaximumSize = new Size(177, 0);
            this.answerLabel3.AutoSize = true;
            this.answerLabel3.Text = shuffledAnswers[2].AnswerDescription;

            if (this.answerLabel3.Size.Height > this.answerBox3.Size.Height)
            {
                while (this.answerLabel3.Size.Height > this.answerBox3.Size.Height - 8)
                {
                    var size = this.answerLabel3.Font.Size;
                    size -= 3;
                    this.answerLabel3.Font = new Font(shuffledAnswers[2].AnswerDescription, size);
                }
            }

            this.answerLabel4.MaximumSize = new Size(177, 0);
            this.answerLabel4.AutoSize = true;
            this.answerLabel4.Text = shuffledAnswers[3].AnswerDescription;

            if (this.answerLabel4.Size.Height > this.answerBox4.Size.Height)
            {
                while (this.answerLabel4.Size.Height > this.answerBox4.Size.Height - 8)
                {
                    var size = this.answerLabel4.Font.Size;
                    size -= 3;
                    this.answerLabel4.Font = new Font(shuffledAnswers[3].AnswerDescription, size);
                }
            }

            MarkQuestionAsUsed(this.Questions[this.count]);
        }

        private void AnswerOne()
        {
            var answer = this.answerLabel1.Text;
            var currectAnswer = this.Questions[this.count].Answer.AnswerDescription;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen1.Visible = true;
                this.answerBox1.Visible = false;
                this.answerLabel1.BackColor = Color.LawnGreen;
                this.answerLabel1.ForeColor = Color.Black;
                this.nextButton.Visible = true;
                this.getYourMoney.Visible = false;

                if (this.count == CurrectAnswertoWin)
                {
                    this.winnerBox.Visible = true;
                    this.nextButton.Visible = false;
                    this.newGame1.Visible = true;
                }
            }
            else
            {
                this.answerBox1.Visible = false;
                this.answerBoxRed1.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                DisplayLoseState();
            }

            this.answerLabel2.Enabled = false;
            this.answerBox2.Enabled = false;
            this.answerLabel3.Enabled = false;
            this.answerBox3.Enabled = false;
            this.answerLabel4.Enabled = false;
            this.answerBox4.Enabled = false;
            this.answerLabel1.Enabled = false;
        }

        private void AnswerTwo()
        {
            var answer = this.answerLabel2.Text;
            var currectAnswer = this.Questions[this.count].Answer.AnswerDescription;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen2.Visible = true;
                this.answerBox2.Visible = false;
                this.answerLabel2.BackColor = Color.LawnGreen;
                this.answerLabel2.ForeColor = Color.Black;
                this.nextButton.Visible = true;
                this.getYourMoney.Visible = false;

                if (this.count == CurrectAnswertoWin)
                {
                    this.winnerBox.Visible = true;
                    this.nextButton.Visible = false;
                    this.newGame1.Visible = true;
                }
            }
            else
            {
                this.answerBox2.Visible = false;
                this.answerBoxRed2.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                DisplayLoseState();
            }

            this.answerLabel1.Enabled = false;
            this.answerBox1.Enabled = false;
            this.answerLabel3.Enabled = false;
            this.answerBox3.Enabled = false;
            this.answerLabel4.Enabled = false;
            this.answerBox4.Enabled = false;
            this.answerLabel2.Enabled = false;
        }

        private void AnswerThree()
        {
            var answer = this.answerLabel3.Text;
            var currectAnswer = this.Questions[this.count].Answer.AnswerDescription;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen3.Visible = true;
                this.answerBox3.Visible = false;
                this.answerLabel3.BackColor = Color.LawnGreen;
                this.answerLabel3.ForeColor = Color.Black;
                this.nextButton.Visible = true;
                this.getYourMoney.Visible = false;

                if (this.count == CurrectAnswertoWin)
                {
                    this.winnerBox.Visible = true;
                    this.nextButton.Visible = false;
                    this.newGame1.Visible = true;
                }
            }
            else
            {
                this.answerBox3.Visible = false;
                this.answerBoxRed3.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                DisplayLoseState();
            }

            this.answerLabel2.Enabled = false;
            this.answerBox2.Enabled = false;
            this.answerLabel1.Enabled = false;
            this.answerBox1.Enabled = false;
            this.answerLabel4.Enabled = false;
            this.answerBox4.Enabled = false;
            this.answerLabel3.Enabled = false;
        }

        private void AnswerFour()
        {
            var answer = this.answerLabel4.Text;
            var currectAnswer = this.Questions[this.count].Answer.AnswerDescription;
            if (answer == currectAnswer)
            {
                this.count++;
                this.answerBoxGreen4.Visible = true;
                this.answerBox4.Visible = false;
                this.answerLabel4.BackColor = Color.LawnGreen;
                this.answerLabel4.ForeColor = Color.Black;
                this.nextButton.Visible = true;
                this.getYourMoney.Visible = false;

                if (this.count == CurrectAnswertoWin)
                {
                    this.winnerBox.Visible = true;
                    this.nextButton.Visible = false;
                    this.newGame1.Visible = true;
                }
            }
            else
            {
                this.answerBox4.Visible = false;
                this.answerBoxRed4.Visible = true;
                this.getYourMoney.Visible = false;
                this.newGame1.Visible = true;

                DisplayLoseState();
            }

            this.answerLabel2.Enabled = false;
            this.answerBox2.Enabled = false;
            this.answerLabel3.Enabled = false;
            this.answerBox3.Enabled = false;
            this.answerLabel1.Enabled = false;
            this.answerBox1.Enabled = false;
            this.answerLabel4.Enabled = false;
        }

        private void AwardGenerator()
        {
            if (this.count == 0)
            {
                this.Capture1.Visible = true;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }
            if (this.count == 1)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = true;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }
            if (this.count == 2)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = true;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 3)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = true;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 4)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = true;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 5)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = true;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 6)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = true;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 7)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = true;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 8)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = true;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 9)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = true;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 10)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = true;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 11)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = true;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 12)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = true;
                this.Capture14.Visible = false;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 13)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = true;
                this.Capture15.Visible = false;
                return;
            }

            if (this.count == 14)
            {
                this.Capture1.Visible = false;
                this.Capture2.Visible = false;
                this.Capture3.Visible = false;
                this.Capture4.Visible = false;
                this.Capture5.Visible = false;
                this.Capture6.Visible = false;
                this.Capture7.Visible = false;
                this.Capture8.Visible = false;
                this.Capture9.Visible = false;
                this.Capture10.Visible = false;
                this.Capture11.Visible = false;
                this.Capture12.Visible = false;
                this.Capture13.Visible = false;
                this.Capture14.Visible = false;
                this.Capture15.Visible = true;
            }
        }

        private void EnableAnswers()
        {
            this.answerLabel1.Enabled = true;
            this.answerBox1.Enabled = true;
            this.answerLabel2.Enabled = true;
            this.answerBox2.Enabled = true;
            this.answerLabel3.Enabled = true;
            this.answerBox3.Enabled = true;
            this.answerLabel4.Enabled = true;
            this.answerBox4.Enabled = true;
        }

        private void ResetAllValues()
        {
            this.nextButton.Visible = false;
            this.getYourMoney.Visible = true;

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

            this.AwardGenerator();

            this.EnableAnswers();

            this.questionLabel.Font = new Font("test", this.startSizeQuestion);
            this.answerLabel1.Font = new Font("test", this.startSizeAnswer);
            this.answerLabel2.Font = new Font("test", this.startSizeAnswer);
            this.answerLabel3.Font = new Font("test", this.startSizeAnswer);
            this.answerLabel4.Font = new Font("test", this.startSizeAnswer);
        }

        private void DisplayLoseState()
        {
            if (this.count >= 0 && this.count < 5)
            {
                this.Lose1.Visible = true;
            }
            if (this.count >= 5 && this.count < 10)
            {
                this.Lose2.Visible = true;
            }
            if (this.count >= 10 && this.count < 15)
            {
                this.Lose3.Visible = true;
            }
        }

        private IList<Answer> Shuffle(ICollection<Answer> answers)
        {
            IList<Answer> shuffledAnswers = answers.ToList();
            for (int i = 0; i < shuffledAnswers.Count; i++)
            {
                int randomIndex = Random.Next(shuffledAnswers.Count);

                if(i != randomIndex)
                {
                    var oldValue = shuffledAnswers[i];
                    shuffledAnswers[i] = shuffledAnswers[randomIndex];
                    shuffledAnswers[randomIndex] = oldValue;
                }
            }

            return shuffledAnswers;
        }

        private void MarkQuestionAsUsed(Question question)
        {
            ProgramMain.MarkQuestionAsUsed(question);
        }
    }
}