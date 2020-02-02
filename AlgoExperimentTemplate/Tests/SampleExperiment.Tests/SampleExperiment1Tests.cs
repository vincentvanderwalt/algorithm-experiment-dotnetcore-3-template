using SampleExperimentLib;
using Xunit;

namespace SampleExperimentTests
{
    public class SampleExperiment1Tests
    {
        private readonly SampleExperiment1 _sampleExperiment1;

        public SampleExperiment1Tests()
        {
            _sampleExperiment1 = new SampleExperiment1();
        }

        [Fact]
        public void Experiment1_ValidInputs_ReturnsSumOfInputs()
        {
            // arrange

            var input1 = 5;
            var input2 = 5;

            var expected = 10;

            // act

            var result = _sampleExperiment1.Experiment1(input1, input2);

            // assert

            Assert.Equal(expected, result);
        }
    }
}
