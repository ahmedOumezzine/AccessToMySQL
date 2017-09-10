using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessToMySQL.Infrastructure.Tools
{
    public static class StringExtension
    {

        public static string TakeMax(this string str, int maxLenghtToTake)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            else
            {
                return str.Substring(0, Math.Min(maxLenghtToTake, str.Length));
            }
        }
    }
}
