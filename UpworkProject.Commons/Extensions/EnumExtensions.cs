using System.ComponentModel.DataAnnotations;
using System.Reflection;
using UpworkProject.Commons.Dtos;

namespace UpworkProject.Commons.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayValue(this Enum value)
        {
            return value.GetType().GetMember(value.ToString())[0].GetCustomAttribute<DisplayAttribute>()?.GetName() ?? value.ToString();
        }
        public static EnumDto GetValueDto(this Enum value) 
        {
            return new EnumDto
            {
                DisplayName = value.GetType().GetMember(value.ToString())[0].GetCustomAttribute<DisplayAttribute>()?.GetName() ?? value.ToString(),
                Id = value.GetValue(),
            };
             ;
        }
        public static int GetValue(this Enum value)
        {
            return Convert.ToInt32(value);
        }
        public static List<EnumDto> GetEnumVeriableList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .OfType<T>()
                       .Select(e => new EnumDto
                       {
                           DisplayName = e.ToString(),
                           Id = Convert.ToInt32(e)
                       }).ToList();
        }

    }
}
