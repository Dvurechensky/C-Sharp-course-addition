/*
 * приведение типов и наследование
 * 
 * использование операторов as и is
 */

namespace Lesson_73___Операторы_as_is__наследование_и_приведение_типов_
{
    class BasePoint
    {

    }

    //все типы данных неявно унаследованы от типа Object
    class Point : BasePoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"X:\t{X}");
            System.Console.WriteLine($"Y:\t{Y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ссылка базового класса может хранить любой тип наследников
            object obj = new Point
            {
                X = 5,
                Y = 2
            };
            //приведение object к Point
            Point point = (Point)obj;
            point.Print();

            Foo(obj);
            Bar(obj);
        }

        static void Foo(object obj)
        {
            //as - проверяет исключение при приведении типов
            Point point = obj as Point;
            point?.Print();
        }

        static void Bar(object obj)
        {
            //позволяет сразу поместить данные в объект если прошел проверку
            if(obj is Point point)
            {
                point.Print();
            }
        }
    }
}
