using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopStuff.Extensions
{
    public static class DecimalMethods
    {
        /// <summary>
        /// Determines whether the decimal is within the specified range, inclusive.
        /// </summary>
        /// <param name="actual">The actual.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <returns></returns>
        public static bool Within(this decimal actual, decimal lower, decimal upper)
        {
            return actual.Within(lower, upper, true);
        }

        /// <summary>
        /// Determines whether the decimal is within the specified range, inclusive..
        /// </summary>
        /// <param name="actual">The actual.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <param name="inclusive">if set to <c>true</c> [inclusive].</param>
        /// <returns></returns>
        public static bool Within(this decimal actual, decimal lower, decimal upper, bool inclusive)
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
