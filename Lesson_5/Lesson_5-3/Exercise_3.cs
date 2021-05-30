using System;
using System.IO;

namespace Lesson_5_3
{
    class Exercise_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа:");
            string s = Console.ReadLine();
            File.WriteAllBytes("test.txt", CreateByteArray(s));
        }

        static byte[] CreateByteArray(string text)
        {
            byte[] a = new byte[text.Length];
            int i = 0;
            foreach (char c in text)
            {
                a[i] = Convert.ToByte(c);
                i++;
            }
            return a;
        }
    }
}
