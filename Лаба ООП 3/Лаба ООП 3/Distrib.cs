using System;
using Meta.Numerics.Statistics.Distributions;

namespace Лаба_ООП_3
{
    static class Distrib
    {
        // Объект класса Random
        private static Random RNG = new Random();

        // Сумма без округления
        private static double IdealSum = 0;

        // Сумма после округления
        private static int RealSum = 0;

        // Вспомогательная переменная
        private static int rand = 0;

        #region Методы

        // Округленное количество людей для одной остановки с рандомом
        public static int Get(int PassengerCount, double PeakTime, double PeakWidth, int Minute, int StationCount)
        {
            LogisticDistribution logis = new LogisticDistribution(PeakTime, PeakWidth);

            double value = PassengerCount * logis.ProbabilityDensity(Minute) * 2.02 * RNG.NextDouble() / StationCount;

            int res = (int)Math.Round(value);

            IdealSum += value;
            RealSum += res;

            if (Math.Abs(RealSum - IdealSum) >= 1)
            {
                int corr = (int)(Math.Floor(Math.Abs(RealSum - IdealSum)) * Math.Sign(RealSum - IdealSum));
                IdealSum -= RealSum - corr;
                RealSum = 0;
                res -= corr;
            }

            logis = null;
            return res;
        }

        // Идеальное количество людей для остановки без округления
        public static double GetAvg(int PassengerCount, double PeakTime, double PeakWidth, int Minute, int StationCount)
        {
            LogisticDistribution logis = new LogisticDistribution(PeakTime, PeakWidth);

            double res = PassengerCount * logis.ProbabilityDensity(Minute) / StationCount;

            logis = null;
            return res;
        }

        // Устанвливает пассажиру станцию прихода
        public static int SetPassengerToStation(int StationCount)
        {
            rand = RNG.Next(0, StationCount);
            return rand;
        }

        // Устанавливает пассажиру станцию выхода
        public static int OutStation(int StationCount)
        {
            int r;
            do
                r = RNG.Next(0, StationCount);
            while (rand == r);
            return r;
        }

        #endregion
    }
}
