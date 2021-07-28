using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures.Legs
{
    class SeaLegs : LegBase
    {
        public bool AreWobbly { get; set; }
        public int NumberOfLegs { get; set; }

        public void Swim()
        {
            Console.WriteLine("Im a certified Swimmer");
        }
        public override void Walk()
        {
            Console.WriteLine("I can walk on water");
        }
    }
}
