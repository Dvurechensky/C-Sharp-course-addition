using BenchmarkDotNet.Attributes;
using Lesson_81_B___Benchmark_DotNet_;

namespace Benchmark
{
    [MemoryDiagnoser]//по мимо быстродействия тестируем использование памяти
    [RankColumn]//добавляет оценку для тестируемых методов (на основании бенчмарка) - чтобы понять какой метод лучше (не обязательно)
    public class MyParserBenchmark
    {
        private const string STRING_TO_PARSE_WITH_ERROR = "qwerty22";
        private const string STRING_TO_PARSE = "54";

        private readonly MyParser _myParser = new MyParser();

        [Benchmark]//метка что именно эти методы мы хотим тестировать
        public void TryCathParseTestWithError()
        {
            int result = _myParser.TryCathParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]//метка что именно эти методы мы хотим тестировать
        public void TryParseTestWithError()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]//метка что именно эти методы мы хотим тестировать
        public void TryCathParseTest()
        {
            int result = _myParser.TryCathParse(STRING_TO_PARSE);
        }

        [Benchmark]//метка что именно эти методы мы хотим тестировать
        public void TryParseTest()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE);
        }

        [Benchmark]//метка что именно эти методы мы хотим тестировать
        public void TryParseFixedTestWithError()
        {
            int result = _myParser.TryParseFixed(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]//метка что именно эти методы мы хотим тестировать
        public void TryParseFixedTest()
        {
            int result = _myParser.TryParseFixed(STRING_TO_PARSE);
        }
    }
}
