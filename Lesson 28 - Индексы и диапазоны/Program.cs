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
            int[] myArray = { 2, 10, 5, 5, 1, 1, 2, 3 };
            Console.WriteLine(myArray[^1]); //Поддерживает >= .Net Core 3.0 - выводит первый элемент с конца

            int[] myIntArray = myArray[1..4]; //Поддерживает >= .Net Core 3.0 - извлекает диапазон элементов

            Index index = ^2;
            int res = myArray[index];
            Console.WriteLine(index.Value); // Порядковый номер выводимого элемента
            Console.WriteLine(index.IsFromEnd); //C начала или с конца использовать индекс

            Index construct = new Index(3, true);
            Console.WriteLine(construct);
            Range range = new Range(2, 5);
            Console.WriteLine(range);
            Console.WriteLine(myArray[new Range(1, 2)]);
            int[] myCR = myArray[^3..^1];
            Console.WriteLine(myCR[^1]);
            string str= "Hello";
            Console.WriteLine(str[1..3]);

            //извлечение второго элемента с конца
            Console.WriteLine(myArray[^2]);
            Console.WriteLine();
            //примеры извлечений диапазонов элементов из массива с выводом в консоль
            foreach(var item in myArray[..4])
                Console.WriteLine($"{item} ");
            Console.WriteLine("\n");

            foreach (var item in myArray[4..])
                Console.WriteLine($"{item} ");
            Console.WriteLine("\n");

            foreach (var item in myArray[5..7])
                Console.WriteLine($"{item} ");
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
