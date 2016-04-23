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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var question1 = new QuestionClass(
                "През коя година е създаден футболен клуб Левски Стани богат” 2013 TV Game Show Director (режисьор): Stanislav Hristov",
                "1914 ",
                new List<string> { "1900", "1911", "1914", "1916" });

            this.question.MaximumSize = new Size(500, 0);
            this.question.AutoSize = true;
            this.question.BackColor = this.pictureBox1.BackColor;
            this.question.Text = question1.Question;

            if (this.question.Size.Height > this.pictureBox1.Size.Height)
            {
                while (this.question.Size.Height > this.pictureBox1.Size.Height - 8)
                {
                    var size = this.question.Font.Size;
                    size -= 2;
                    this.question.Font = new Font(question1.Question, size);
                }
            }

            this.label1.MaximumSize = new Size(200, 0);
            this.label1.AutoSize = true;
            this.label1.Text = question1.Answers[0];

            this.label2.MaximumSize = new Size(200, 0);
            this.label2.AutoSize = true;
            this.label2.Text = question1.Answers[1];

            this.label3.MaximumSize = new Size(200, 0);
            this.label3.AutoSize = true;
            this.label3.Text = question1.Answers[2];

            this.label4.MaximumSize = new Size(200, 0);
            this.label4.AutoSize = true;
            this.label4.Text = question1.Answers[3];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
