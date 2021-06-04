using System;

namespace Lesson_6
{
    class Exercise_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сгенерированыый массив");
            string[,] arr = GetRandomArr();
            ShowArray(arr);
            try
            {
                CheckArray(arr);
                Console.WriteLine($"Сумма всех чисел массива {TryConvert(arr)}");
            }
            catch (MyArrayDataException)
            {

            }
            catch(MyArraySizeException)
            {

            }
            Console.ReadKey();

        }

        static string[,] GetRandomArr()
        {
            Random r = new Random();
            int x = r.Next(3, 5);
            string[,] RandomArr = new string[x, x];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    RandomArr[i, j] = GetRandomWord();
                }
            }
            return RandomArr;
        }

        static string GetRandomWord()
        {
            Random r = new Random();
            int x = r.Next(0, 100);
            if (x < 90 )
            {
                return x.ToString();
            }
            return "adg";
        }

        static void CheckArray (string [,] arr)
        {
            if (arr.GetUpperBound(0) != 3 || arr.GetUpperBound(1) != 3)
            {
                throw new MyArraySizeException();
            }


        }

        static int TryConvert (string [,] arr)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(0); j++)
                {
                    if (Int32.TryParse(arr[i, j],out x) == true)
                    {
                        y += x; 
                    }
                    else
                    {
                        throw new MyArrayDataException(i, j);
                    }
                }
            }

            return y;
        }

        static void ShowArray (string [,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
