using System;

namespace Lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] FIO = new string[3, 4]
            {
                { "Бильбо", "Джонни", "Питер", "Влад" },
                { "Бэггинс", "Сильверхэнд", "Паркер", "Цепеш" },
                { "Арнольдович", "Вячеславович", "Игнатьевич", "Ибрагимович" }
            };

            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(GetFullName(FIO[0, r.Next(0, 3)], FIO[1, r.Next(0, 3)], FIO[2, r.Next(0, 3)]));
            }
            Console.ReadKey();
        }

        static string GetFullName (string firstName, string lastName, string patronymic)
        {
            return ($"{firstName} {lastName} {patronymic}");
        }

    }
}
