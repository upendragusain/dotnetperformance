using App;
using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class StringBenchmarks
    {
        private const string FullName = "Upendra Singh gusain";
        private static readonly WithStrings Parser = new WithStrings();

        [Benchmark(Baseline = true)]
        public void GetLastName()
        {
            Parser.GetLastName(FullName);
        }
    }
}
