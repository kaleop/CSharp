using System;

namespace Lesson_4_3
{
    class Exercise_3
    {
        enum SeasonOfTheYear
        {
            Winter,
            Spring,
            Summer,
            Autumn,

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца:");
            string monthNumber;
            int month = 0;
            bool b;

            do
            {
                monthNumber = Console.ReadLine();
                b = int.TryParse(monthNumber, out month);
                if (b == false)
                {
                    Console.WriteLine("Не корректный ввод данных. Попробуйте ещё раз:");
                }
            }
            while (b == false);

            WriteSeason(GetSeason(month));
            Console.ReadKey();

        }

        static SeasonOfTheYear GetSeason (int monthNumber)
        {
            if (monthNumber>=3 && monthNumber<= 5)
            {
                return SeasonOfTheYear.Spring;
            }
            if (monthNumber >=6 && monthNumber <=8)
            {
                return SeasonOfTheYear.Summer;
            }
            if (monthNumber>=9 && monthNumber<=11)
            {
                return SeasonOfTheYear.Autumn;
            }
            return SeasonOfTheYear.Winter;
        }

        static void WriteSeason (SeasonOfTheYear a)
        {
            switch (a)
            {
                case SeasonOfTheYear.Winter:
                    Console.WriteLine("Зима");
                    break;
                case SeasonOfTheYear.Spring:
                    Console.WriteLine("Весна");
                    break;
                case SeasonOfTheYear.Summer:
                    Console.WriteLine("Лето");
                    break;
                case SeasonOfTheYear.Autumn:
                    Console.WriteLine("Осень");
                    break;
            }
        }

    }
}
