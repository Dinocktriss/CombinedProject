using System;

namespace CombinedProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Методы сортировки и объединения массивов
            int[] array1 = { 5, 3, 8, 1, 2 };
            int[] array2 = { 7, 6, 4, 9, 0 };

            Console.WriteLine("Оригинальный массив 1: " + string.Join(", ", array1));
            Console.WriteLine("Оригинальный массив 2: " + string.Join(", ", array2));

            Console.WriteLine("Массив 1 по возрастанию: " + string.Join(", ", SortAscending(array1)));
            Console.WriteLine("Массив 1 по убыванию: " + string.Join(", ", SortDescending(array1)));

            int[] mergedArray = MergeArrays(array1, array2);
            Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));

            // Расчет абсолютной разности
            Console.WriteLine("Введите целое число n:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = CalculateAbsoluteDifference(n);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Неверный ввод, пожалуйста, введите целое число.");
            }
        }

        static int[] SortAscending(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        static int[] SortDescending(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            array1.CopyTo(mergedArray, 0);
            array2.CopyTo(mergedArray, array1.Length);
            return mergedArray;
        }

        static int CalculateAbsoluteDifference(int n)
        {
            int difference = Math.Abs(n - 123);
            if (n > 123)
            {
                return difference * 3;
            }
            return difference;
        }
    }
}
