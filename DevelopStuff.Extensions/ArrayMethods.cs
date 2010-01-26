using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopStuff.Extensions
{
    public static class ArrayMethods
    {
        /// <summary>
        /// Takes an array and turns it into a sentence.
        /// </summary>
        /// <param name="things">The things.</param>
        /// <returns></returns>
        public static string ToSentence(this Array things)
        {
            string sentence = string.Empty;

            if (things.IsNull()) throw new ArgumentNullException("The array is null.");

            if (things.Length == 0)
            {
                return sentence;
            }

            if (things.GetValue(0).IsNotNull())
            {
                sentence += things.GetValue(0).ToString();
            }

            if (things.Length > 1)
            {
                for (int i = 1; i < things.Length; i++)
                {
                    if (things.GetValue(i).IsNotNull())
                    {
                        if (i == (things.Length - 1))
                        {
                            sentence += ", and " + things.GetValue(i).ToString();
                        }
                        else
                        {
                            sentence += ", " + things.GetValue(i).ToString();
                        }
                    }
                }
            }

            return sentence;
        }
    }
}
