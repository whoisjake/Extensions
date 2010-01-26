using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopStuff.Extensions
{
    public static class IntegerMethods
    {
        /// <summary>
        /// Returns a <see cref="DateTime"/> N number of seconds ago
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns></returns>
        public static DateTime SecondsAgo(this int seconds)
        {
            return DateTime.Now.AddSeconds(-1 * seconds);
        }

        /// <summary>
        /// Returns a <see cref="DateTime"/> N number of minutes ago
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns></returns>
        public static DateTime MinutesAgo(this int minutes)
        {
            return DateTime.Now.AddMinutes(-1 * minutes);
        }

        /// <summary>
        /// Returns a <see cref="DateTime"/> N number of days ago
        /// </summary>
        /// <param name="days">The days.</param>
        /// <returns></returns>
        public static DateTime DaysAgo(this int days)
        {
            return DateTime.Now.AddDays(-1 * days);
        }

        /// <summary>
        /// Returns a <see cref="DateTime"/> N number of months ago
        /// </summary>
        /// <param name="months">The months.</param>
        /// <returns></returns>
        public static DateTime MonthsAgo(this int months)
        {
            return DateTime.Now.AddMonths(-1 * months);
        }

        /// <summary>
        /// Returns a <see cref="DateTime"/> N number of years ago
        /// </summary>
        /// <param name="years">The years.</param>
        /// <returns></returns>
        public static DateTime YearsAgo(this int years)
        {
            return DateTime.Now.AddYears(-1 * years);
        }

        /// <summary>
        /// Determines whether the integer is within the specified range, inclusive.
        /// </summary>
        /// <param name="actual">The actual.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <returns></returns>
        public static bool Within(this int actual, int lower, int upper)
        {
            return actual.Within(lower, upper, true);
        }

        /// <summary>
        /// Determines whether the integer is within the specified range, inclusive..
        /// </summary>
        /// <param name="actual">The actual.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <param name="inclusive">if set to <c>true</c> [inclusive].</param>
        /// <returns></returns>
        public static bool Within(this int actual, int lower, int upper, bool inclusive)
        {

            if (lower > upper)
            {
                throw new ArgumentException("The lower bound can't be greater than the upper boundary.", "lower");
            }

            if (inclusive)
            {
                return ((actual >= lower) && (actual <= upper));
            }

            return ((actual > lower) && (actual < upper));
        }
    }
}
