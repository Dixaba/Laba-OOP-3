using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_ООП_3
{
    public class Bus
    {
        List<Passenger> BusContent;

        public Bus(UInt32 capacity)
        {
            BusCapacity = capacity;
            BusContent = new List<Passenger>((int)BusCapacity);
        }

        #region Свойства

        UInt32 CurrentStation { get; set; }

        public UInt32 RidingTime { get; set; }

        public UInt32 BusCapacity { get; set; }

        #endregion
    }
}