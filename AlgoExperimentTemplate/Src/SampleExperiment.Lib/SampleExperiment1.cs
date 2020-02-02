using BenchmarkDotNet.Attributes;

namespace SampleExperimentLib
{
    public class SampleExperiment1
    {
        [Benchmark]
        [Arguments(5, 5)]
        public int Experiment1(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
