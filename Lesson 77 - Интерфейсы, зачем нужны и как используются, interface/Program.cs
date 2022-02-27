using System;
/*
 * интерфейсы и полиморфизм
 */
namespace Lesson_77___Интерфейсы__зачем_нужны_и_как_используются__interface_
{
    //принято что каждый класс и каждый интерфейс находится в своем отдельном файле      

    //интерфейсы - как конструкция языка программирования C#
    //мы определяем поведение которое в последствии будет реализовано в конкретном классе
    //важное отличие интерфейса от абстракции в том что оно позволяет множественное наследование
    //То есть один класс может наследовать несколько интерфейсов (класс не наследуется от интерфейса, а реализует его

    //нет конструкторов
    //нет полей класса
    //только поведение(методы и свойства) и контракт
    //все по умолчанию имеют модификатор public
    
    interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    //также должны реализовать все компоненты интерфейса
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные с HTTP";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //ссылка на интерфейс может хранить обхект класса который его реализует
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            //полиморфизм в чистом виде
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
        }
    }
}
