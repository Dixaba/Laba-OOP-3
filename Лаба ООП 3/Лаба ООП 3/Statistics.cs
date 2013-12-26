using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_ООП_3
{
    public static class Statistics
    {
        static LinkedList<Passenger> ServedPassengers = new LinkedList<Passenger>();

        public static void AddStatistics(Passenger p)
        {
            ServedPassengers.AddLast(p);
            ServedCount = ServedPassengers.Count;
        }

        public static void Clear()
        {
            ServedPassengers.Clear();
            ServedCount = 0;
        }

        public static void AvgTime(int time, int stations)
        {
            LinkedListNode<Passenger> p = ServedPassengers.First;
            double avgtime = 0;
            for (int i = 0; i <= ServedPassengers.Count - 1; i++)
            {
                int ridelength = p.Value.ArrivingStation - p.Value.IncomingStation;
                if (ridelength < 1)
                    ridelength += stations;
                avgtime += p.Value.ArrivingTime - ridelength * time - p.Value.IncomingTime;

                p = p.Next;
            }
            AvgWaitingTime = avgtime / (double)ServedCount;
        }

        public static void Reset()
        {
            AvgQueueLenghtAtPeak = 0;
            AvgRideLength = 0;
            AvgWaitingTime = 0;
            MaxQueueLenght = 0;
            MaxQueueStation = 0;
            MaxQueueTime = 0;
        }

        public static decimal Cost(decimal cost)
        {
            return cost * ServedCount;
        }

        #region Свойства

        public static double AvgRideLength { get; set; }

        public static double AvgWaitingTime { get; set; }

        public static double AvgQueueLenghtAtPeak { get; set; }

        public static int MaxQueueLenght { get; set; }

        public static int MaxQueueTime { get; set; }

        public static int MaxQueueStation { get; set; }

        public static int Count { get; set; }

        public static int ServedCount { get; set; }

        #endregion
    }
}
