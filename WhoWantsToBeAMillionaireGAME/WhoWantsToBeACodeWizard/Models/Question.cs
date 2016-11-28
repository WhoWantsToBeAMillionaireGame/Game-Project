namespace WhoWantsToBeACodeWizard.Models.Models
{
    using System.Collections.Generic;

    public enum ComplexityLevel
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    };

    public class Question
    {
        public Question()
        {
        }

        public Question(string question, Answer answer, IList<Answer> answers, ComplexityLevel complexityLevel)
        {
            this.QuestionDescription = question;
            this.Answer = answer;
            this.Answers = answers;
            this.ComplexityLevel = complexityLevel;
        }

        public int Id { get; set; }

        public string QuestionDescription { get; set; }

        public Answer Answer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        public int Views { get; set; }

        public ComplexityLevel ComplexityLevel { get; set; }
    }
}
