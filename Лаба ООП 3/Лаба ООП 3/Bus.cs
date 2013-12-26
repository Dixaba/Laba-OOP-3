using System.Collections.Generic;

namespace Лаба_ООП_3
{
    public class Bus
    {
        // Коллекция пассажиров в салоне
        private LinkedList<Passenger> BusContent = new LinkedList<Passenger>();

        // Конструктор
        public Bus()
        {

        }

        #region Методы

        // Автобус по умолчанию
        public void SetBus(int capacity, int time)
        {
            FreeSeat = BusCapacity = capacity;
            RidingTime = time;
            CurrentStation = 0;
        }

        // Добавляет нового пассажира в салон
        public void SetPassenger(Passenger p)
        {
            if (p != null)
            {
                BusContent.AddLast(p);
                FreeSeat--;
            }
        }

        // Движение автобуса
        public void Ride(int count)
        {
            CurrentStation++;
            if (CurrentStation >= count)
                CurrentStation = 0;
        }

        // Высадка всех нужных пассажиров
        public void ThrowPassenger(int time)
        {
            LinkedListNode<Passenger> p = BusContent.First;
            if (p != null) // если салон не пуст
                for (int i = 0; i < BusContent.Count; i++)
                {
                    if (CurrentStation == p.Value.ArrivingStation) // нужный пассажир
                    {
                        p.Value.ArrivingTime = time;
                        Statistics.AddStatistics(p.Value);
                        BusContent.Remove(p);
                        FreeSeat++;
                        p = BusContent.First;
                        i = -1;
                        continue;
                    }
                    p = p.Next;
                }
        }

        // Сброс всех параметров на начальные значения
        public void Reset()
        {
            FreeSeat = BusCapacity;
            BusContent.Clear();
            CurrentStation = 0;
        }

        #endregion

        #region Свойства

        // Количество свободных мест
        public int FreeSeat { get; set; }

        // Текущщая остановка
        public int CurrentStation { get; set; }

        // Время движения между остановками
        public int RidingTime { get; set; }

        // Вместимость салона
        public int BusCapacity { get; set; }

        #endregion
    }
}