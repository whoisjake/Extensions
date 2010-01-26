using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopStuff.Extensions
{
    public static class StringMethods
    {

        /// <summary>
        /// Returns the first N characters from the string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public static string First(this string input, int count)
        {
            if (input.IsNull())
            {
                throw new ArgumentNullException("input", "The input string can't be null.");
            }

            count = (input.Length <= count) ? input.Length : count;

            return input.Substring(0, count);
        }

        /// <summary>
        /// Returns the last N characters from the string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public static string Last(this string input, int count)
        {
            if (input.IsNull())
            {
                throw new ArgumentNullException("input", "The input string can't be null.");
            }

            count = (count > input.Length) ? input.Length : count;

            return input.Substring(input.Length - count,count);
        }


        /// <summary>
        /// Returns the string starting at N to the end.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public static string From(this string input, int count)
        {
            if (input.IsNull())
            {
                throw new ArgumentNullException("input", "The input string can't be null.");
            }

            count = (count > input.Length) ? input.Length : count;

            int index = count;
            int length = input.Length - index;

            return input.Substring(index, length);
        }

        /// <summary>
        /// Tries to parse the string into an integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string input)
        {
            if (input.IsNull())
            {
                throw new ArgumentNullException("input", "The input string can't be null.");
            }

            DateTime defaultDate;
            DateTime.TryParse(input, out defaultDate);
            return defaultDate;
        }

        /// <summary>
        /// Tries to parse the string into an integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static int ToInt(this string input)
        {
            if (input.IsNull())
            {
                throw new ArgumentNullException("input", "The input string can't be null.");
            }

            int defaultValue = 0;
            int.TryParse(input, out defaultValue);
            return defaultValue;
        }



        /// <summary>
        /// Tries to parse the string into a decimal.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string input)
        {
            if (input.IsNull())
            {
                throw new ArgumentNullException("input", "The input string can't be null.");
            }

            decimal defaultValue = 0;
            decimal.TryParse(input, out defaultValue);
            return defaultValue;
        }
    }
}
