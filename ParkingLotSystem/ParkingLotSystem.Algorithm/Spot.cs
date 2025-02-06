using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Algorithm
{
    public abstract class SpotBase
    {
        public SpotType Type { get; set; }
        public int Number { get; set; }
        public VehicleType Vehicle { get; set; }
        protected SpotBase(int spotNumber, SpotType spotType) { Number = spotNumber; Type = spotType; }
        public abstract bool CanPark(VehicleType vehicle);
    }

    public class CompactSpot: SpotBase
    {
        public CompactSpot(int spotNumber) :base(spotNumber, SpotType.Compact) { }

        public override bool CanPark(VehicleType vehicle)
        {
            if(vehicle==VehicleType.Van) return false;
            return true;
        }
    }

    public class RegularSpot : SpotBase
    {
        public RegularSpot(int spotNumber) : base(spotNumber, SpotType.Regular)
        {
        }

        public override bool CanPark(VehicleType vehicle)
        {
            return true;
        }
    }
}
