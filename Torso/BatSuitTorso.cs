using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Torso
{
    class BatSuitTorso : TorsoBase
    {
        public bool HasBoomerang { get; set; }
        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("*Fist bumps*");
        }

        public override void Wiggle()
        {
            Console.WriteLine("Flex on em");
        }

        public void MakeArrest()
        {
            Console.WriteLine("You have been arrested!");
        }

    }
}
