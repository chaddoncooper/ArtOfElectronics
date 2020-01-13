using System.Collections.Generic;
using Xunit;

namespace ArtOfElectronics.Application.Test
{
    public class ResistanceCalculatorTests
    {
        readonly List<float> TestValues = new List<float>() { 56, 33, 1000 };

        [Fact]
        public void Parallel()
        {
            Assert.Equal(20.3416690826416, ResistanceCalculator.Parallel(TestValues));
        }

        [Fact]
        public void Series()
        {
            Assert.Equal(1089, ResistanceCalculator.Series(TestValues));
        }
    }
}
