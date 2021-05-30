using System;

namespace Lesson_4_4
{
    class Exercise_5
    {
        static void Main(string[] args)
        {
            string s = "Предложение один Теперь предложение два Предложение три";
            Console.WriteLine($"Было: {s}");

            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && (char.IsUpper(s[i]) == true && s[i-2] != '.'))
                {
                    s = s.Insert(i - 1,".");
                    i++;
                }
                if ( i == s.Length-1 && s[i] != '.')
                {
                    s=s.Insert(i+1, ".");
                    i++;
                }
            }

            Console.WriteLine($"Стало: {s}");
            Console.ReadKey();
        }

    }
}
