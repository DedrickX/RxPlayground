using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUiExample
{
    public static class Extensions
    {
        public static int TryParseIntOrDefault(this string text)
        {
            int result = 0;
            int.TryParse(text, out result);
            return result;
        }

        public static decimal TryParseDecimalOrDefault(this string text)
        {
            decimal result = 0;
            decimal.TryParse(text, out result);
            return result;
        }
    }
}
