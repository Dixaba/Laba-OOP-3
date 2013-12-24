using System;
using System.Collections.Generic;

namespace Лаба_ООП_3{

    public class CircularRoute
    {
        Queue<Passenger>[] Stations;

        public CircularRoute()
        {
            
        }

        public void SetQueues(int statcount)
        {
            StationsCount = statcount;
            Stations = new Queue<Passenger>[StationsCount];
            for (int i = 0; i < StationsCount; i++)
            {
                Stations[i] = new Queue<Passenger>();
            }
        }

       public int StationsCount { get; set; }
    }
}
