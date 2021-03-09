using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    class ITBob : Driver
    {
        public ITBob(RaceCar car) : base(car)
        {
            Name = "IT Bob";
            SkillLevel = 3;
        }
        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
