using System;

namespace Лаба_ООП_3
{
    public class Passenger
    {
        //Конструктор пассажиров 
        //Устанавливает время прихода, станцию прихода и выхода
        public Passenger(int intime, int instat, int outstat)
        {
            IncomingTime = intime;
            IncomingStation = instat;
            ArrivingStation = outstat;
        }

        #region Свойства

        // Время прихода
        public int IncomingTime { get; set; }

        // Время выхода
        public int ArrivingTime { get; set; }

        // Станция посадки
        public int IncomingStation { get; set; }

        // Станция выхода
        public int ArrivingStation { get; set; }

        #endregion
    }
}
