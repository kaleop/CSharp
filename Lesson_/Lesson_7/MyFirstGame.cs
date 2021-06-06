using System;

namespace Lesson_7
{
    class MyFirstGame
    {
        static void Main(string[] args)
        {
            Console.Title = "Крестики Нолики";
            Game game = new Game();

            game.Start();
            game.Play();
        }
    }
}
