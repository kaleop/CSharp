using System;
using System.IO;

namespace Lesson_5_2
{
    class Exercise_2
    {
        static void Main(string[] args)
        {
            File.AppendAllText("startup.txt", DateTime.Now.ToString()+ "\n");
        }
    }
}
