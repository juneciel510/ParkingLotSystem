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

        public void ParkMotorcycle(int spotNumber)

        {
            _parkingLotData.ModifyData(spotNumber, VehicleType.Motorcycle);
        }

        public void Leave(int spotNumber, VehicleType vehicle)
        {

        }
    }
}
