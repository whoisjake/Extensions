﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopStuff.Extensions
{
    public static class ObjectMethods
    {
        /// <summary>
        /// Determines whether the specified object is null.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>
        /// 	<c>true</c> if the specified object is null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        /// <summary>
        /// Determines whether the specified object is not null.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>
        /// 	<c>true</c> if the specified object is not null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNotNull(this object obj)
        {
            return !IsNull(obj);
        }
    }
}
