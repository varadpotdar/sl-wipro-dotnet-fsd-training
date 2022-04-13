using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal static class Extensions
    {
        /// <summary>
        /// For the pass date time vlaue this method checks if the year is a leap year or not
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static bool IsLeapYear(this DateTime dateTime)
        {
            return (dateTime.Year % 2 == 0);
        }

        public static int GetWordCount(this string sentence)
        {
            return sentence.Split(' ').Length;
        }
    }
}
