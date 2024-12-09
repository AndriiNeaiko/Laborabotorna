using System;

namespace HourName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер години (1-24):");

            if (int.TryParse(Console.ReadLine(), out int hour) && hour >= 1 && hour <= 24)
            {
                string hourName = GetHourName(hour);
                Console.WriteLine($"Назва години: {hourName}");
            }
            else
            {
                Console.WriteLine("Помилка: введіть число від 1 до 24.");
            }
        }

        static string GetHourName(int hour)
        {
            switch (hour)
            {
                case 1: return "перша година";
                case 2: return "друга година";
                case 3: return "третя година";
                case 4: return "четверта година";
                case 5: return "п’ята година";
                case 6: return "шоста година";
                case 7: return "сьома година";
                case 8: return "восьма година";
                case 9: return "дев’ята година";
                case 10: return "десята година";
                case 11: return "одинадцята година";
                case 12: return "дванадцята година";
                case 13: return "перша година (після полудня)";
                case 14: return "друга година (після полудня)";
                case 15: return "третя година (після полудня)";
                case 16: return "четверта година (після полудня)";
                case 17: return "п’ята година (після полудня)";
                case 18: return "шоста година (після полудня)";
                case 19: return "сьома година (після полудня)";
                case 20: return "восьма година (після полудня)";
                case 21: return "дев’ята година (після полудня)";
                case 22: return "десята година (після полудня)";
                case 23: return "одинадцята година (після полудня)";
                case 24: return "дванадцята година (після полудня)";
                default: return "Некоректна година";
            }
        }
    }
}
