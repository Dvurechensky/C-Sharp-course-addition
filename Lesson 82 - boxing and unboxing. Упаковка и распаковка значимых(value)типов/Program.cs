using System;
/*
 * boxing and unboxing (значимые в стеке, ссылочные в куче)(лучше избегать таких ситуаций)
 */
namespace Lesson_82___boxing_and_unboxing._Упаковка_и_распаковка_значимых_value_типов_
{
    interface IPrintable
    {
        void Print();
    }

    struct Point : IPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}; Y:{Y};");
        }
    }

    class Program
    {
        static void Print(IPrintable printable)
        {
            printable.Print();
        }

        public static void Main(string[] args)
        {
            int a = 1;
            object b = a; //boxing
            int c = (int)b; //unboxing
            //decimal d = (decimal)b;//InvalidCastException
            Point point = new Point { X = 3, Y = 3 };//boxing (ссылку содержит на данные в куче)
            Print(point);

            //int a; a.GetType() - boxing
        }
    }
}
