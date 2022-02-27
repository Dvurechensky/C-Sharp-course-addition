using System;
/*
 * полиморфизм
 * 
 * абстрактный класс
 * 
 * абстрактный метод
 * 
 * абстрактное свойство
 */
namespace Lesson_76___Абстрактные_классы__abstract_
{
    //абстрактный класс - это некая идея, которая может содержать в себе частичную реализацию
    //и содержание которого можно использовать в наследниках

    //Хотим научить наш класс Player стрелять из любого вида оружия
    abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        //не только абстрактный метод но и реализация возможна 
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}: {Damage}");
        }
    }

    //при наследовании от абстрактного класса - мы обязаны реализовать все его абстрактные методы
    class Gun : Weapon
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("Boom");
        }
    }

    //при наследовании от абстрактного класса - мы обязаны реализовать все его абстрактные методы
    class LazerGun : Weapon
    {
        public override int Damage => 9;

        public override void Fire()
        {
            Console.WriteLine("Boom's");
        }
    }

    //при наследовании от абстрактного класса - мы обязаны реализовать все его абстрактные методы
    class Bow : Weapon
    {
        public override int Damage => 12;

        public override void Fire()
        {
            Console.WriteLine("Bzzzzzzzz");
        }
    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] inventory = { new Gun(), new LazerGun(), new Bow() };
            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                
                Console.WriteLine();
            }
        }
    }
}
