using System;
using System.Collections;
using System.Collections.Generic; //обобщенные коллекции
/*
 * Обобщения(Generics)
 */
namespace Lesson_83___Обобщения__generic_типы__методы_и_классы_
{
    //это такие конструкции языка которые позволяют писать код который будет одинаково работать с различными типами данных
    //общий код для разных типов данных, при этом мы сохраняем строгую типизацию языка
    //получаем несколько еще очень полезных и нужных бонусов
    //например:
    //позволяет избежать проецесса упаковки и распаковки значимых типов, что увеличивает производительность кода

    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 5;
            string c = "aa", d = "bb";
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"str_d = {d}, str_c = {c}");

            Swap(ref a, ref b);
            SwapType(ref c, ref d);

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"str_d = {d}, str_c = {c}");

            int result = Foo<int>();

            //также использует обобщения
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(5);
            Console.WriteLine(list[1]);
            list[0] = 1;
            //list - аналог
            //но куча проблем с упаковкой распаковкой так как тип данных object
            //почти не используется
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add("33");

            //свой List
            MyList<string> listString = new MyList<string>();
            listString.Add("aaa");
            listString.Add("bbb");
            Console.WriteLine($"1: {listString[0]} 2: {listString[1]}");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void SwapType<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T Foo<T>()
        {
            return default(T);
        }
    }
}
