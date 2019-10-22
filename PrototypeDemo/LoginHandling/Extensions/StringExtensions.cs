using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginHandling.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsUpperLowerNumber(this string str)
        {
            Regex rx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            return rx.IsMatch(str);
        }
    }
}
