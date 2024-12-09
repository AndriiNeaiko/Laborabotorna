using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDatabase
{
    class Program
    {
        // Клас для зберігання інформації про студента
        public class Student
        {
            public string FullName { get; set; }
            public string RecordBookNumber { get; set; }
            public List<int> Grades { get; set; }
            public double AverageGrade => Grades.Average();

            // Конструктор класу
            public Student(string fullName, string recordBookNumber, List<int> grades)
            {
                FullName = fullName;
                RecordBookNumber = recordBookNumber;
                Grades = grades;
            }

            // Метод для визначення, чи є незадовільна оцінка
            public bool HasUnsatisfactoryGrades()
            {
                return Grades.Any(grade => grade < 60); // 60 - це поріг для незадовільної оцінки
            }
        }

        static void Main(string[] args)
        {
            // Список студентів
            List<Student> students = new List<Student>
            {
                new Student("Іванов Іван", "12345", new List<int> { 85, 90, 88, 75, 92 }),
                new Student("Петренко Петро", "12346", new List<int> { 56, 60, 58, 52, 59 }),
                new Student("Сидоренко Олена", "12347", new List<int> { 92, 95, 93, 97, 91 }),
                new Student("Мельник Віктор", "12348", new List<int> { 45, 50, 47, 49, 44 }),
                new Student("Коваленко Марія", "12349", new List<int> { 60, 63, 62, 59, 61 }),
                new Student("Шевченко Тарас", "12350", new List<int> { 75, 80, 78, 82, 76 }),
                new Student("Захарченко Ірина", "12351", new List<int> { 92, 95, 94, 93, 96 }),
                new Student("Кузьменко Олексій", "12352", new List<int> { 55, 57, 59, 60, 50 }),
                new Student("Литвиненко Валентина", "12353", new List<int> { 81, 83, 78, 79, 85 }),
                new Student("Довженко Сергій", "12354", new List<int> { 70, 72, 71, 68, 74 })
            };

            try
            {
                // Впорядковуємо студентів за середнім балом у зростаючому порядку
                var sortedStudents = students.OrderBy(student => student.AverageGrade).ToList();

                // Виводимо таблицю з інформацією
                Console.WriteLine("{0,-20} {1,-20} {2,10}", "Прізвище та ім'я", "Номер залікової книжки", "Середній бал");

                foreach (var student in sortedStudents)
                {
                    Console.WriteLine("{0,-20} {1,-20} {2,10:F2}", student.FullName, student.RecordBookNumber, student.AverageGrade);
                }

                // Підраховуємо відсоток студентів з незадовільними оцінками
                double unsatisfactoryCount = students.Count(student => student.HasUnsatisfactoryGrades());
                double unsatisfactoryPercentage = (unsatisfactoryCount / students.Count) * 100;

                Console.WriteLine($"\nВідсоток студентів з незадовільними оцінками: {unsatisfactoryPercentage:F2}%");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }
}
