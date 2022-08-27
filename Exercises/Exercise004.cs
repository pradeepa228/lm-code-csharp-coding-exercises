using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            int giga = 1000000000;
            DateTime dateGiga = dateTime.AddSeconds(giga);
            return dateGiga;
        }
    }
}
