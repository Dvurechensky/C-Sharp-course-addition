using System;

namespace Lesson_83___Обобщения__generic_типы__методы_и_классы_
{
    class MyList<T>
    {
        private T[] _array = Array.Empty<T>();
        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public int Count { get { return _array.Length; } }


        public void Add(T value)
        {
            var newArray = new T[_array.Length + 1];
            for(int el = 0; el < _array.Length; el++)
            {
                newArray[el] = _array[el];
            }
            newArray[_array.Length] = value;

            _array = newArray;
        }
    }
}
