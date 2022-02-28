using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using Lesson_81___Структуры_и_классы___отличия__struct_vs_class_;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark_1
    {
        [Benchmark]
        public void StructTest()
        {
            StructPoint structPoint = new StructPoint()
            {
                X = 1,
                Y = 2
            };
            var result = structPoint.X = structPoint.Y;
        }

        [Benchmark]
        public void ClassTest()
        {
            ClassPoint classPoint = new ClassPoint()
            {
                X = 1,
                Y = 2
            };
            var result = classPoint.X = classPoint.Y;
        }
    }

    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark_2
    {
        [Benchmark]
        public void StructArrayTest()
        {
            StructPoint[] structPoints = new StructPoint[100];
            //частично находится в куче
            //в массиве через каждый интервал который отвечает
            //размеру минимального элемента находятся реальные данные структуры
            //разница в быстродействии в том, что мы выделяем память в управляемой куче лишь единожды для массива структур
            for (int i = 0; i < structPoints.Length; i++)
            {
                structPoints[i] = new StructPoint();
            }
        }

        [Benchmark]
        public void ClassArrayTest()
        {
            //в начале в куче создается сам массив
            //но для каждого объекта класса есть ссылка которую мы помещаем в массив и по каждой ссылке нужно запросить данные из кучи
            ClassPoint[] classPoints = new ClassPoint[100];
            //в массиве находятся не реальные данные а ссылки на данные
            for (int i = 0; i < classPoints.Length; i++)
            {
                classPoints[i] = new ClassPoint();
            }
        }
    }

    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark_3
    {
        struct MyStruct
        {
            public decimal MyProperty1 { get; set; }
            public decimal MyProperty2 { get; set; }
            public decimal MyProperty3 { get; set; }
            public decimal MyProperty4 { get; set; }
            public decimal MyProperty5 { get; set; }
            public decimal MyProperty6 { get; set; }
            public decimal MyProperty7 { get; set; }
            public decimal MyProperty8 { get; set; }
            public decimal MyProperty9 { get; set; }
            public decimal MyProperty10 { get; set; }
        }

        class MyClass
        {
            public decimal MyProperty1 { get; set; }
            public decimal MyProperty2 { get; set; }
            public decimal MyProperty3 { get; set; }
            public decimal MyProperty4 { get; set; }
            public decimal MyProperty5 { get; set; }
            public decimal MyProperty6 { get; set; }
            public decimal MyProperty7 { get; set; }
            public decimal MyProperty8 { get; set; }
            public decimal MyProperty9 { get; set; }
            public decimal MyProperty10 { get; set; }
        }

        private MyStruct _myStruct = new MyStruct();
        private MyClass _myClass = new MyClass();

        private void Foo(MyClass myClass)
        {
            var t = myClass.MyProperty1 + myClass.MyProperty2;
        }

        private void Bar(MyStruct myStruct)
        {
            var t = myStruct.MyProperty1 + myStruct.MyProperty2;
        }

        private void BarIn(in MyStruct myStruct)
        {
            var t = myStruct.MyProperty1 + myStruct.MyProperty2;
        }

        [Benchmark]
        public void StructTest()
        {
            Bar(_myStruct);
        }

        [Benchmark]
        public void StructTestIn()
        {
            BarIn(_myStruct);
        }

        [Benchmark]
        public void ClassTest()
        {
            Foo(_myClass);
        }
    }

    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark_4
    {
        [Benchmark]
        public void NoBoxing()
        {
            int res = 0;
            double a = 1;
            res += (int)a;
        }

        [Benchmark]
        public void Boxing()
        {
            int res = 0;
            object a = 1;
            res += (int)a;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<MyParserBenchmark>();
            //BenchmarkRunner.Run<Benchmark_1>();
            //BenchmarkRunner.Run<Benchmark_2>();
            //BenchmarkRunner.Run<Benchmark_3>();
            BenchmarkRunner.Run<Benchmark_4>();
        }
    }
}
