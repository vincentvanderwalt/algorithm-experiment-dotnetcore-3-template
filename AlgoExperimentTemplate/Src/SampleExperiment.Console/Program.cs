using System;
using BenchmarkDotNet.Running;
using SampleExperimentLib;

namespace SampleExperimentBenchmarkConsole
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<SampleExperiment1>();
        }
    }
}
