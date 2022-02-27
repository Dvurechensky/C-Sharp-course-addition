/*
 * модификатор доступа protected при наследовании
 */
namespace Lesson_74___protected___модификатор_доступа_
{
    class Program
    {
        public class A
        {
            public A()
            {
                System.Console.WriteLine(publicField); //поле доступно
                System.Console.WriteLine(protectedField); //поле доступно
                System.Console.WriteLine(privateField); //поле доступно
            }

            public void Bar()
            {
                System.Console.WriteLine("Bar");
                System.Console.WriteLine(publicField); //поле доступно
                System.Console.WriteLine(protectedField); //поле доступно
                System.Console.WriteLine(privateField); //поле доступно
            }

            public int publicField = 4;
            private int privateField = 5;
            //protected работает со всем одинаково(свойства, поля, методы)
            //protected - внутри класса доступны, снаружи класса не доступны (разница в наследовании)
            protected int protectedField = 6;
            private protected int privateprotectedField = 7;

            protected void Foo() { }
            protected int MyProperty { get; set; }
        }

        class B : A
        {
            public B()
            {
                System.Console.WriteLine("B");
                System.Console.WriteLine(publicField); //поле доступно
                //System.Console.WriteLine(privateField); //поле не доступно в наследнике
                System.Console.WriteLine(protectedField); //поле доступно в наследнике, но не доступно за пределами класса(или его наследников)

                Bar();
            }

            public void Cas()
            {
                Bar();
            }
        }

        static void Main(string[] args)
        {
            A a = new A();
            System.Console.WriteLine(a.publicField); //поле доступно
            //System.Console.WriteLine(a.protectedField)  поле не доступно из-за уровня защиты
            //System.Console.WriteLine(a.privateField)  поле не доступно из-за уровня защиты\

            B b = new B();
            System.Console.WriteLine(b.publicField); //поле доступно
            //System.Console.WriteLine(b.protectedField)  поле не доступно из-за уровня защиты
            //System.Console.WriteLine(b.privateField)  поле не доступно из-за уровня защиты
            b.Bar(); 
        }
    }
}
