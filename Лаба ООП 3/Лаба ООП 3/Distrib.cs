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

        public static uint Get(uint PassengerCount, double PeakTime, double PeakWidth, uint Minute, uint StationCount)
        {
            LogisticDistribution logis = new LogisticDistribution(PeakTime, PeakWidth);

            uint res = (uint)Math.Round(PassengerCount * logis.ProbabilityDensity(Minute) * 2.0 * RNG.NextDouble() / StationCount);

            logis = null;
            return res;
        }

        public static uint GetAvg(uint PassengerCount, double PeakTime, double PeakWidth, uint Minute, uint StationCount)
        {
            LogisticDistribution logis = new LogisticDistribution(PeakTime, PeakWidth);

            uint res = (uint)Math.Round(PassengerCount * logis.ProbabilityDensity(Minute) / StationCount);

            logis = null;
            return res;
        }
    }
}
