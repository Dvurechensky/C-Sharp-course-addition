using System;

/*
 * наследование в ооп 
 */

namespace Lesson_71___НАСЛЕДОВАНИЕ_
{
    //позволяет избежать ненужного дублирования кода
    //позволяет реализовать полиморфизм
    //множественного наследования в C# нет (для классов)

    class Kraft
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Name: {FirstName}");
        }
    }

    //наследование выполнено
    //все свойства, методы и поля унаследованы
    class Ivuc : Kraft
    {
        public void PrintLastName()
        {
            Console.WriteLine($"LastName: {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kraft kraft = new Kraft
            {
                FirstName = "terry",
                LastName = "lamos"
            };
            kraft.PrintName();

            Ivuc ivuc = new Ivuc
            {
                FirstName = "terry",
                LastName = "lamos"
            };

            ivuc.PrintName();
            ivuc.PrintLastName();

            //Можно при инициализацими экземпляра класса, инициализировать его наследника
            //Тем самым это помогает в работе старого функционала - он может работать и с наследниками 
            Ivuc kraft_ivuc = new Ivuc
            {
                FirstName = "terry",
                LastName = "lamos"
            };
            PrintFullName(kraft_ivuc);

            Teacher teacher = new Teacher
            {
                FirstName = "John",
                LastName = "Karter"
            };

            Student student = new Student
            {
                FirstName = "Garry",
                LastName = "Astos"
            };

            LP[] people = { teacher, student };
            PrintLP(people);
        }

        static void PrintFullName(Kraft kraft)
        {
            Console.WriteLine($"Name: {kraft.FirstName} LastName: {kraft.LastName}");
        }

        static void PrintLP(LP[] persons)
        {
            foreach (var person in persons)
            {
                person.PrintFullName();
            }
        }
    }
}
