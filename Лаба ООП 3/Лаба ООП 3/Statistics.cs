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
            ServedCount++; ;
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
            int avgtime = 0;
            for (int i = 0; i <= ServedPassengers.Count - 1; i++)
            {
                if (p.Value.ArrivingStation - p.Value.IncomingStation > 0)
                    avgtime += p.Value.ArrivingTime - (p.Value.ArrivingStation - p.Value.IncomingStation) * time - p.Value.IncomingTime;
                else
                    avgtime += p.Value.ArrivingTime - (p.Value.ArrivingStation - p.Value.IncomingStation + stations) * time -
                        p.Value.IncomingTime;
            }
            AvgWaitingTime = avgtime / (double)ServedCount;
        }

        #region Свойства

        static Double AvgRideLength { get; set; }

        public static Double AvgWaitingTime { get; set; }

        static Double AvgQueueLenghtAtPeak { get; set; }

        static int MaxQueueLenght { get; set; }

        static int MaxQueueTime { get; set; }

        static int MaxQueueStation { get; set; }

        public static int Count { get; set; }

        public static int ServedCount { get; set; }

        #endregion
    }
}
