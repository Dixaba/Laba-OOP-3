using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_ООП_3
{
    class Statistics
    {
        List<Passenger> ServedPassengers;

        #region

        Double AvgRideLength { get; set; }

        Double AvgWaitingTime { get; set; }

        Double AvgQueueLenghtAtPeak { get; set; }

        UInt32 MaxQueueLenght { get; set; }

        UInt32 MaxQueueTime { get; set; }

        UInt32 MaxQueueStation { get; set; }

        UInt32 Count { get; set; }

        UInt32 ServedCount { get; set; }

        #endregion
    }
}
