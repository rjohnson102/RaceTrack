using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    class Audi : RaceCar
    {

        public Audi()
        {
            Name = "Audi";
            TopSpeed = 200;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }
    }
}
