using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Extension.Teamproject.Demo1
{
    public static class DateTimeExtensions
    {

        public static string ToLegacyFormat(this DateTime date)
        {
            return date.Year > 1930 ? date.ToString("1yyMMdd") : date.ToString("0yyMMdd");
        
        }
        public static string ToLegacyFormat(this string name)
        {
            var parts = name.ToUpper().Split(' ');
            return parts[1] + parts[0];
        }
    }
}