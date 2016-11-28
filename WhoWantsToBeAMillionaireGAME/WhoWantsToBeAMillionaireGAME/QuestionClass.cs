namespace WhoWantsToBeAMillionaireGAME
{
    using System.Collections.Generic;

    public class QuestionClass
    {
        public QuestionClass(string question, string answer, IList<string> answers)
        {
            this.Question = question;
            this.Answer = answer;
            this.Answers = answers;
        }

        public string Question { get; set; }

        public string Answer { get; set; }

        public IList<string> Answers { get; set; }
    }

}
