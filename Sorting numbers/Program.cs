/*
 Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы, от меньшего до большего.
Нельзя использовать Array.Sort. Используйте пузырьковую сортировку.
 */
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int elements = 15;
            int minValue = 0;
            int maxValue = 31;
            int[] numbers = new int[elements];

            Random random = new Random();

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue +1);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            int arrayLength = numbers.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                for (int j = 0; j < arrayLength - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Отсортированный массив: " + string.Join(", ", numbers));
        }
    }
}
