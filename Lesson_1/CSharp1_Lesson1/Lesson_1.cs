using System;

namespace CSharp1_Lesson1
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя: ");
            string userName = Console.ReadLine();
            DateTime date = DateTime.Now;

            Console.WriteLine($"Привет, {userName}, сейчас {date} ");
            Console.ReadLine();
        }
    }
}
