/*
 * Задание 3. Строки
    Дана строка, вывести только те слова, которые встречаются в ней только один раз.
 */
using System;

namespace Task_3
{
    class Program
    {
        private static string Function(string animals)
        {
            string NewLineOfAnimals = "";
            string[] strarray = new string[] { "" };
            strarray = animals.Split(' ');
            for (int i = 0; i < strarray.Length; i++)
            {
                int index = 0;
                for (int j = 0; j < strarray.Length; j++)
                {
                    if (strarray[i] == strarray[j])
                    {
                        index++;
                    }
                }
                if (index == 1)
                {
                    NewLineOfAnimals += strarray[i] + " ";
                }
            }
            return NewLineOfAnimals;
        }
        static void Main(string[] args)
        {
            string NewLineOfAnimals = "";
            string animals = "Собака Кошка Лошадь Птица Медведь Змея Лев Лев Змея Кошка Медведь Лошадь";
            NewLineOfAnimals = Function(animals);
            Console.WriteLine(NewLineOfAnimals);
            Console.ReadKey();
        }
    }
}
