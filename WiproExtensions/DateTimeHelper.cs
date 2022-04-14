using System;

namespace WiproExtensions
{
    public static class DateTimeHelper
    {
        public static bool IsLeapYear(this DateTime dateTime)
        {
            int year = dateTime.Year;

            if (year % 100 == 0) //if the year is a century
                return year % 400 == 0; //a leap year should be divisible by 400
            
            return year % 4 == 0; //else it should be divisible by 4
        }
    }
}
