using System;
/*
 * Полиморфизм
 * 
 * виртуальные методы
 * 
 * virtual
 * 
 * override
 */
namespace Lesson_75___ПОЛИМОРФИЗМ__виртуальные_методы__virtual_override_
{
    //virtual и override - дают возможность переопределить работу методов в классе наследнике
    class Motor
    {
        //чтобы метод был доступен на уровно наследника вместо private ставим protected
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель запущен!");
        }

        //Чтобы переопределить метод для новой реализации в наследнике
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Я еду!");
        }
    }

    class SportMotor : Motor
    {
        protected override void StartEngine() => Console.WriteLine("Рон дон дон");

        //переопределение виртуального метода
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("Я быстро еду!");
        }
    }

    class Stable
    {
        public void Drive(Motor motor)
        {
            motor.Drive();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stable stable = new Stable();
            stable.Drive(new SportMotor());
        }
    }
}
