namespace WhoWantsToBeACodeWizard.Data.Migrations
{
    using Models.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<WhoWantsToBeACodeWizard.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WhoWantsToBeACodeWizard.Data.ApplicationDbContext context)
        {

          
            var questionData = new List<Question>();

            var answer50 = new Answer("Водещият е затруднен");
            var question50 = new Question(
                "Как трябва да се тълкува преносният смисъл на израза \"Водещият е поставен натясно\"?",
                answer50,
                new List<Answer> { answer50, new Answer("Сакото му е малък размер"), new Answer("Живее в боксониера"), new Answer("Столът му е тесен") },
                ComplexityLevel.One);
            questionData.Add(question50);

            var answer100 = new Answer("Откъде идват бебетата?");
            var question100 = new Question(
                "Koй от въпросите е най-вероятно да се чуе от устата на едно малко дете?",
                answer100,
                new List<Answer> { new Answer("Колко е косинус от 30?"), answer100, new Answer("Единица или хикс?"), new Answer("Изстуди ли се бирата?") },
                ComplexityLevel.Two);
            questionData.Add(question100);

            var answer150 = new Answer("Пътната обстановка");
            var question150 = new Question(
                "За какво ще бъде дадена информация, ако по радио \"Хоризонт\" обявят включването на майор Красимир Костов?",
                answer150,
                new List<Answer> { new Answer("Нивото на река Дунав"), new Answer("Числата от тотото"), answer150, new Answer("Кого убиват в \"Под прикритие\"") },
                ComplexityLevel.Three);
            questionData.Add(question150);

            var answer200 = new Answer("Нечетен брой дини");
            var question200 = new Question(
                "Ако Галена има нечетен брой дини и даде една диня на Слави и една на Годжи, колко ще й останат?",
                answer200,
                new List<Answer> { new Answer("Точно два чифта дини"), new Answer("Четен брой дини"), new Answer("Не може да се каже"), answer200 },
                ComplexityLevel.Four);
            questionData.Add(question200);

            var answer250 = new Answer("Скоропоговорка");
            var question250 = new Question(
                "\"Шише със уши на шосе се суши\" е пример за:",
                answer250,
                new List<Answer> { new Answer("Гатанка"), new Answer("Пословица"), answer250, new Answer("Приказка") },
                ComplexityLevel.Five);
            questionData.Add(question250);

            var answer500 = new Answer("Приятели");
            var question500 = new Question(
                "Какви са помежду си тримата мускетари от едноименния роман на Александър Дюма-баща?",
                answer500,
                new List<Answer> { new Answer("Баджанаци"), new Answer("Братя"), new Answer("Състуденти"), answer500 },
                ComplexityLevel.Six);
            questionData.Add(question500);

            var answer1000 = new Answer("Чук");
            var question1000 = new Question(
                "Кой е единственият уред в леката атлетика, които се хвърля с две ръце?",
                answer1000,
                new List<Answer> { new Answer("Диск"), new Answer("Копие"), new Answer("Гюле"), answer1000 },
                ComplexityLevel.Seven);
            questionData.Add(question1000);

            var answer1500 = new Answer("Играе билярд гол");
            var question1500 = new Question(
                "Какво прави британският принц Хари на част от папарашките снимки, предизвикали огромен скандал в Англия?",
                answer1500,
                new List<Answer> { new Answer("Пуши марихуана"), answer1500, new Answer("Измъчва военнопленник"), new Answer("Заглежда Пипа Мидълтън") },
                ComplexityLevel.Eight);
            questionData.Add(question1500);

            var answer2000 = new Answer("Прага");
            var question2000 = new Question(
                "Жителите на кой град трябва да прескачат най-много граници, за да стигнат до брега на Средиземно море?",
                answer2000,
                new List<Answer> { answer2000, new Answer("Берлин"), new Answer("Виена"), new Answer("Цюрих") },
                ComplexityLevel.Nine);
            questionData.Add(question2000);

            var answer2500 = new Answer("1902");
            var question2500 = new Question(
                "През коя година е създаден испанският футболен клуб Реал Мадрид",
                answer2500,
                new List<Answer> { new Answer("1888"), new Answer("1911"), answer2500, new Answer("1923") },
                ComplexityLevel.Ten);
            questionData.Add(question2500);

            var answer5000 = new Answer("Хотел Калифорния");
            var question5000 = new Question(
                "В коя песен, вследсвие на пътна преумора, един шофьор попада в сюрреалистична обстановка?",
                answer5000,
                new List<Answer> { new Answer("Хей, Джудж"), new Answer("Мисис Робинсън"), answer5000, new Answer("Руут 66") },
                ComplexityLevel.One);
            questionData.Add(question5000);

            var answer10000 = new Answer("Лъки Лучано");
            var question10000 = new Question(
                "Кой гангстер сътрудничи с правителството на САЩ през ВСВ в замяна на предсрочно излизане от затвора?",
                answer10000,
                new List<Answer> { new Answer("Ал Капоне"), new Answer("Дъч Шулц"), answer10000, new Answer("Арнолд Ротстийн") },
                ComplexityLevel.One);
            questionData.Add(question10000);

            var answer25000 = new Answer("В Тибет");
            var question25000 = new Question(
                "Къде се намира най-дългата писта за излитане и кацане на гражданско летище - 5500 метра?",
               answer2500,
                new List<Answer> { answer2500, new Answer("В Бразилия"), new Answer("В Южна Африка"), new Answer("В Катар") },
                ComplexityLevel.One);
            questionData.Add(question25000);

            var answer50000 = new Answer("Сталинград");
            var question50000 = new Question(
                "Какво име прие за един ден руският град Волгоград на 2 февруари тази година?",
                answer50000,
                new List<Answer> { new Answer("Болгар"), new Answer("Путинград"), answer50000, new Answer("Царицин") },
                ComplexityLevel.One);
            questionData.Add(question50000);

            var answer100000 = new Answer("Дионисиевото");
            var question100000 = new Question(
                "В труда \"Раждането на трагедията\" Фридрих Ницше се занимава с противопоставянето между Аполониевето и ...?",
                answer100000,
                new List<Answer> { new Answer("Зевсовото"), answer100000, new Answer("Ахиловото"), new Answer("Херметичното") },
                ComplexityLevel.One);
            questionData.Add(question100000);

            context.Questions.AddRange(questionData);
            context.SaveChanges();
        }
    }
}
