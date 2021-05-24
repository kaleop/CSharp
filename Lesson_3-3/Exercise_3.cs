using System;

namespace Lesson_3_3
{
    class Exercise_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();

            char[] s2 = s.ToCharArray();

            for (int i = s2.Length-1 ; i >= 0 ; i--)
            {
                Console.Write(s2[i]);
            }

            Console.ReadKey();

        }
    }
}
