using System.Collections.Generic;

namespace Лаба_ООП_3
{
    public static class Statistics
    {
        // Коллекция с обслуженными клиентами
        static LinkedList<Passenger> ServedPassengers = new LinkedList<Passenger>();

        #region Методы

        // Добавляет пассажира в статистику
        public static void AddStatistics(Passenger p)
        {
            ServedPassengers.AddLast(p);
            ServedCount = ServedPassengers.Count;
        }

        // Считает среднее время ожидания автобуса
        public static void AvgTime(int time, int stations)
        {
            LinkedListNode<Passenger> p = ServedPassengers.First;
            double avgtime = 0;
            for (int i = 0; i < ServedPassengers.Count; i++)
            {
                int ridelength = p.Value.ArrivingStation - p.Value.IncomingStation;
                if (ridelength < 1)
                    ridelength += stations;
                AvgRideLength += ridelength;
                avgtime += p.Value.ArrivingTime - ridelength * time - p.Value.IncomingTime;
                p = p.Next;
            }
            AvgWaitingTime = avgtime / (double)ServedCount;
            AvgRideLength /= (double)ServedCount;
        }

        // Считает выручку за период моделированния
        public static decimal Cost(decimal cost)
        {
            return cost * ServedCount;
        }

        // Сброс всей статистики
        public static void Reset()
        {
            AvgRideLength = 0;
            AvgWaitingTime = 0;
            MaxQueueLenght = 0;
            MaxQueueStation = 0;
            MaxQueueTime = 0;
        }

        // Очищает коллекцию
        public static void Clear()
        {
            ServedPassengers.Clear();
            ServedCount = 0;
        }

        #endregion

        #region Свойства

        // Среднее расстояние поездки
        public static double AvgRideLength { get; set; }

        // Среднее время ожидания автобуса
        public static double AvgWaitingTime { get; set; }

        // Размер максимальной очереди
        public static int MaxQueueLenght { get; set; }

        // Время когда была максимальная очередь
        public static int MaxQueueTime { get; set; }

        // Станция где была максимальная очередь
        public static int MaxQueueStation { get; set; }

        // Общее количество
        public static int Count { get; set; }

        // Количество обслуженных
        public static int ServedCount { get; set; }

        #endregion
    }
}
