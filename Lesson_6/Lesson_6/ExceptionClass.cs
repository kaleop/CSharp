using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    enum ex
    {
        MyArrayDataException,
        MyArraySizeException
    }

    [Serializable]
    class MyArraySizeException : Exception
    {
        public MyArraySizeException()
        {
                Console.WriteLine("Массив не корректного размера");
        }
    }

    [Serializable]
    class MyArrayDataException : Exception
    {
        public MyArrayDataException(int x, int y)
        {
            Console.WriteLine($"Не удалось преобразовать элемент с координатами ({y+1},{x+1})");
        }
    }
}
