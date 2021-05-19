using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiotGamesAPI
{
    public static class Utilities
    {
        /// <summary>
        /// Convert epoch to human readable date.
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns>DateTime</returns>
        public static DateTime ConvertToDateTime(double unixTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimeStamp).ToLocalTime();
        }
    }
}
