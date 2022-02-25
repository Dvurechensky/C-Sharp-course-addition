using System;

/*
 * синтаксиси инициализации объектов - процесс создания экземпляра объекта класса
 */

namespace Lesson_70___синтаксис_инициализации_объектов_класса_
{
    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Cat()
        {

        }
        public Cat(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat_1 = new Cat("Барсик");
            Console.WriteLine(cat_1.Name);
            Cat cat_2 = new Cat();
            cat_2.Name = "Барс";
            cat_2.Age = 3;

            //альтернативная инициализация объекта
            Cat cat_3 = new Cat
            {
                Name = "Жмур",
                Age = 4
            };

            //Для понимания зачем использовать альтернативную инициализацию
            Person person1 = new Person();
            person1.FirstName = "Ранд";
            person1.LastName = "ал'Тор";

            Address address = new Address();
            address.Country = "Andor";
            address.Region = "Dvurech";
            address.City = "Lug";

            person1.Address = address;

            //Выше читаемость кода
            Person person2 = new Person
            {
                FirstName = "Ранд",
                LastName = "ал'Тор",
                Address = new Address
                {
                    City = "Lug",
                    Region = "Dvurech",
                    Country = "Andor"
                }
            };
        }
    }
}
