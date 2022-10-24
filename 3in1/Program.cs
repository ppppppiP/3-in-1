using System;

namespace _3in1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nЗадание 4.107 ");

            Console.WriteLine("Введите номер месяца");
            int mounthN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());

            switch (mounthN)
            {
                case 1: Console.Write("\nЯнварь - 31 день"); break;
                case 2:
                    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    {
                        Console.Write("\nФевраль - 29 дней");
                    }
                    else
                    {
                        Console.Write("\nФевраль - 28 дней");
                    }
                    break;
                case 3: Console.Write("\nМарт - 31 день"); break;
                case 4: Console.Write("\nАпрель - 30 дней"); break;
                case 5: Console.Write("\nМай - 31 день"); break;
                case 6: Console.Write("\nИюнь - 30 дней"); break;
                case 7: Console.Write("\nИюль - 31 день"); break;
                case 8: Console.Write("\nАвгуст - 31 день"); break;
                case 9: Console.Write("\nСентябрь - 30 дней"); break;
                case 10: Console.Write("\nОктябрь - 31 день"); break;
                case 11: Console.Write("\nНоябрь - 30 дней"); break;
                case 12: Console.Write("\nДекабрь - 31 день"); break;
            }


            Console.WriteLine("\nЗадание 4.110");
            
            Console.WriteLine("Введите номер масти карты (1-пик, 2-крести, 3-бубен, 4-червь ");
            int cardNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите номер достоинства карты");
            int cardDignity = Convert.ToInt32(Console.ReadLine());

            switch (cardDignity)
            {
                case 6: Console.Write("Шестерка"); 
                    break;
                case 7: Console.Write("Семерка"); 
                    break;
                case 8: Console.Write("Восьмерка"); 
                    break;
                case 9: Console.Write("Девятка"); 
                    break;
                case 10: Console.Write("Десятка"); 
                    break;
                case 11: Console.Write("Валет"); 
                    break;
                case 12: Console.Write("Дама"); 
                    break;
                case 13: Console.Write("Король"); 
                    break;
                case 14: Console.Write("Туз"); 
                    break;
            }
            switch (cardNumber)
            {
                case 1: Console.Write("\n пик"); 
                    break;
                case 2: Console.Write("\n крести"); 
                    break;
                case 3: Console.Write("\n бубен"); 
                    break;
                case 4: Console.Write("\n червей"); 
                    break;
            }
            Console.WriteLine("\n Задание 4.114");

            Console.Write("Введите год: ");
            int yearY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            int mounth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Дата предыдущего дня: {day - 1}.{mounth}.{yearY}");
            Console.WriteLine($"Дата следующего дня: {day + 1}.{mounth}.{yearY}");

            if (yearY % 4 == 0 && (yearY % 100 != 0 || yearY % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не високосный");
            }


        }
    }
}
