using System;
using LegoMiniFigures.Heads;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ConstructionWorkerHead();
            head.Color = LegoColor.Yellow;

            head.SayHi();

            var batman = new BatmanHead();
            batman.Color = LegoColor.Orange;

            batman.SayHi();

        }
    }
}
