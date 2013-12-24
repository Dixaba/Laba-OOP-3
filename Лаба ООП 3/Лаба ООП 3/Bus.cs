using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_ООП_3
{
    public class Bus
    {
        LinkedList<Passenger> BusContent;
        public Bus()
        {
            CurrentStation = 0;
        }

        public void SetBus(int capacity, int time)
        {
            BusCapacity = capacity;
            BusContent = new LinkedList<Passenger>();
            RidingTime = time;
        }

        public void Ride(int count)
        {
            CurrentStation++;
            if (CurrentStation > count)
                CurrentStation = 0;
        }

        public List<Passenger> ThrowPassengers()
        {
            List<Passenger> Throw = new List<Passenger>();
            LinkedListNode<Passenger> p = BusContent.Last;
            for (int i = BusContent.Count - 1; i >= 0; i--)
            {
                if (CurrentStation == p.Value.ArrivingStation)
                {
                    Throw.Add(p.Value);
                }
                p = p.Previous;
            }
            return Throw;
        }

        public void SetPassenger(Passenger p)
        {
            BusContent.AddLast(p);
        }

        #region Свойства

        int CurrentStation { get; set; }

        public int RidingTime { get; set; }

        public int BusCapacity { get; set; }

        #endregion
    }
}