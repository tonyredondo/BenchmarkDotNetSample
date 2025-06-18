using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

// Execute the benchmarks in the MyBenchmarks class
BenchmarkRunner.Run<MyBenchmarks>();


/// <summary>
/// Benchmark class for testing performance.
/// </summary>
public class MyBenchmarks
{
    /// <summary>
    /// Benchmark method that simulates some work.
    /// </summary>
    [Benchmark]
    public void BenchmarkMethod()
    {
        // Simulate some work
        for (int i = 0; i < 1000; i++)
        {
            var temp = Math.Sqrt(i);
        }
    }
}