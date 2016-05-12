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

            var question50 = new QuestionClass(
                "Как трябва да се тълкува преносният смисъл на израза \"Водещият е поставен натясно\"?",
                "Водещият е затруднен",
                new List<string> { "Водещият е затруднен", "Сакото му е малък размер", "Живее в боксониера", "Столът му е тесен" });
            questionData.Add(question50);

            var question100 = new QuestionClass(
                "Koй от въпросите е най-вероятно да се чуе от устата на едно малко дете?",
                "Откъде идват бебетата?",
                new List<string> {"Колко е косинус от 30?", "Откъде идват бебетата?", "Единица или хикс?", "Изстуди ли се бирата?"});
            questionData.Add(question100);

            var question150 = new QuestionClass(
                "За какво ще бъде дадена информация, ако по радио \"Хоризонт\" обявят включването на майор Красимир Костов?",
                "Пътната обстановка",
                new List<string> { "Нивото на река Дунав", "Числата от тотото", "Пътната обстановка", "Кого убиват в \"Под прикритие\"" });
            questionData.Add(question150);

            var question200 = new QuestionClass(
                "Ако Галена има нечетен брой дини и даде една диня на Слави и една на Годжи, колко ще й останат?",
                "Нечетен брой дини",
                new List<string> { "Точно два чифта дини", "Четен брой дини", "Не може да се каже", "Нечетен брой дини" });
            questionData.Add(question200);

            var question250 = new QuestionClass(
                "\"Шише със уши на шосе се суши\" е пример за:",
                "Скоропоговорка",
                new List<string> { "Гатанка", "Пословица", "Скоропоговорка", "Приказка" });
            questionData.Add(question250);

            var question500 = new QuestionClass(
                "Какви са помежду си тримата мускетари от едноименния роман на Александър Дюма-баща?",
                "Приятели",
                new List<string> { "Баджанаци", "Братя", "Състуденти", "Приятели" });
            questionData.Add(question500);

            var question1000 = new QuestionClass(
                "Кой е единственият уред в леката атлетика, които се хвърля с две ръце?",
                "Чук",
                new List<string> { "Диск", "Копие", "Гюле", "Чук" });
            questionData.Add(question1000);

            var question1500 = new QuestionClass(
                "Какво прави британският принц Хари на част от папарашките снимки, предизвикали огромен скандал в Англия?",
                "Играе билярд гол",
                new List<string> { "Пуши марихуана", "Играе билярд гол", "Измъчва военнопленник", "Заглежда Пипа Мидълтън" });
            questionData.Add(question1500);

            var question2000 = new QuestionClass(
                "Жителите на кой град трябва да прескачат най-много граници, за да стигнат до брега на Средиземно море?",
                "Прага",
                new List<string> { "Прага", "Берлин", "Виена", "Цюрих" });
            questionData.Add(question2000);

            var question2500 = new QuestionClass(
                "През коя година е създаден испанският футболен клуб Реал Мадрид",
                "1902",
                new List<string> { "1888", "1911", "1902", "1923" });
            questionData.Add(question2500);

            var question5000 = new QuestionClass(
                "В коя песен, вследсвие на пътна преумора, един шофьор попада в сюрреалистична обстановка?",
                "Хотел Калифорния",
                new List<string> { "Хей, Джудж", "Мисис Робинсън", "Хотел Калифорния", "Руут 66" });
            questionData.Add(question5000);

            var question10000 = new QuestionClass(
                "Кой гангстер сътрудничи с правителството на САЩ през ВСВ в замяна на предсрочно излизане от затвора?",
                "Лъки Лучано",
                new List<string> { "Ал Капоне", "Дъч Шулц", "Лъки Лучано", "Арнолд Ротстийн" });
            questionData.Add(question10000);

            var question25000 = new QuestionClass(
                "Къде се намира най-дългата писта за излитане и кацане на гражданско летище - 5500 метра?",
                "В Тибет",
                new List<string> { "В Тибет", "В Бразилия", "В Южна Африка", "В Катар" });
            questionData.Add(question25000);

            var question50000 = new QuestionClass(
                "Какво име прие за един ден руският град Волгоград на 2 февруари тази година?",
                "Сталинград",
                new List<string> { "Болгар", "Путинград", "Сталинград", "Царицин" });
            questionData.Add(question50000);

            var question100000 = new QuestionClass(
                "В труда \"Раждането на трагедията\" Фридрих Ницше се занимава с противопоставянето между Аполониевето и ...?",
                "Дионисиевото",
                new List<string> { "Зевсовото", "Дионисиевото", "Ахиловото", "Херметичното" });
            questionData.Add(question100000);

            return questionData;
        } 
    }
}
