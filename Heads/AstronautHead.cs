using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Heads
{
    class AstronautHead
    {
        public LegoColor Color { get; set; }
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Major Tom to ground control...");
        }

        public void Spin()
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
