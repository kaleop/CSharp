using System;

namespace Lesson_2
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            double min, max;
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
                    Console.WriteLine(" \n Максимальная температура не может быть больше минимальной. Попробуёте ещё раз \n" );
                    Console.ResetColor();
                }
            }
            while (max < min);

            Console.WriteLine($"Среднесуточная температура = {(min+max)/2}");

            Console.ReadLine();
        }
    }
}
