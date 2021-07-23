// ////////////////////////////////////////////////////
// StartTime:      2020/12/2 21:22
// FileName:       DatetimeExtensions.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
// according to https://stackoverflow.com/questions/9814060/how-to-convert-datetime-to-timestamp-using-c-net-ignoring-current-timezone
using System;
namespace DBACommonPackage.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// ToUnixTimestampMilliseconds
        /// </summary>
        /// <param name="dateTime">should be utc time</param>
        /// <returns></returns>
        public static long ToUnixTimestampMilliseconds(this DateTime dateTime)
        {
            return dateTime.Ticks /10000L - 62135596800000L;
        }
        /// <summary>
        /// ToUnixTimestamp
        /// </summary>
        /// <param name="dateTime">should be utc time</param>
        /// <returns></returns>
        public static long ToUnixTimestamp(this DateTime dateTime)
        {
            return (dateTime.Ticks / 10000L - 62135596800000L) / 1000L;
        }
    }
}
