using System;
using System.ComponentModel;
using System.Linq;

namespace Common
{
   public static class Extensions
    {
        public static bool HasAttribute<T>(this Object obj)
        {
            var field = obj.GetType().GetField(obj.ToString());
            var attrs = field
                .GetCustomAttributes(typeof(T), false)
                .Select(x => (T)x)
                .ToList();
            return attrs.Any();
        }

        public static string GetDescription(this Object obj)
        {
            var field = obj.GetType().GetField(obj.ToString());
            var attrs = field
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .Select(x => (DescriptionAttribute)x)
                .ToList();
            return attrs.Any() ? attrs[0].Description : obj.ToString();
        }
    }
}
