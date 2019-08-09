/*
 * Задание 2. Поиск
    Напишите функцию, которая для отсортированного маcсива целых чисел 
    определяет, содержится ли в нем заданное значение.
 */
using System;

namespace Task_2
{
    class Program
    {
        private static bool Function(int number, int[] array)
        {
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    flag = true;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            int number;
            bool flag;
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            do
            {
                try
                {
                    Console.WriteLine("Введите число ");
                    number = Convert.ToInt32(Console.ReadLine());
                    flag = Function(number, array);
                    if (flag)
                    {
                        Console.WriteLine("Такое число есть в массиве");
                    }
                    else
                    {
                        Console.WriteLine("Такого число нет в массиве");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка !!! Вы ввели не число !");
                }
            }
            while (true);
        }
    }
}