using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RE.CoreWebApp.Validation
{
    using System.Text.RegularExpressions;
    public class Utility
    {

        static Regex RegexSimple(string pattern)
        {
            var regex = new Regex(pattern);
            return regex;
        }

        static Regex RegexMedium(string pattern, RegexOptions option)
        {
            var regex = new Regex(pattern, option);
            return regex;
        }

        static Regex RegexMEGA(string pattern, RegexOptions option, TimeSpan time)
        {
            var regex = new Regex(pattern, option, time);
            return regex;
        }
    }
}