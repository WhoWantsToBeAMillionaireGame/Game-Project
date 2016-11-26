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
        private static ApplicationDbContext dbContext = new ApplicationDbContext();

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
            List<Question> questions = dbContext.Questions.ToList();

            return questions;
        }

        public static void MarkQuestionAsUsed(Question question)
        {
            question.IsUsed = true;
            dbContext.SaveChanges();
        }
    }
}
