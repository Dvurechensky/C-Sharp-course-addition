using System;
//добавляем метод расширения
namespace Lesson_80___Реализация_интерфейса_по_умолчанию_
{
    public static class Extensions
    {
        public static void Foo(this ILogger logger)
        {
            Console.WriteLine("Foos");
        }
    }
}
