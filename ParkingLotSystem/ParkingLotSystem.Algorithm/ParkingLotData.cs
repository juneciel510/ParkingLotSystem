using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Algorithm
{
    public class ParkingLotData
    {
        public Dictionary<int, SpotBase> _parkingLot;
        public ParkingLotData(Dictionary<int, SpotBase> spots) { _parkingLot = spots; }


        public void ModifyData(int spotNumber, VehicleType vehicle)
        {
            {
                if (!_parkingLot.TryGetValue(spotNumber, out SpotBase spot))
                    throw new ParkingException("No such spot number exists in data base");
                if(spot.Vehicle!=VehicleType.None)
                    throw new ParkingException($"This spot(No.{spotNumber})  is taken, please check.");
                if (!spot.CanPark(vehicle))
                    throw new ParkingException($"This spot(No.{spotNumber})  does not fit the vehicle, please check.");

                spot.Vehicle = vehicle;

                string msg = vehicle == VehicleType.None ? "The vehicle left" : "The vehicle was successfully parked";
                Console.WriteLine(msg);

                CheckLotFullOrEmpty();

            }
        }

        public void ModifyData(int[] spotNumber, VehicleType vehicle)
        {
            for (int i = 0; i < spotNumber.Length; i++)
            {
                ModifyData(spotNumber[i], vehicle);
            }
        }

        public void CheckLotFullOrEmpty()
        {
            if (IsLotFull()) 
            {
                throw new ParkingException("The parking slot is full");
            }
            if (IsLotEmpty())
            {
                throw new ParkingException("The parking slot is empty");
            }
        }

        public int CheckEmptySpots()
        {
            return CheckSpotsTakenByCertainCarType(VehicleType.None);
        }


        public int CheckSpotsInTotal()
        {
            return _parkingLot.Count();
        }

        public int CheckSpotsTakenByCertainCarType(VehicleType vehicle)
        {
            return _parkingLot.Where(pair => pair.Value.Vehicle == vehicle).Count();
        }

        public int CheckSpotsTakenByVan()
        {
            return CheckSpotsTakenByCertainCarType(VehicleType.Van);
        }

        public bool CheckMotoCycleOrCarSpotsFull()
        {
            return _parkingLot.Where(pair => pair.Value.Vehicle == VehicleType.None).Count()==0;
        }
        public bool CheckVanSpotsFull()
        {
            return _parkingLot.Where(pair => pair.Value.Vehicle == VehicleType.None&& pair.Value.Type==SpotType.Regular).Count() <3;
        }

        public bool IsLotFull()
        {
            return CheckEmptySpots() == 0;
        }

        public bool IsLotEmpty()
        {
            return CheckEmptySpots() == _parkingLot.Count;
        }

    }
}
