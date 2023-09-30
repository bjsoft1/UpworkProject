using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpworkProject.Commons.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNull(this string value)
        {
            return value == null;
        }
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return (value == null || value.Trim() == string.Empty);
        }
    }
}
