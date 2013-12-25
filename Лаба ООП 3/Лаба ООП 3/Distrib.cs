using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meta.Numerics.Statistics.Distributions;

namespace Лаба_ООП_3
{
    static class Distrib
    {
        private static Random RNG = new Random();

        private static double IdealSum = 0;

        private static int RealSum = 0;

        public static int Get(int PassengerCount, double PeakTime, double PeakWidth, int Minute, int StationCount)
        {
            LogisticDistribution logis = new LogisticDistribution(PeakTime, PeakWidth);

            double value = PassengerCount * logis.ProbabilityDensity(Minute) * 2.02 * RNG.NextDouble() / StationCount;

            int res = (int)Math.Round(value);

            IdealSum += value;
            RealSum += res;

            if (Math.Abs(RealSum - IdealSum) >= 1)
            {
                int corr= (int)(Math.Floor(Math.Abs(RealSum - IdealSum)) * Math.Sign(RealSum - IdealSum));
                IdealSum -= RealSum-corr;
                RealSum = 0;
                res -= corr;
            }

            logis = null;
            return res;
        }

        public static double GetAvg(int PassengerCount, double PeakTime, double PeakWidth, int Minute, int StationCount)
        {
            LogisticDistribution logis = new LogisticDistribution(PeakTime, PeakWidth);

            double res = PassengerCount * logis.ProbabilityDensity(Minute) / StationCount;

            logis = null;
            return res;
        }
    }
}
