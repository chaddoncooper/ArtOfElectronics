using System.Collections.Generic;
using Xunit;

namespace ArtOfElectronics.Application.Test
{
    public class CapacitanceCalculatorTests
    {
        readonly List<float> TestValues = new List<float>() { 250, 300, 500 };

        [Fact]
        public void Parallel()
        {
            Assert.Equal(1050, CapacitanceCalculator.Parallel(TestValues));
        }

        [Fact]
        public void Series()
        {
            Assert.Equal(107.14285278320312, CapacitanceCalculator.Series(TestValues));
        }
    }
}
