using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotSystem.Algorithm
{
    public class ParkingException :Exception
    {
        public ParkingException(string errorMsg):base(errorMsg) { }
    }

    public class SpotNotAvailableException : ParkingException
    {
        public SpotNotAvailableException():base("This spot is not available")
        {

        }
    }

    public class ParkingTypeWrong : ParkingException
    {
        public ParkingTypeWrong():base("This vehicle")
        {

        }
    }

    public class ParkingLotStatusException : ParkingException
    {
        public ParkingLotStatusException(string warningMsg) : base(warningMsg)
        {

        }
    }
}
