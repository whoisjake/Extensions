using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopStuff.Extensions
{
    public static class DateTimeMethods
    {
        /// <summary>
        /// Returns a string that is human readable.
        /// Examples: 
        /// just now.
        /// 5 seconds ago.
        /// 2 days ago.
        /// 3 weeks ago.
        /// 3 years ago.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static string ToHumanReadableString(this DateTime date)
        {
            TimeSpan difference = DateTime.Now.Subtract(date);
            string result =
                    ((int)difference.TotalSeconds == 0) ? "just now" :
                    ((int)difference.TotalSeconds == 1) ? "1 second ago" :
                    ((difference.TotalSeconds > 1) && (difference.TotalSeconds < 60)) ? string.Format("{0:#} seconds ago", difference.TotalSeconds) :
                    ((int)difference.TotalMinutes == 1) ? "1 minute ago" :
                    ((difference.TotalMinutes > 1) && (difference.TotalMinutes < 60)) ? string.Format("{0:#} minutes ago", difference.TotalMinutes) :
                    ((int)difference.TotalHours == 1) ? "1 hour ago" :
                    ((difference.TotalHours > 1) && (difference.TotalHours < 24)) ? string.Format("{0:#} hours ago", difference.TotalHours) :
                    ((int)difference.TotalDays == 1) ? "1 day ago" :
                    ((difference.TotalDays > 1) && (difference.TotalDays < 28)) ? string.Format("{0:#} days ago", difference.TotalDays) :
                    (((int)difference.TotalDays >= 28) && ((int)difference.TotalDays <= 31)) ? "1 month ago" :
                    ((difference.TotalDays > 31) && (difference.TotalDays < 365)) ? string.Format("{0:#} months ago", (int)(difference.TotalDays / 30)) :
                    (((int)difference.TotalDays >= 365) && (difference.TotalDays < 730)) ? "1 year ago" :
                    ((int)difference.TotalDays >= 730) ? string.Format("{0:#} years ago", (int)(difference.TotalDays / 365)) : "in the future";

            return result;
        }
    }
}
