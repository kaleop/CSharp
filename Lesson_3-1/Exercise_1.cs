using System;

namespace Lesson_3_1
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[5,5];
            int[,] mass2 = new int[2, 5];

            Random r = new Random();

            for (int i = 0; i <= mass.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= mass.GetUpperBound(1); j++)
                {
                    mass[i, j] = r.Next(0,10);
                    Console.Write(mass[i,j] + " ");

                    // Первая Диагональ
                    if (i == j)                         
                    {
                        mass2[0, i] = mass[i, j];
                    }

                    // Вторая диагональ
                    if ( (i+j) == mass.GetUpperBound(1)) 
                    {
                        mass2[1, i] = mass[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i <= mass2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= mass2.GetUpperBound(1); j++)
                {
                    Console.Write(mass2[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
