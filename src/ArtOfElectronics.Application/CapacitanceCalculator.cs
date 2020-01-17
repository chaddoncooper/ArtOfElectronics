using System.Collections.Generic;
using System.Linq;

namespace ArtOfElectronics.Application
{
    public class CapacitanceCalculator
    {
        public static float Parallel(IEnumerable<float> capacitor)
        {
            return capacitor.Sum();
        }

        public static float Series(IEnumerable<float> capacitor)
        {
            return (1 / capacitor.Select(x => 1 / x).Sum());
        }
    }
}
