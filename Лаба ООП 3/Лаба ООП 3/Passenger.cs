using System;

namespace Лаба_ООП_3
{
    public class Passenger
    {
        public Passenger(int intime, int instat, int outstat)
        {
            IncomingTime = intime;
            IncomingStation = instat;
            ArrivingStation = outstat;
        }

        #region Свойства

        public int IncomingTime { get; set; }

        public int ArrivingTime { get; set; }

        public int IncomingStation { get; set; }

        public int ArrivingStation { get; set; }

        #endregion
    }
}
