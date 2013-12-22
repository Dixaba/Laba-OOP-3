using System;
using System.Collections.Generic;

namespace Лаба_ООП_3
{
    public class CircularRoute
    {
        Queue<Passenger>[] Stations;

        public CircularRoute(UInt32 statcount)
        {
            Stations = new Queue<Passenger>[StationsCount];
            StationsCount = statcount;
            for (int i = 0; i <= StationsCount; i++)
            {
                Stations[i] = new Queue<Passenger>();
            }
        }

       public UInt32 StationsCount { get; set; }
    }
}
