/*
 * Задание 4 Факториал
    Написать функцию нахождения факториала числа n.
 */
using System;

namespace Task_4
{
    class Program
    {
        private static int Function(int n)
        {
            int Sum = 1;
            for (int i = n; i > 1; i--)
            {
                Sum = Sum * i;
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            int t = Function(5);
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
