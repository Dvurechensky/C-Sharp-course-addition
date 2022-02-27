using System;
/*
 * реализация интерфейса по умолчанию в C# 8.0
 */
namespace Lesson_80___Реализация_интерфейса_по_умолчанию_
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Foo();
            logger.Bar();
            logger.Sum(1, 3);
            logger.Log(LogLevel.Debug, "some event");
            logger.Log(LogLevel.Warning, "some warning");
            logger.Log(LogLevel.Fatal, "some fatal");
        }
    }
}
