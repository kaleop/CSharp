using System;

namespace Lesson_2_3
{
    class Exercise_3
    {
        static void Main(string[] args)
        {
            int i;
            bool b;
            do
            {
                Console.WriteLine("Введите целое число:");
                b = int.TryParse(Console.ReadLine(), out i);
                if (b == false)
                {
                    Console.WriteLine("Вы Ввели не корректное число");
                }

            } while (b == false);

            if (i%2 ==0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("число не чётное");
            }

            Console.ReadLine();
        }
    }
}
