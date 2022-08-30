using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            int ONE_GIGA_SECOND = 1000000000;
            DateTime dateGiga = dateTime.AddSeconds(ONE_GIGA_SECOND);
            return dateGiga;
        }
    }
}
