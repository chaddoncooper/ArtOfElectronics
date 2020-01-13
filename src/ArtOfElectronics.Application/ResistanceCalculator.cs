using System.Collections.Generic;
using System.Linq;

namespace ArtOfElectronics.Application
{
    public class ResistanceCalculator
    {
        public static float Series(IEnumerable<float> resistorValues)
        {
            return resistorValues.Sum();
        }

        public static float Parallel(IEnumerable<float> resistorValues)
        {
            return (1 / resistorValues.Select(x => 1 / x).Sum());
        }
    }
}
