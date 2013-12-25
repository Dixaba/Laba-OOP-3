using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_ООП_3
{
    public static class Statistics
    {
        static List<Passenger> ServedPassengers = new List<Passenger>();

        public static void AddStatistics(List<Passenger> p)
        {
            if (p.Count > 0)
                ServedPassengers.AddRange(p);
            ServedCount = ServedPassengers.Count;
        }

        public static void Clear()
        {
            ServedPassengers.Clear();
            ServedCount = 0;
        }

        #region Свойства

        static Double AvgRideLength { get; set; }

        static Double AvgWaitingTime { get; set; }

        static Double AvgQueueLenghtAtPeak { get; set; }

        static int MaxQueueLenght { get; set; }

        static int MaxQueueTime { get; set; }

        static int MaxQueueStation { get; set; }

        static int Count { get; set; }

        public static int ServedCount { get; set; }

        #endregion
    }
}
