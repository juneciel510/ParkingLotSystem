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
        private int _spotNumber;
        public VehicleType Vehicle { get; set; }
        public int SpotNumber { get => _spotNumber; }
        protected SpotBase(int spotNumber) { _spotNumber= spotNumber; }
    }

    public class CompactSpot: SpotBase
    {
        public CompactSpot(int spotNumber) :base(spotNumber) { }
    }

    public class RegularSpot : SpotBase
    {
        public RegularSpot(int spotNumber) : base(spotNumber)
        {
        }
    }
}
