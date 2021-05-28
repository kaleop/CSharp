using System;

namespace Lesson_4_2
{
    class Exercise_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные целые числа через пробел:");
            string s = Console.ReadLine();

            if (CheckInput(s) == false)
            {
                Console.WriteLine("Не корректный ввод");
            }
            else
            {
                Console.WriteLine($"Сумма всех чесел в строке равна : {Addition(s)}");
            }
            

            Console.ReadKey();
        }

        static bool CheckInput(string s)
        {
            foreach (char a in s)
            {
                if (a != ' ' && (a < '0' || a > '9'))
                {
                    return false;
                }
            }
            if (s == new string(' ', s.Length))
            {
                return false;
            }

            return true;
        }

        // problem
        static int Addition (string s)
        {
            string stringOperand = "0";
            int numberOperand = 0;
            if (CheckInput(s) == true)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsDigit(s[i]) == true)
                    {
                        stringOperand += s[i];
                    }
                    if (char.IsDigit(s[i]) == false )
                    {
                            numberOperand += Convert.ToInt32(stringOperand);
                            stringOperand = "0";
                    }
                    if (char.IsDigit(s[i]) == true && i == s.Length-1)
                    {
                        numberOperand += Convert.ToInt32(stringOperand);
                    }
                }
            }

            return numberOperand;
        }
    }
}
