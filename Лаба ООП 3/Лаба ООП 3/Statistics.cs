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

        private static double ServedPass()
        {
            return (double)ServedCount / (double)Count;
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

        #region Свойства

        static double AvgRideLength { get; set; }

        public static double AvgWaitingTime { get; set; }

        static double AvgQueueLenghtAtPeak { get; set; }

        static int MaxQueueLenght { get; set; }

        static int MaxQueueTime { get; set; }

        static int MaxQueueStation { get; set; }

        public static int Count { get; set; }

        public static int ServedCount { get; set; }

        #endregion
    }
}
