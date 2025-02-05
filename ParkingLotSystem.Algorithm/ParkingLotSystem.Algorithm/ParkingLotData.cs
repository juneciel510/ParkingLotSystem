using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Algorithm
{
    public class ParkingLotData
    {
        public Dictionary<int, SpotBase> _parkingLotData;
        public ParkingLotData(Dictionary<int, SpotBase> parkingLotData) { _parkingLotData = parkingLotData; }
        

        public void ModifyData(int spotNumber, VehicleType vehicle)
        {
            {

                if (_parkingLotData.TryGetValue(spotNumber, out SpotBase spot))
                { spot.Vehicle = vehicle; }
                else
                    throw new ParkingException("No such spot number exists in data base");
                var emptySpotNumber=_parkingLotData.Where(pair=>pair.Value.Vehicle==VehicleType.None).Count();
                if (emptySpotNumber == 0)
                {
                    throw 
                }
            }
        }

        public void ModifyData(int[] spotNumber, VehicleType vehicle)
        {
            for (int i = 0; i < spotNumber.Length; i++)
            {
                ModifyData(spotNumber[i], vehicle);
            }
        }
    }
}
