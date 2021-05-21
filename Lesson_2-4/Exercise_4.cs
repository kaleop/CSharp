using System;

namespace Lesson_2_4
{
    class Exercise_4
    {
        enum Products
        {
            Свекла = 1,
            Картошка = 2,
            Морковь = 3,
            Капуста = 4
        }

        enum Price
        {
            Свекла = 120,
            Картошка = 65,
            Морковь = 50,
            Капуста = 75
        }
        static void Main(string[] args)
        {
            double weightBeet = 2.5;
            double weightPotato = 7.74;
            double weightCarrot = 2.21;
            double weightCabbage = 5.78;

            int chequeNumber = 44705;

            string Line = new string('*', 37);

            Console.WriteLine(new string(' ',12)+$"Чек № {chequeNumber}");
            Console.WriteLine(Line);

            double beet = (int)Price.Свекла * weightBeet;
            double potato = (int)Price.Картошка * weightPotato;
            double carrot = (int)Price.Морковь * weightCarrot;
            double cabbage = (int)Price.Капуста * weightCabbage;

            Console.WriteLine($"Продукт \tЦена\tВес\tСумма");
            Console.WriteLine();
            Console.WriteLine($"{Products.Свекла}  \t{(int)Price.Свекла}\t{weightBeet}\t{beet}");
            Console.WriteLine($"{Products.Картошка}\t{(int)Price.Картошка}\t{weightPotato}\t{potato}");
            Console.WriteLine($"{Products.Морковь} \t{(int)Price.Морковь}\t{weightCarrot}\t{carrot}");
            Console.WriteLine($"{Products.Капуста} \t{(int)Price.Капуста}\t{weightCabbage}\t{cabbage}");

            Console.WriteLine(Line);
            Console.WriteLine($"К оплате:                \t{beet + potato + carrot + cabbage}");
            Console.WriteLine($"");
            Console.WriteLine(DateTime.Now);

            Console.ReadLine();

        }
    }
}
