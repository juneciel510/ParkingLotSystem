using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Algorithm
{
    public class ParkingLotData
    {
        public Dictionary<int, SpotBase> _spots;
        public ParkingLotData(Dictionary<int, SpotBase> spots) { _spots = spots; }
        


        public void ModifyData(int spotNumber, VehicleType vehicle)
        {
            {
                if (!_spots.TryGetValue(spotNumber, out SpotBase spot))
                    throw new ParkingException("No such spot number exists in data base");
                if(spot.Vehicle!=VehicleType.None)
                    throw new ParkingException($"This spot(No.{spotNumber})  is taken, please check.");
                if (!spot.CanPark(vehicle))
                    throw new ParkingException($"This spot(No.{spotNumber})  does not fit the vehicle, please check.");

                spot.Vehicle = vehicle;

                string msg = vehicle == VehicleType.None ? "The vehicle left" : "The vehicle was successfully parked";
                Console.WriteLine(msg);

                CheckParikingLotStatus();

            }
        }

        public void CheckParikingLotStatus()
        {
            var emptySpotNumber = _spots.Where(pair => pair.Value.Vehicle == VehicleType.None).Count();
            if (emptySpotNumber == 0)
            {
                throw new ParkingException("The parking slot is full");
            }
            if (emptySpotNumber == _spots.Count)
            {
                throw new ParkingException("The parking slot is empty");
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
