using System.Collections.Generic;
using System;
using BenchmarkDotNet.Attributes;

namespace SampleExperimentLib
{
    public class SampleExperiment1
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private Random random = new Random();

        [Benchmark]
        [ArgumentsSource(nameof(BenchmarkData))]
        public int Experiment1(int number1, int number2)
        {
            return number1 + number2;
        }

        public IEnumerable<object[]> BenchmarkData()
        {
            yield return new object[] { GetRandomInt(), GetRandomInt() };
            yield return new object[] { GetRandomInt(), GetRandomInt() };
        }

        private string GetRandomString(int numberOfCharacters)
        {

            var result = string.Empty;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                result += alphabet[random.Next(26)];
            }
            return result;
        }

        private int[] GetRandomRange(int numberOfItems, int minValue = 0, int maxValue = 100, bool distinctValues = true)
        {
            int[] result = new int[numberOfItems];

            for (int i = 0; i < numberOfItems; i++)
            {
                var item = random.Next(minValue, maxValue);

                while (result.Contains(item) && distinctValues)
                {
                    item = random.Next(minValue, maxValue);
                }
                result[i] = item;
            }

            Array.Sort(result);

            return result;
        }

        private int GetRandomInt(int minValue = 0, int maxValue = 100) => random.Next(minValue, maxValue);

    }
}
