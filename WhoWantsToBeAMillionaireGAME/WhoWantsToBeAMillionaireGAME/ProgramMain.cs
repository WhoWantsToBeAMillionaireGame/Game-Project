namespace WhoWantsToBeAMillionaireGAME
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using WhoWantsToBeACodeWizard.Data;
    using WhoWantsToBeACodeWizard.Models.Models;

    static class ProgramMain
    {
        private static ApplicationDbContext context = new ApplicationDbContext();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static List<Question> Data()
        {
            var questions = context.Questions.GroupBy(q => q.ComplexityLevel).ToList().Select(gr => gr.OrderBy(q=> q.Views).FirstOrDefault()).ToList();

            if(questions.Any(q => q == null))
            {
                throw new ArgumentException("There are no questions for that type");
            }

            return questions;
        }

        public static void MarkQuestionAsViewed(Question question)
        {
            question.Views++;
            context.SaveChanges();
        }
    }
}
