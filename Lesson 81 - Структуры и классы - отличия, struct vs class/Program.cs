using System;
/*
 * структуры
 */

/*
 * !!! КОГДА использовать структуру а когда нет !!!!
 * Если в структуре нужно представить тип данных состоящий из примитивных типов
 * которые логически просто должны быть вместе (мало полей)(пример структура Vector из UNITY) (только в том случае
 * если не нужно использовать полиморфизм и наследование для этого типа данных) - выйгрыш в производительности
 * невелирем сборщик мусора
 */
namespace Lesson_81___Структуры_и_классы___отличия__struct_vs_class_
{
    //структуры - это тоже самое что и класс, только
    //они являются значимым(а не ссылочным) типом и не имеет наследования (НО ИНТЕРФЕЙСЫ может)

    //ссылочный тип (reference type - управляемая куча)
    //у классов есть Finalizer(как Деструктор)
    public class ClassPoint
    {
        public ClassPoint()
        {

        }

        public int X { get; set; }
        public int Y { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"X: {X}, Y {Y}");
        }

        //мы можем переопределить его работу
        ~ClassPoint()
        {

        }
    }

    interface IInterface
    {

    }

    //значимый тип (value types - стек) - но также может храниться в управляемой куче
    //не работают virtual override при наследовании, protected для свойст и методов не работают
    //мы не можем переопределить работу Finalizer (аналог деструктора в классах)
    //не можем инициализировать поля или свойства напрямоую, задать переменные
    //реализация ctor конструктора без параметров невозможно
    public struct StructPoint : IInterface
    {
        public StructPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X: {X}, Y {Y}");
        }
    }

    class Program
    {
        static void Foo(ClassPoint classPoint)
        {
            classPoint.X++;
            classPoint.Y++;
        }

        static void Bar(StructPoint structPoint)
        {
            structPoint.X++;
            structPoint.Y++;
        }

        static void Main(string[] args)
        {
            //При инициализации нужно найти место в управляемой куче,
            //разместить там данные и получить на них ссылку
            //- отсюда скорость работы выше
            //плюс для очистки мусора замедляется работа всей программы
            ClassPoint classPoint = new ClassPoint(); //это инициализирует экземпляр класса в управляемую кучу

            //Практически нулевая скорость создания объекта структуры (там уже данные)
            StructPoint structPoint = new StructPoint(); //это инициализирует поля структуры (помещает туда дефолтные значения)

            Foo(classPoint);//тут передается ссылка
            Bar(structPoint);//структуры передаются по значению

            IInterface myInterface = structPoint;
            //каким образом работает метод Equals при сравнении структур и классов


            ClassPoint classPoint1 = new ClassPoint() { X = 2, Y = 3 };
            ClassPoint classPoint2 = new ClassPoint() { X = 2, Y = 3 };

            bool classesAreEqual = classPoint1.Equals(classPoint2);//false - по умолчанию сравнивает не значения а ссылки

            StructPoint structPoint1 = new StructPoint() { X = 2, Y = 3 };
            StructPoint structPoint2 = new StructPoint() { X = 2, Y = 3 };

            bool structesAreEqual = structPoint1.Equals(structPoint2);//true - по умолчанию сравнивает не значения а ссылки
        }
    }
}
