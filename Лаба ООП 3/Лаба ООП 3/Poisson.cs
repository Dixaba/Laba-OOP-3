using System;

namespace Лаба_ООП_3
{
    ////////////////////////////////////////////////
    //                                            //
    //  DEPRECATED! Do not use until Apocalypse!  //
    //                                            //
    ////////////////////////////////////////////////

    static class Poisson
    {
        static double AntiFact(double a, uint x)
        {
            if (x <= 1) return a;

            double res = a;
            for (UInt64 i = 2; i <= x; i++)
                res /= i;
            return res;
        }
        public static UInt32 Get(UInt32 IntervalNumber, UInt32 PassengerCount, double Lambda, UInt32 StationCount)
        {
            double m = IntervalNumber * 1.0;
            
            Random RNG = new Random();

            double res = Math.Pow(Lambda, m) * Math.Exp(-Lambda) * PassengerCount * 2.0 * RNG.NextDouble() / StationCount;

            return (UInt32)Math.Round(res);
        }
    }
}
