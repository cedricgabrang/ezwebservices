﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZWebServices.Helpers
{
    public class DateTimeHelper
    {
        public static DateTime ValidateDateTime(string dateTime)
        {
            try
            {
                return Convert.ToDateTime(dateTime);
            }

            catch
            {
                return DateTime.MinValue;
            }
        }

        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long ConvertToTimestamp(DateTime value)
        {
            TimeSpan elapsedTime = value - Epoch;
            return (long)elapsedTime.TotalSeconds;
        }
    }
}