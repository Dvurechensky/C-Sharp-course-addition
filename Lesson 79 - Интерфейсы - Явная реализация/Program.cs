using System;
/*
 * явная реализация интерфейсов
 */
namespace Lesson_79___Интерфейсы___Явная_реализация_
{
    //класс может реализовать интерфейсы с одинаковыми методыми
    //если нам нужна разная реализация для этих методов, то интерфейсы нужно реализовать явно 
    interface IFirstInterface
    {
        void Action();
    }

    interface ISecondInterface
    {
        void Action();
    }

    class Actions : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine($"{GetType().Name}: Action");
        }
    }

    //для таких случаев нужно использовать явную реализацию интерфейсов
    class OtherAction : IFirstInterface, ISecondInterface
    {
        //модификаторы ставить нельзя из-за неоднозначности и отсутствия ссылки на интерфейс
        void IFirstInterface.Action()
        {
            Console.WriteLine($"IFirstInterface Action");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine($"ISecondInterface Action");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Actions act = new Actions();
            
            Action_1(act);
            Action_2(act);

            OtherAction otherAction = new OtherAction();

            Action_1(otherAction);
            Action_2(otherAction);

            ((IFirstInterface)otherAction).Action();
            ((ISecondInterface)otherAction).Action();

            //более безопасный с операторами as или is
            if (otherAction is IFirstInterface firstInterface)
                firstInterface.Action();
            if (otherAction is ISecondInterface secondInterface)
                secondInterface.Action();
        }

        public static void Action_1(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }

        public static void Action_2(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}
