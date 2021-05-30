using System;
using System.IO;

namespace Lesson_5_1
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите и нажмите Enter:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите название файла:");
            string fileName = Console.ReadLine() + ".txt";

            File.WriteAllText(fileName, text);
            Console.ReadKey();
        }
    }
}
