using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Heads
{
    class AstronautHead : HeadBase
    {
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }

        public override void Spin()
        {
            Console.WriteLine("The Astronaut spins to take in the beauty of the cosmos...");
        }

        public void Shave()
        {
            Console.WriteLine($"The Astronaut shaves its {FacialHair}");
            FacialHair = FacialHair.None;
        }
    }
}
