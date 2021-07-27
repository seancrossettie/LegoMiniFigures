using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Heads
{
    abstract class HeadBase
    {
        public LegoColor Color { get; set; }

        public virtual void SayHi()
        {
            Console.WriteLine("Hi.");
        }

        public abstract void Spin();
    }
}
