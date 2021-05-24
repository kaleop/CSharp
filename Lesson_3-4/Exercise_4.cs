using System;

namespace Lesson_3_4
{
    class Exercise_4
    {
        static void Main(string[] args)
        {
            char ship = 'O';
            char x = '*';
            char[,] field = new char[10, 10]
            {
                { ship, x, x, x, x, x, x, x, x, x },
                { ship, x, ship, x, ship, ship, ship, x, ship, x },
                { ship, x, ship, x, x, x, x, x, ship, x },
                { ship, x, ship, x, x, ship, x, x, x, x },
                { x, x, x, x, x, ship, x, x, x, x },
                { x, x, x, x, x, x, x, x, x, x },
                { ship, x, ship, x, x, x, x, x, x, x },
                { ship, x, x, x, x, x, x, x, x, x },
                { x, x, ship, x, x, ship, x, x, x, x },
                { x, x, x, x, x, x, x, x, x, ship }
            };

            for (int i = 0; i < field.GetUpperBound(0); i++)
            {
                for (int j = 0; j < field.GetUpperBound(1); j++)
                {
                    Console.Write(field[i,j]);
                    if (j == field.GetUpperBound(0)-1)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
