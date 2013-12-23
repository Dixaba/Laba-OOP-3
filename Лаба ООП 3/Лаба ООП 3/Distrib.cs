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
        public static uint Get(uint PassengerCount, double PeakTime, double PeakWidth, uint Minute, uint StationCount)
        {
            Random RNG = new Random();

            LogisticDistribution logis = new LogisticDistribution(PeakTime, PeakWidth);

            uint res = (uint)Math.Round(PassengerCount * logis.ProbabilityDensity(Minute) * 2.0 * RNG.NextDouble() / StationCount);

            logis = null;

            return res;
        }
    }
}
