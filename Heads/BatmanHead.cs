using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Heads
{
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";

        public override void Spin()
        {
            Console.WriteLine("Where is the Joker?");
        }

        public override void SayHi()
        {
            base.SayHi();
            Console.WriteLine("I'm Batman!");
        }
    }
}
