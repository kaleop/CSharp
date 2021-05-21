using System;

namespace Lesson_2_2
{
    class Exercise_2
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
            int i;            
            do
            {
                Console.WriteLine("Введите номер текущего месяца:");
                int.TryParse(Console.ReadLine(), out i);
                if (i < 1 || i > 12)
                {
                    Console.WriteLine("Не верное значение");
                }
            } while (i<1 && i>12);

            Console.WriteLine($"Сейчас {(Months)i}");

            Console.ReadLine();
        }
    }
}
