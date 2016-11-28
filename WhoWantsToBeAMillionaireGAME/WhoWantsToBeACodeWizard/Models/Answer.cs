using System.ComponentModel.DataAnnotations.Schema;

namespace WhoWantsToBeACodeWizard.Models.Models
{
    public class Answer
    {
        public Answer()
        {
        }

        public Answer(string answerDescription)
        {
            this.AnswerDescription = answerDescription;
        }
        
        public int Id { get; set; }

        public string AnswerDescription { get; set; }

        [InverseProperty("Answer")]
        public Question Question { get; set; }

        [InverseProperty("Answers")]
        public Question RelatedQuestion { get; set; }
    }
}
