using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Heads
{
    class ConstructionWorkerHead : HeadBase
    {
        public bool HasMullet { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;

            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not")} wearing their hard hat.");

            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0)
                NumberOfTeeth -= 1;
            
            Console.WriteLine($"The {Color} Construction Worker's Head is spinning after getting hit by a girder.");
        }
    }
}
