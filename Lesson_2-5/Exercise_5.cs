using System;

namespace Lesson_2_5
{
    class Exercise_5
    {
        enum Months
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }
        static void Main(string[] args)
        {
            double min, max;
            int monthsNumber;

            do
            {
                do
                {
                    Console.WriteLine("Введите минимальную температуру:");
                }
                while ((double.TryParse(Console.ReadLine(), out min)) == false);
                do
                {
                    Console.WriteLine("Введите максимальную температуру:");
                }
                while ((double.TryParse(Console.ReadLine(), out max)) == false);
                if (max < min)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" \n Максимальная температура не может быть больше минимальной. Попробуёте ещё раз \n");
                    Console.ResetColor();
                }
            }
            while (max < min);

            double averageTemp = (min + max) / 2;
            Console.WriteLine($"Среднесуточная температура = {averageTemp}");

            do
            {
                Console.WriteLine("Введите номер текущего месяца:");
                int.TryParse(Console.ReadLine(), out monthsNumber);
                if (monthsNumber < 1 || monthsNumber > 12)
                {
                    Console.WriteLine("Не верное значение");
                }
            } while (monthsNumber < 1 && monthsNumber > 12);

            Console.WriteLine($"Сейчас {(Months)monthsNumber}");

            if ((averageTemp>0) && ((monthsNumber == (int)Months.Декабрь) ||(monthsNumber ==  (int)Months.Январь) ||(monthsNumber == (int)Months.Февраль)))
            {
                Console.WriteLine("Дождливая зима");
            }

            Console.ReadLine();
        }
    }
}
