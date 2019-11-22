using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkingStringBuilding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringCat>();
        }
    }

    public class StringCat
    {
        private readonly string theString = "wa3aw";
        private readonly IEnumerable<string> theStrings;

        public StringCat()
        {
            theStrings = Enumerable.Range(0, 99).Select(x => theString);
        }

        [Benchmark]
        public string Join()
        {
            return string.Join(',', theStrings);
        }

        [Benchmark]
        public string Builder()
        {
            var sb = new StringBuilder();
            foreach (var rec in theStrings) sb.Append($"'{rec}',");
            return sb.ToString().Substring(0, sb.Length - 1);
        }
    }
}