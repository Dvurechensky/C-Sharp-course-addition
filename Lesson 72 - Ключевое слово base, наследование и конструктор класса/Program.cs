/*
 * наследование, конструкторы класса и ключевое слово base
 */
namespace Lesson_72___Ключевое_слово_base__наследование_и_конструктор_класса_
{
    class Point2D
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            System.Console.WriteLine("Point2D");
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"X:\t{X}");
            System.Console.WriteLine($"Y:\t{Y}");
        }
    }

    class Point3D : Point2D
    {
        //при использовании ключевого слова base мы можем явно указать какой конструктор у базоваого класса используем
        //base - позволяет нам явно указать что мы хотим использовать (нечто) из базового класса
        public Point3D(int x, int y, int z) : base (x, y)
        {
            Z = z;
            System.Console.WriteLine("Point3D");
        }    
        public int Z { get; set; }

        public new void Print()
        {
            //аналог слова this (решающее неоднозначность)
            base.Print();
            System.Console.WriteLine($"Z:\t{Z}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //прежде чем создается класс конструктором - создаются все его предки
            Point3D point3D = new Point3D(1, 2, 3);
            point3D.Print();
            Point2D point2D = new Point2D(1, 2);
            point2D.Print();
        }
    }
}
