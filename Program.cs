using System;
using System.Collections.Generic;
using LegoMiniFigures.Heads;
using LegoMiniFigures.Torso;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var constructionWorkerHead = new ConstructionWorkerHead();
            constructionWorkerHead.Color = LegoColor.Yellow;

            var batman = new BatmanHead();
            batman.Color = LegoColor.Orange;

            var astronaut = new AstronautHead();

            var heads = new List<HeadBase>() { constructionWorkerHead, batman, astronaut };

            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }

            var batmanTorso = new BatSuitTorso();
            batmanTorso.Color = LegoColor.Black;
            batmanTorso.HasBoomerang = true;
            batmanTorso.HasShirt = true;
            batmanTorso.MakeArrest();

            var cowboyTorso = new CowboyTorso();
            var sumoTorso = new SumoTorso();

            var torsos = new List<TorsoBase> { batmanTorso, cowboyTorso, sumoTorso };

            foreach (var torso in torsos)
            {
                torso.Wiggle();
                torso.Greeting();
            }
        }
    }
}
