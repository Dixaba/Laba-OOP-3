using System;

namespace Лаба_ООП_3 
{
    public class Passenger
    {
        public Passenger(UInt32 intime, UInt32 instat, UInt32 outstat)
        {
            IncomingTime = intime;
            IncomingStation = instat;
            ArrivingStation = outstat;
        }

        #region Свойства
        
        UInt32 IncomingTime { get; set; }

        UInt32 ArrivingTime { get; set; }

        UInt32 IncomingStation { get; set; }

        UInt32 ArrivingStation { get; set; }

        #endregion
    }
}
