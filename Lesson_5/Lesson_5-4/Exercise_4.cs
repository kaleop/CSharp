using System;
using System.Text;

namespace Lesson_5_4
{
    class Exercise_4
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[10];

            for (int i = 0; i < 10; i++)
            {
                emp[i] = EmpCreate();
            }

            int count = 0;

            foreach (Employee e in emp)
            {
                if (e.Age >= 40)
                {
                    e.EmployeeInfo();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Все сотрудники младше 40 лет");
            }

            Console.ReadKey();

        }

        static Employee EmpCreate ()
        {
            string[] names = new string[6]
                {"Антон", "Пётр", "Игнат", "Захар", "Евгений", "Александр"};

            string[] surnames = new string[6]
                {"Чижиков", "Цибуля", "Орешкин", "Мутко", "Оганесян", "Чёрный"};

            string[] patronymics = new string[6]
                {"Халкович", "Торович", "Айронмэнович", "Питерпаркерович", "Пантерович", "Веномович"};


            string name = RandomString(names);

            Random r = new Random();


            return new Employee(name, RandomString(surnames), RandomString(patronymics), RandomEmail(name), RandomPhone(), r.Next(18, 65), RandomPost());
        }

        static string RandomPhone ()
        {
            StringBuilder number = new StringBuilder("+7");
            Random r = new Random();
            for (int i=0; i<9; i++)
            {
                number.Append(r.Next(0, 9).ToString());
            }
            return number.ToString();
        }

        static string RandomString (string[] FIOArray)
        {
            Random r = new Random();
            return FIOArray[r.Next(0, FIOArray.Length - 1)];
        }

        static string RandomEmail(string name)
        {
            string[] email = new string[4]
                {"@mail.ru","@yandex.ru","@gmail.ru","@yahoo.ru"};

            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append(RandomString(email));
            return sb.ToString();
        }

        static Post RandomPost()
        {
            string[] job = new string[7]
                {"Работяга","Инженер","Менеджер","Охранник","Сын маминой подруги", "Программист","ОТК"};

            Random r = new Random();

            return new Post(r.Next(0, 25), r.Next(30000,150000), job[r.Next(0, 6)]);
        }
    }
}
