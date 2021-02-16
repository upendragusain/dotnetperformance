using App;
using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class StringBenchmarks
    {
        private const string FullName = "Upendra Singh gusain";
        private static readonly JustStringThings justStringThings = new JustStringThings();

        [Benchmark(Baseline = true)]
        public void GetLastName()
        {
            justStringThings.GetLastName(FullName);
        }

        [Benchmark]
        public void GetLastNameUsingSubstring()
        {
            justStringThings.GetLastNameUsingSubstring(FullName);
        }

        [Benchmark]
        public void GetLastNameWithSpan()
        {
            justStringThings.GetLastNameWithSpan(FullName);
        }
    }
}
