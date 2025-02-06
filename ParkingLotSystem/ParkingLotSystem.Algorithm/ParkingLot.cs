using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Algorithm
{
    public class ParkingLot
    {
        ParkingLotData _parkingLotData;
        public ParkingLot(ParkingLotData parkingLotData) 
        { 
            _parkingLotData = parkingLotData; 
            _parkingLotData.CheckParikingLotStatus();
        }

        public void MotorcyclePark(int spotNumber)

        {
            _parkingLotData.ModifyData(spotNumber, VehicleType.Motorcycle);
        }

        public void CarPark(int spotNumber)

        {
            _parkingLotData.ModifyData(spotNumber, VehicleType.Car);
        }

        public void VanPark(int[] spotNumbers)
        {
            if(spotNumbers.Length !=3) { throw new ParkingException("To park a van will need 3 spots, please check."); }
            _parkingLotData.ModifyData(spotNumbers, VehicleType.Van);
        }

        public void MotorcycleOrCarLeave(int spotNumber)
        {
            _parkingLotData.ModifyData(spotNumber, VehicleType.None);
        }

        public void VanLeave(int[] spotsNumber)
        {
            _parkingLotData.ModifyData(spotsNumber, VehicleType.None);
        }
    }
}
