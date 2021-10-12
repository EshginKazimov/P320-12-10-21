using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Ship : Transport
    {
        public int FloorCount;

        public Ship(int year, int weight, int maxSpeed, int floorCount) : base(year, weight, maxSpeed)
        {
            FloorCount = floorCount;
        }

        public override string GetFullInfo()
        {
            return $"{base.GetFullInfo()} {FloorCount}";
        }

        private void Print()
        {

        }
    }
}
