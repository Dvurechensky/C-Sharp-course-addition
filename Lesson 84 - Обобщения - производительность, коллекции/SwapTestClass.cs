namespace Lesson_84___Обобщения___производительность__коллекции_
{
    public class SwapTestClass
    {
        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
    }
}
