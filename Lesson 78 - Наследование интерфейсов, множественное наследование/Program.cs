using System;

/*
 * наследование интерфейсов
 */

namespace Lesson_78___Наследование_интерфейсов__множественное_наследование_
{
    interface IWeapon
    {
        void Fire();
    }

    //метательное оружие
    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }

    //принцип такой-же как у классов (все что есть в базовом доступно и в наследнике)
    interface ISmall : IWeapon
    {

    }

    //в отличии от классов поддерживают множественное наследование
    interface IBig : IWeapon, ISmall
    {

    }

    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: GunBom");
        }
    }

    class LazerGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: LazerGunBom");
        }
    }

    class Bow : IWeapon// - это НЕ наследование, а реализация интерфейсов
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: BowBom");
        }
    }

    //реализуем нож
    class Knife : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: KnifeBom");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: KnifeThrow");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISmall small;

            Player player = new Player();

            IWeapon[] inventory = { new Gun(), new LazerGun(), new Knife() };

            foreach (var item in inventory)
            {
                player.Fire(item);
                Console.WriteLine();
            }

            player.Throw(new Knife());
        }
    }
}
