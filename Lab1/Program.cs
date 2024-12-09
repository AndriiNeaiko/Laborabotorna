using System;

namespace NumberOperations
{
    public class Program
    {
        public static (int sum, int product) CalculateSumAndProduct(int number)
        {
            if (number < 1000 || number > 9999)
                throw new ArgumentException("Число має бути чотиризначним.");

            int sum = 0, product = 1;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                number /= 10;
            }
            return (sum, product);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть чотиризначне число:");
            int number = int.Parse(Console.ReadLine());

            try
            {
                var (sum, product) = CalculateSumAndProduct(number);
                Console.WriteLine($"Сума цифр: {sum}, Добуток цифр: {product}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
