using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UpworkProject.Commons.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayValue(this Enum value)
        {
            return value.GetType().GetMember(value.ToString())[0].GetCustomAttribute<DisplayAttribute>()?.GetName() ?? value.ToString();
        }
        public static int GetValue(this Enum value)
        {
            return Convert.ToInt32(value);
        }
    }
}
