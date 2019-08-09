/*
 * Задание 1. Сортировка
    Дан массив целых чисел. Напишите функцию, которая получает данный массив в 
    качестве аргумента и сортирует его по возрастанию, а также программу для демонстрации работы этой функции.
 */
using System;

namespace Task_1
{
    class Program
    {
        private static int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int position = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > position)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = position;
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 2, 4, 12, 1, 3, 6, 7, 8, 9, 11, 15, 14, 13, 10, 16, 20, 17, 19, 18 };
            Console.Write("Изначальный массив: ");
            foreach (var number in array)
            {
                Console.Write(number);
            }
            array = Sort(array);
            Console.Write("\nОтсортированный массив: ");
            foreach (var number in array)
            {
                Console.Write(number);
            }
            Console.ReadKey();
        }
    }
}

