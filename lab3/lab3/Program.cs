using System;
using System.Linq;

namespace WordAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Введення текстового рядка
            Console.WriteLine("Введіть текст:");
            string input = Console.ReadLine();

            // Перетворення тексту на масив слів
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Задача а: Кількість слів з рівною кількістю голосних та приголосних
            int countEqualVowelsAndConsonants = 0;
            foreach (var word in words)
            {
                int vowelsCount = 0, consonantsCount = 0;
                foreach (char c in word.ToLower())
                {
                    if ("аеєиіїоуюя".Contains(c))
                    {
                        vowelsCount++;
                    }
                    else if ("бвгдеєжзийклмнопрстфхцчшщ".Contains(c))
                    {
                        consonantsCount++;
                    }
                }

                if (vowelsCount == consonantsCount)
                {
                    countEqualVowelsAndConsonants++;
                }
            }

            // Виведення кількості слів з рівною кількістю голосних та приголосних
            Console.WriteLine($"Кількість слів з рівною кількістю голосних і приголосних: {countEqualVowelsAndConsonants}");

            // Задача б: Найдовше слово
            string longestWord = words.OrderByDescending(w => w.Length).First();
            Console.WriteLine($"Найдовше слово: {longestWord}");
        }
    }
}
