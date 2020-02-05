using System.Collections.Generic;
using System;
using BenchmarkDotNet.Attributes;

namespace SampleExperimentLib
{
    public class SampleExperiment1
    {
        private Random random = new Random();

        [Benchmark]
        [ArgumentsSource(nameof(BenchmarkData))]
        public int Experiment1(int number1, int number2)
        {
            return number1 + number2;
        }

        public IEnumerable<object[]> BenchmarkData()
        {
            yield return new object[] { new int[] { 2, 1, 5, 1, 3, 2 }, 3 };
            yield return new object[] { GetRandomRange(10), 3 };
        }

        private int[] GetRandomRange(int numberOfItems, int minValue = 0, int maxValue = 100)
        {
            int[] result = new int[numberOfItems];

            for (int i = 0; i < numberOfItems; i++)
            {
                result[i] = random.Next(minValue, maxValue);
            }

            return result;
        }

        private int GetRandomInt(int minValue = 0, int maxValue = 100) => random.Next(minValue, maxValue);

    }
}
