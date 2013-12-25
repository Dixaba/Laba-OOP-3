using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_ООП_3
{
    public class Bus
    {
        List<Passenger> Throw = new List<Passenger>();
        LinkedList<Passenger> BusContent;
        public Bus()
        {
            CurrentStation = 0;
        }

        public void SetBus(int capacity, int time)
        {
            FreeSeat = BusCapacity = capacity - 1;
            BusContent = new LinkedList<Passenger>();
            RidingTime = time;
        }

        public void Ride(int count)
        {
            CurrentStation++;
            if (CurrentStation >= count)
                CurrentStation = 0;
        }

        public List<Passenger> ThrowPassengers(int time)
        {
            Throw.Clear();
            LinkedListNode<Passenger> p = BusContent.First;
            if (p != null)
                for (int i = 0; i < BusContent.Count; i++)
                {
                    if (CurrentStation == p.Value.ArrivingStation)
                    {
                        p.Value.ArrivingTime = time;
                        Throw.Add(p.Value);
                        BusContent.Remove(p);
                        FreeSeat++;
                        p = BusContent.First;
                        i = -1;
                        continue;
                    }
                    p = p.Next;
                }
            return Throw;
        }

        public void SetPassenger(Passenger p)
        {
            if (p != null)
            {
                BusContent.AddLast(p);
                FreeSeat--;
            }
        }

        #region Свойства

        public int FreeSeat { get; set; }

        public int CurrentStation { get; set; }

        public int RidingTime { get; set; }

        public int BusCapacity { get; set; }

        #endregion
    }
}