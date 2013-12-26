using System.Collections.Generic;

namespace Лаба_ООП_3
{
    public class CircularRoute
    {
        // Массив очередей (остоновок)
        Queue<Passenger>[] Stations;

        // Конструктор
        public CircularRoute()
        {

        }

        #region Методы

        // Создает необходимое количество очередей
        public void SetQueues(int statcount)
        {
            StationsCount = statcount;
            Stations = new Queue<Passenger>[StationsCount];
            for (int i = 0; i < StationsCount; i++)
            {
                Stations[i] = new Queue<Passenger>();
            }
        }

        // Добавляет пассажира на одну из остоновок
        public void SetPassenger(int station, int intime, int outstat)
        {
            Stations[station].Enqueue(new Passenger(intime, station, outstat));
        }

        // Посадка пассажира в автобус
        public Passenger DequeuePassenger(int currentstation)
        {
            if (Stations[currentstation].Count > 0)
                return Stations[currentstation].Dequeue();
            return null;
        }

        // Возвращает количество пассажиров на остановке i
        public int QueueSize(int i)
        {
            return Stations[i].Count;
        }

        // Сброс всех значений на начальные
        public void Reset()
        {
            for (int i = 0; i < StationsCount; i++)
                Stations[i].Clear();
        }

        #endregion

        // Количество станций
        public int StationsCount { get; set; }
    }
}
