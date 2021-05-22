using System;

namespace Lesson_3_2
{
    class Exercise_2
    {
        static void Main(string[] args)
        {
            string[,] teleBook = new string[5, 2];

            teleBook[0, 0] = "Ivan";
            teleBook[0, 1] = "ivan@mail.com";

            teleBook[1, 0] = "Anna";
            teleBook[1, 1] = "+99998877665";

            teleBook[2, 0] = "Andry";
            teleBook[2, 1] = "andry@yandex.com";

            teleBook[3, 0] = "Fedot";
            teleBook[3, 1] = "fedot@mail.com/+81234567890";

            teleBook[4, 0] = "Sveta";
            teleBook[4, 1] = "sveta@yahoo.com/+1472583695";

            string line = new string('-', 36);

            Console.SetWindowSize(40, 25);
            Console.CursorLeft = 5;
            Console.WriteLine("Телефонный справочник \n");
            Console.WriteLine(line);

            Console.WriteLine("Имя \tНомер");
            Console.WriteLine();

            for (int i = 0; i < teleBook.GetLength(0); i++)
            {
                for (int j = 0; j < teleBook.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($"{teleBook[i,j]} \t");
                    Console.ResetColor();
                }
                Console.WriteLine("\n" + line);
            }

            Console.ReadKey();
        }
    }
}
