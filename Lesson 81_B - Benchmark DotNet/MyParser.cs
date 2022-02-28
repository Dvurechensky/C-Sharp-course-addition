using System;

namespace Lesson_81_B___Benchmark_DotNet_
{
    public class MyParser
    {
        public int TryCathParse(string str)
        {
            //здесь нечего логировать и соответсвенно это бесполезная вещь
            try
            {
                return int.Parse(str);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int TryParse(string str)
        {
            int result;

            if (!int.TryParse(str, out result))
                result = 0;

            return result;
        }

        public int TryParseFixed(string str)
        {
            int.TryParse(str, out int result);
            return result;
        }
    }
}
