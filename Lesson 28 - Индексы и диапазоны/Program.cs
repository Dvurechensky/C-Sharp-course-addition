using System;

/*
 * индексы и диапазоны
 */

namespace Lesson_28___Индексы_и_диапазоны
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 10, 5 };
            Console.WriteLine(myArray[^1]); //Поддерживает >= .Net Core 3.0 - выводит первый элемент с конца
            Console.WriteLine(myArray[1..4]); //Поддерживает >= .Net Core 3.0 - извлекает диапазон элементов
        }
    }
}
