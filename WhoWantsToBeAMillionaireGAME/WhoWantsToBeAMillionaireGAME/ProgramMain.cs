using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaireGAME
{
    static class ProgramMain
    {
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

        public static List<QuestionClass> Data()
        {
            var questionData = new List<QuestionClass>();

            var question1 = new QuestionClass(
                "През коя година е създаден футболен клуб Левски",
                "1914",
                new List<string> { "1914", "1911", "1919", "1916" });
            questionData.Add(question1);

            var question2 = new QuestionClass("През коя година България става член на Европейският Съюз",
                "2007",
                new List<string> {"2000", "2009", "2013", "2007"});
            questionData.Add(question2);

            return questionData;
        } 
    }
}
