using System;
using System.Collections.Generic;

namespace Лаба_ООП_3
{
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

        public void SetPassenger(int station, int intime, int outstat)
        {
            Stations[station].Enqueue(new Passenger(intime, station, outstat));
        }

        public Passenger DequeuePassenger(int currentstation)
        {
            if (Stations[currentstation].Count > 0)
                return Stations[currentstation].Dequeue();
            return null;
        }

        public int QueueSize (int i)
        {
            return Stations[i].Count;
        }

        public void Reset()
        {
            for (int i = 0; i < StationsCount; i++)
                Stations[i].Clear();
        }

        public int StationsCount { get; set; }
    }
}
